using System;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ShareOnLan
{
    public class TcpTxFile
    {
        private UserInfo userInfo;
        private readonly MainForm mainForm;

        public TcpTxFile(UserInfo userInfo, MainForm mainForm)
        {
            this.userInfo = userInfo;
            this.mainForm = mainForm;
        }

        public void SendInitialization()
        {
            Thread thread_send = new Thread(new ParameterizedThreadStart(TaskInvio))
            {
                Name = "InvioFileThread",
                IsBackground = true
            };
            thread_send.SetApartmentState(ApartmentState.STA);
            object[] parameters = new object[] { mainForm };
            thread_send.Start(parameters);
            //Thread.Sleep(1000);
        }

        public void TaskInvio(object parameters)
        {
            SendBarForm sendBarForm = null;
            long dimensioneFile = 0;
            //soltanto il nome(filename) da aggiungere all'header
            FileStream fileStream = null;
            NetworkStream stream = null;
            object[] par = parameters as object[];
            MainForm form = (MainForm)par[0];
            bool isDirectory = false;
            try
            {
                string ip_dst = userInfo.StringLocalEp;
                string username = Properties.Settings.Default.PublicUsername;
                int port = Properties.Settings.Default.PortTCP;

                string path_file = mainForm.SelectedFilePath;
                //controllo se ho selezionato una directory o un file
                //salvo in una variabile(isDirectory) perchè uso il risultato più sotto(sendHeader(..))
                isDirectory = CheckIfIsDirectory(path_file);

                //se è una directory la comprimo in formato zip
                if (isDirectory)
                {
                    //comprimo
                    path_file = CompressFile(path_file);
                }

                //quando il client ha settato "accetta tutti i file" questo notifica ha poco senso
                //perchè appare insieme al form di invio
                mainForm.DefaultNotifyIcon.BalloonTipTitle = String.Format("Invio file a {0} in corso...", userInfo.Username);
                mainForm.DefaultNotifyIcon.BalloonTipText = "In attesa di risposta";
                mainForm.DefaultNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                mainForm.DefaultNotifyIcon.ShowBalloonTip(1000);

                string filename = Path.GetFileName(path_file);
                fileStream = new FileStream(path_file, FileMode.Open, FileAccess.Read);
                dimensioneFile = fileStream.Length;
                TcpClient senderTcp = new TcpClient(ip_dst, port);
                stream = senderTcp.GetStream();
                stream.ReadTimeout = 30000;

                //invio header al dest
                SendHeader(stream, username, fileStream, filename);

                string response = ResponseIsOK(stream);

                if (response.Equals("ok"))
                {
                    mainForm.Invoke((MethodInvoker)delegate
                    {
                        sendBarForm = new SendBarForm(form, userInfo, stream, fileStream, senderTcp, isDirectory);
                        sendBarForm.Show();
                    });
                }
                else if (response.Equals("no"))
                {
                    mainForm.Invoke((MethodInvoker)delegate
                    {
                        mainForm.DefaultNotifyIcon.BalloonTipTitle = "Invio annullato";
                        mainForm.DefaultNotifyIcon.BalloonTipText = String.Format("{0} ha rifiutato il file", userInfo.Username);
                        mainForm.DefaultNotifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                        mainForm.DefaultNotifyIcon.ShowBalloonTip(1000);
                    });
                    //rilascio le risorse inutilizzate
                    stream.Dispose();
                    stream.Close();
                    fileStream.Dispose();
                    fileStream.Close();

                    //elimino zip temporaneo
                    Utilities.CleanTempfile(isDirectory, fileStream.Name);
                }
            }
            catch (IOException)
            {
                //rilascio le risorse inutilizzate
                stream.Dispose();
                stream.Close();
                fileStream.Dispose();
                fileStream.Close();

                //elimino zip temporaneo
                Utilities.CleanTempfile(isDirectory, fileStream.Name);

                mainForm.Invoke((MethodInvoker)delegate
                {
                    Monitor.Enter(mainForm.Obj);
                    mainForm.UsersListView.Items.RemoveByKey(userInfo.StringLocalEp);
                    Monitor.Exit(mainForm.Obj);
                    mainForm.DefaultNotifyIcon.BalloonTipTitle = "Impossibile inviare il file";
                    mainForm.DefaultNotifyIcon.BalloonTipText = (String.Format("{0} è offline", userInfo.Username));
                    mainForm.DefaultNotifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                    mainForm.DefaultNotifyIcon.ShowBalloonTip(1000);
                });

            }
            catch (SocketException)
            {
                fileStream.Dispose();
                fileStream.Close();

                //elimino zip temporaneo
                Utilities.CleanTempfile(isDirectory, fileStream.Name);

                mainForm.Invoke((MethodInvoker)delegate
                {
                    Monitor.Enter(mainForm.Obj);
                    mainForm.UsersListView.Items.RemoveByKey(userInfo.StringLocalEp);
                    Monitor.Exit(mainForm.Obj);
                    mainForm.DefaultNotifyIcon.BalloonTipTitle = "Impossibile inviare il file";
                    mainForm.DefaultNotifyIcon.BalloonTipText = (String.Format("{0} è offline", userInfo.Username));
                    mainForm.DefaultNotifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                    mainForm.DefaultNotifyIcon.ShowBalloonTip(1000);
                });
            }
            catch (Exception ex)
            {
                //rilascio le risorse inutilizzate
                fileStream.Dispose();
                fileStream.Close();

                mainForm.Invoke((MethodInvoker)delegate
                {
                    MaterialMessageBox.Show(ex.ToString());
                });
                Application.Exit();
            }
        }

        public void SendHeader(NetworkStream stream, String username, FileStream fs, String filename)
        {
            int bufferSize = 256;
            byte[] header = new byte[bufferSize];
            HeaderTcp headerTcp = new HeaderTcp();
            header = headerTcp.CreateHeaderTcp(username, fs, filename, header);
            stream.Write(header, 0, header.Length);
        }

        public string ResponseIsOK(NetworkStream stream)
        {
            //sto in attesa della conferma da parte del server
            byte[] bytes = Encoding.ASCII.GetBytes("ok");
            Byte[] data = new byte[bytes.Length];
            stream.Read(data, 0, data.Length);
            string response = Encoding.ASCII.GetString(data).ToString();

            if (response.Equals("ok"))
                return "ok";
            else if (response.Equals("no"))
            {
                return "no";
            }
            else
            {
                throw new IOException();
            }

        }

        //controllo se devo inviare un file o directory
        public bool CheckIfIsDirectory(String path_file)
        {
            FileAttributes attr = File.GetAttributes(path_file);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                //è una directory
                return true;
            else
                return false;
        }

        //comprimo il file, e ritorno il path del file compresso
        public string CompressFile(string startPath)
        {
            string zipPath = String.Empty;

            mainForm.DefaultNotifyIcon.BalloonTipTitle = Path.GetFileName(startPath);
            mainForm.DefaultNotifyIcon.BalloonTipText = "Compressione file in corso...";
            mainForm.DefaultNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            mainForm.DefaultNotifyIcon.ShowBalloonTip(1000);

            try
            {
                zipPath = String.Format("{0}.zip", startPath);
                zipPath = Utilities.CheckIfFileExists(zipPath);
                ZipFile.CreateFromDirectory(startPath, zipPath);
            }
            catch
            {
                throw new Exception();
            }

            return zipPath;
        }
    }
}
