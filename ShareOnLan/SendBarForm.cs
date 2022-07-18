using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ShareOnLan
{
    public partial class SendBarForm : MaterialFormTemplate
    {
        private BackgroundWorker worker = new BackgroundWorker();
        private MainForm mainForm;
        private UserInfo userInfo;
        private NetworkStream stream = null;
        FileStream fileStream = null;
        private TcpClient senderTcp = null;
        private string ip_dst;
        private string username;
        private int port;
        bool completed = false;
        bool isDirectory = false;

        public SendBarForm(MainForm mainForm, UserInfo userInfo, NetworkStream stream, FileStream fileStream, TcpClient senderTcp, bool isDirectory)
        {
            this.userInfo = userInfo;
            this.mainForm = mainForm;
            this.stream = stream;
            this.fileStream = fileStream;
            this.senderTcp = senderTcp;
            this.isDirectory = isDirectory;

            ip_dst = userInfo.StringLocalEp;
            username = Properties.Settings.Default.PublicUsername;
            port = Properties.Settings.Default.PortTCP;

            InitializeComponent();

            sendingInfoLabel.Text = String.Format("Invio file a {0}", userInfo.Username);
            fileNameTextbox.Text = Path.GetFileName(fileStream.Name);

            //registro metodo del worker, lo setto in modo da poter essere cancellato, reportprogress non sfruttato 
            worker.DoWork += new DoWorkEventHandler(SendFileTCP);
            worker.ProgressChanged += new ProgressChangedEventHandler(Worker_progressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_Completed);
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.RunWorkerAsync();
        }

        //inizializzazione invio, scheletro di controllo operazione
        public void SendFileTCP(object sender, DoWorkEventArgs e)
        {
            long dimensioneFile = fileStream.Length;
            try
            {
                //se ho ricevuto conferma da parte dell'host remoto, invio file
                int bufferSize = 1000000;
                byte[] buffer = new byte[bufferSize];
                int bytesRead = 0;
                int sent = 0;
                int modulo = (int)dimensioneFile % buffer.Length;
                int blocchiFile = (int)dimensioneFile / buffer.Length;
                int blocchiInviati = 0;
                int percentage_completed = 0;
                BinaryReader br = new BinaryReader(fileStream);

                //Inizializzo timer
                //usato per calcolare tempo esecuzione di un metodo
                TimeSpan time = new TimeSpan();
                Stopwatch start_timer = new Stopwatch();
                start_timer.Start();
                double time_now = 0;
                double speed = 0;
                double time_remained = 0;


                while (!worker.CancellationPending && (bytesRead = br.Read(buffer, 0, buffer.Length)) != 0)
                {
                    if (!NetworkInterface.GetIsNetworkAvailable())
                        throw new SocketException();

                    if (blocchiInviati < blocchiFile)
                    {
                        stream.Write(buffer, 0, buffer.Length);
                        blocchiInviati += bytesRead / buffer.Length;
                        sent += bytesRead;
                        percentage_completed = GetPercentageCompleted(sent, dimensioneFile);
                        //Tempo rimanente, gli passo anche le variabili così mi aggiorna speed, ecc...
                        time = CalculateRemainingTime(start_timer, time, time_now, speed, time_remained, sent, dimensioneFile);

                        mainForm.Invoke((MethodInvoker)delegate
                        {
                            sentByteLabel.Text = Utilities.GetFileSizeWithUnit(sent) + " su " + Utilities.GetFileSizeWithUnit(dimensioneFile);
                            timeTextbox.Text = String.Format("Circa: {0}", time.ToString(@"hh\h\:mm\m\:ss\s"));
                        });

                        //aggiorna la bar
                        worker.ReportProgress(percentage_completed);
                    }
                    else
                    {
                        stream.Write(buffer, 0, modulo);
                        sent += modulo;
                        percentage_completed = GetPercentageCompleted(sent, dimensioneFile);
                        //Tempo rimanente, gli passo anche le variabili così mi aggiorna speed, ecc...
                        time = CalculateRemainingTime(start_timer, time, time_now, speed, time_remained, sent, dimensioneFile);

                        mainForm.Invoke((MethodInvoker)delegate
                        {
                            sentByteLabel.Text = Utilities.GetFileSizeWithUnit(sent) + " su " + Utilities.GetFileSizeWithUnit(dimensioneFile);
                            timeTextbox.Text = String.Format("Circa: {0}", time.ToString(@"hh\h\:mm\m\:ss\s"));
                        });

                        //aggiorna la bar
                        worker.ReportProgress(percentage_completed);
                        break;
                    }
                }

                if (sent == dimensioneFile)
                    completed = true;
                //cancello .zip se ho zippato
                fileStream.Dispose();
                fileStream.Close();
                Utilities.CleanTempfile(isDirectory, fileStream.Name);
                senderTcp.Close();
            }
            catch (IOException)
            {
                //annullato trasferimento lato ricevente
                worker.CancelAsync();

                fileStream.Dispose();
                fileStream.Close();
                Utilities.CleanTempfile(isDirectory, fileStream.Name);
                senderTcp.Close();
            }
            catch (SocketException)
            {
                //annullato trasferimento lato ricevente
                worker.CancelAsync();

                fileStream.Dispose();
                fileStream.Close();
                Utilities.CleanTempfile(isDirectory, fileStream.Name);
                senderTcp.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                fileStream.Dispose();
                fileStream.Close();
                Utilities.CleanTempfile(isDirectory, fileStream.Name);
                senderTcp.Close();
            }
        }

        //gestione della progressBar
        private void Worker_progressChanged(object sender, ProgressChangedEventArgs e)
        {
            percentageLabel.Text = String.Format("Completamento operazione: {0}%", e.ProgressPercentage.ToString());
            sendingProgressBar.Value = e.ProgressPercentage;
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
                    closeButton.Visible = true;
                    undoButton.Visible = false;
                }
                else
                {
                    mainForm.DefaultNotifyIcon.BalloonTipTitle = Path.GetFileName(fileStream.Name);
                    mainForm.DefaultNotifyIcon.BalloonTipText = "Trasferimento completato";
                    mainForm.DefaultNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                    mainForm.DefaultNotifyIcon.ShowBalloonTip(1000);
                    Close();
                }


                fileStream.Dispose();
                fileStream.Close();
                Utilities.CleanTempfile(isDirectory, fileStream.Name);
                senderTcp.Close();
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
                    mainForm.DefaultNotifyIcon.BalloonTipTitle = Path.GetFileName(fileStream.Name);
                    mainForm.DefaultNotifyIcon.BalloonTipText = "Trasferimento annullato";
                    mainForm.DefaultNotifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                    mainForm.DefaultNotifyIcon.ShowBalloonTip(1000);
                    Close();
                }

                fileStream.Dispose();
                fileStream.Close();
                Utilities.CleanTempfile(isDirectory, fileStream.Name);
                senderTcp.Close();

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
                speedTextbox.Text = string_speed + " MB/s";
            });

            return time;
        }

        //cancello il worker
        private void UndoButton_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();

            fileStream.Dispose();
            fileStream.Close();
            Utilities.CleanTempfile(isDirectory, fileStream.Name);
            senderTcp.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendBarForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && !completed && !worker.CancellationPending)
            {
                mainForm.DefaultNotifyIcon.BalloonTipTitle = Path.GetFileName(fileStream.Name);
                mainForm.DefaultNotifyIcon.BalloonTipText = "Invio in corso...";
                mainForm.DefaultNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                mainForm.DefaultNotifyIcon.ShowBalloonTip(1000);
            }
            else if (WindowState == FormWindowState.Minimized && completed)
            {
                //se riduce a icona e il trasferimento è completato, chiudo il form
                Close();
            }
        }
    }
}
