using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareOnLan
{
    static class Program
    {
        public static MainForm mainForm;

        public static string AppDataFolder { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Mutex per l'acquisizione dell'istanza del processo
            Mutex mutex = new Mutex(true, "ShareOnLan", out bool started);

            //Se il mutex è stato già acquisito vuol dire che un'istanza del programma è già in esecuzione
            //Aggiorno soltanto il path del file
            if (!started)
            {
                try
                {
                    if (args[0] != null || !args[0].Equals(String.Empty))
                    {
                        //processo client invia sullo stream il nuovo nome del file
                        var client = new NamedPipeClientStream("ShareOnLanPipe");
                        client.Connect();
                        StreamWriter writer = new StreamWriter(client);

                        string input = args[0]; //args[0] è il nome del file selezionato
                        //scrivo il nome sullo stream
                        writer.WriteLine(input);
                        writer.Flush();
                        client.Close();
                    }
                }
                catch (Exception)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    MaterialMessageBox.Show("ShareOnLan è già in esecuzione in background.");
                    Application.Exit();
                }

            }
            else
            {
                //avvio task form che sta scatta con nuove selezioni desktop
                try
                {
                    //è la routine che si occupa di leggere dalla namedPipe il nome del file selezionato
                    StartServer();
                    Task.Delay(1000).Wait();

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    if (args.Length > 0) //è stato selezionato un file da inviare con il tasto destro
                    {
                        mainForm = new MainForm(args[0]);
                        Application.Run(mainForm);
                    }
                    else //l'applicazione è stata avviata facendo doppio click sul .exe
                    {
                        mainForm = new MainForm();
                        Application.Run(mainForm);
                    }

                }
                catch (Exception)
                {
                    MaterialMessageBox.Show("Errore! L'applicazione verrà chiusa");
                    Application.Exit();
                }

            }

            //evita che il garbage collector liberi il mutex
            GC.KeepAlive(mutex);
        }

        //routine che legge dallo stream e aggiorna il form
        static void StartServer()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    NamedPipeServerStream server = null;
                    try
                    {
                        server = new NamedPipeServerStream("ShareOnLanPipe");
                        server.WaitForConnection();

                        StreamReader reader = new StreamReader(server);
                        string selectedFilePath = reader.ReadLine();
                        string fileName = Path.GetFileName(selectedFilePath);
                        //update del form
                        mainForm.Invoke((MethodInvoker)delegate
                        {
                            //setto la label del form
                            mainForm.PathTitleBar = String.Format("Condividi \"{0}\" con", fileName);
                            //sett il path del file da inviare
                            mainForm.SelectedFilePath = selectedFilePath;
                            mainForm.Visible = true;
                            mainForm.WindowState = FormWindowState.Normal;
                        });
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }
                    finally
                    {
                        server.Close();
                    }
                }

            });

        }
    }
}
