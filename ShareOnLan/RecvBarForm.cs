using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ShareOnLan
{
    public partial class RecvBarForm : MaterialFormTemplate
    {
        delegate void SetTextCallback(int i, double estimated_seconds, double received, double dimension);
        private BackgroundWorker worker = new BackgroundWorker();
        private MainForm mainForm;
        private HeaderTcp headerTcp;
        private NetworkStream networkStream;
        private TcpClient receiver;
        bool completed;
        string filePath = String.Empty;

        public RecvBarForm(TcpClient receiver, MainForm mainForm, HeaderTcp headerTcp, NetworkStream networkStream)
        {
            //inizializzo worker per la ricezione del file
            this.networkStream = networkStream;
            this.mainForm = mainForm;
            this.receiver = receiver;
            this.headerTcp = headerTcp;

            InitializeComponent();

            receivingInfoLabel.Text = "Ricezione file da " + headerTcp.Username;
            fileNameTextbox.Text = headerTcp.Filename;

            //registro metodo del worker
            worker.DoWork += new DoWorkEventHandler(FileReceiver);
            worker.ProgressChanged += new ProgressChangedEventHandler(Worker_progressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_Completed);
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.RunWorkerAsync();
        }



        //inizializzo ricezione del file, scheletro gestione ricezione
        public void FileReceiver(object sender, DoWorkEventArgs e)
        {
            int bufferSize = 1000000;
            byte[] buffer = new byte[bufferSize];
            int bytesRead = 0;
            int received = 0;
            int percentage_completed = 0;
            long dimensioneFile = headerTcp.Filesize;
            string filename = String.Format("\\{0}", headerTcp.Filename);
            string username = headerTcp.Username;

            filePath = Utilities.CheckIfFileExists(String.Format("{0}{1}", Properties.Settings.Default.DownloadPath, filename));
            //aggiorna la textBox se ho file(1)
            if (!filePath.Equals(filename))
            {
                mainForm.Invoke((MethodInvoker)delegate
                {
                    fileNameTextbox.Text = Path.GetFileName(filePath);
                });
            }
            using (FileStream fileStream = File.Create(filePath))
            {
                //Inizializzo timer
                //usato per calcolare tempo esecuzione di un metodo
                TimeSpan time = new TimeSpan();
                Stopwatch start_timer = new Stopwatch();
                start_timer.Start();
                double time_now = 0;
                double speed = 0;
                double time_remained = 0;
                try
                {
                    while (!worker.CancellationPending && (bytesRead = networkStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                        received += bytesRead;
                        percentage_completed = GetPercentageCompleted(received, dimensioneFile);

                        time = CalculateRemainingTime(start_timer, time, time_now, speed, time_remained, received, dimensioneFile);

                        mainForm.Invoke((MethodInvoker)delegate
                        {
                            receivedByteLabel.Text = String.Format("{0} su {1}", Utilities.GetFileSizeWithUnit(received), Utilities.GetFileSizeWithUnit(dimensioneFile));
                            timeTextbox.Text = String.Format("Circa: {0}", time.ToString(@"hh\h\:mm\m\:ss\s"));
                        });

                        worker.ReportProgress(percentage_completed);
                    }
                }
                catch (IOException)
                {
                    worker.CancelAsync();
                }
                //controllo se ho ricevuto tutto il file
                if (received == dimensioneFile)
                {
                    completed = true;
                }

            }

            //chiudo il TcpClient
            receiver.Close();
        }

        //gestione della progressBar
        private void Worker_progressChanged(object sender, ProgressChangedEventArgs e)
        {
            percentageLabel.Text = String.Format("Completamento operazione: {0}%", e.ProgressPercentage.ToString());
            receivingProgressBar.Value = e.ProgressPercentage;
        }

        //metodo che scatta quando completo operazione
        private void Worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {

            if (completed)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    percentageLabel.Text = "Trasferimento completato";
                    undoMaterialButton.Visible = false;
                    openFolderButton.Visible = true;
                    openFileButton.Visible = true;
                    undoButton.Visible = false;
                }
                else
                {
                    percentageLabel.Text = "Trasferimento completato";
                    undoMaterialButton.Visible = false;
                    openFolderButton.Visible = true;
                    openFileButton.Visible = true;
                    undoButton.Visible = false;
                    WindowState = FormWindowState.Normal;
                }

                //chiudo il TcpClient
                receiver.Close();
            }
            else
            {

                if (WindowState == FormWindowState.Normal)
                {
                    percentageLabel.Text = "Trasferimento annullato";
                    undoMaterialButton.Visible = false;
                    closeButton.Visible = true;
                    undoButton.Visible = false;
                }
                else
                {
                    percentageLabel.Text = "Trasferimento annullato";
                    mainForm.DefaultNotifyIcon.BalloonTipTitle = fileNameTextbox.Text;
                    mainForm.DefaultNotifyIcon.BalloonTipText = "Trasferimento annullato";
                    mainForm.DefaultNotifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                    mainForm.DefaultNotifyIcon.ShowBalloonTip(1000);
                    Close();
                }


                //chiudo il TcpClient
                receiver.Close();
                File.Delete(filePath);

            }

        }

        public int GetPercentageCompleted(int sended, long dimensioneFile)
        {
            int percentage_completed = (int)(((float)sended * 100) / (float)dimensioneFile);
            return percentage_completed;
        }

        public TimeSpan CalculateRemainingTime(Stopwatch start_timer, TimeSpan time, double time_now, double speed, double time_remained, int sended, long dimensioneFile)
        {
            //Leggo quanti secondi sono passati dall'avvio del metodo
            time_now = start_timer.Elapsed.TotalSeconds;
            speed = sended / time_now;

            //quantità restante / velocità
            time_remained = (dimensioneFile - sended) / speed;
            time = TimeSpan.FromSeconds(time_remained);

            string string_speed = Utilities.ConvertBytesToMegabytes((long)speed);
            mainForm.Invoke((MethodInvoker)delegate
            {
                speedTextbox.Text = String.Format("{0} MB/s", string_speed);
            });

            return time;
        }

        //fermo il worker
        private void UndoButton_Click(object sender, EventArgs e)
        {
            //annulla la ricezione del file
            worker.CancelAsync();

            //chiudi il form
            Close();
        }

        private void RecvBarForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !completed && !percentageLabel.Text.Equals("Trasferimento annullato") && !worker.CancellationPending)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Properties.Settings.Default.DownloadPath);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(filePath);
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RecvBarForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && !completed && !worker.CancellationPending && !percentageLabel.Text.Equals("Trasferimento annullato"))
            {
                mainForm.DefaultNotifyIcon.BalloonTipTitle = fileNameTextbox.Text;
                mainForm.DefaultNotifyIcon.BalloonTipText = "Download in corso...";
                mainForm.DefaultNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                mainForm.DefaultNotifyIcon.ShowBalloonTip(1000);
            }
            else if (WindowState == FormWindowState.Minimized && completed)
            {
                Close();
            }
        }



    }
}