using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ShareOnLan
{
    class TcpRxFile
    {
        private MainForm mainForm;

        //gli passo rif a mainForm(per prendere Properties)
        public TcpRxFile(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void StartTcpListener()
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, Properties.Settings.Default.PortTCP);

                listener.Start();


                while (true)
                {
                    TcpClient receiver = new TcpClient();
                    //nuova connessione!
                    receiver = listener.AcceptTcpClient();

                    //se sono online accetto la connessione, altrimenti la rifiuto
                    if (Properties.Settings.Default.IsOnline)
                    {
                        ThreadPool.QueueUserWorkItem(ReceiveFile, new object[] { receiver, mainForm });
                    }
                    else
                    {
                        if (receiver != null)
                            receiver.Close();//con la close(), il mittente si accorge che sono offline
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }

        }

        public void ReceiveFile(object parameter)
        {
            object[] par = parameter as object[];
            NetworkStream stream;
            AskForm askForm = null;
            TcpClient receiver = (TcpClient)par[0];
            MainForm form = (MainForm)par[1];

            stream = receiver.GetStream();
            stream.ReadTimeout = 30000;

            HeaderTcp headerTcp = ReceiveHeader(stream);
            long dimensioneFile = headerTcp.Filesize;
            string filename = String.Format("\\{0}", headerTcp.Filename);
            string username = headerTcp.Username;

            //mostro askForm, se non ho già settato che accetto sempre tutti i file
            if (!Properties.Settings.Default.AcceptAlways)
            {
                mainForm.Invoke((MethodInvoker)delegate
                {
                    askForm = new AskForm(mainForm, headerTcp);
                    askForm.ShowDialog();
                });
            }

            //se ho aperto askForm, e ho accettato il file
            //oppure se sono in modalità AccettaSempre, procedo
            //con la ricezione del file
            if ((askForm != null && askForm.FileAccepted) || Properties.Settings.Default.AcceptAlways)
            {
                SendOKToHost(stream);
                //Inizio ricezione file
                mainForm.Invoke((MethodInvoker)delegate
                {
                    RecvBarForm recvBarForm = new RecvBarForm(receiver, form, headerTcp, stream);
                    recvBarForm.Show();
                });
            }
            else
            {
                SendNOToHost(stream);
            }
        }

        public void SendNOToHost(NetworkStream stream)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes("no");
                stream.Write(data, 0, data.Length);
            }
            catch (SocketException)
            {
                throw new Exception();
            }
        }

        public void SendOKToHost(NetworkStream stream)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes("ok");
                stream.Write(data, 0, data.Length);
            }
            catch (SocketException)
            {
                throw new Exception();
            }
        }

        //ricevo header da mittente
        public HeaderTcp ReceiveHeader(NetworkStream stream)
        {
            int bufferSize = 256;
            byte[] header = new byte[bufferSize];
            string headerStr;

            stream.Read(header, 0, header.Length);
            //socket.Receive(header);
            headerStr = Encoding.ASCII.GetString(header);

            HeaderTcp headerTcp = new HeaderTcp();
            headerTcp.ExtractHeaderFields(headerStr);
            return headerTcp;
        }

    }
}
