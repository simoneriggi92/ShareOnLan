using System;
using System.ComponentModel;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace ShareOnLan
{
    /// <summary>
    /// Form principale di tutta l'applicazione.
    /// Contiene la lista degli utenti online a cui poter inviare i file
    /// </summary>
    public partial class MainForm : MaterialFormTemplate
    {
        private bool firstTime = true; //per mostrare la notifica di esecuzione in background una volta sola
        private SettingsForm settingsForm = null;

        /// <summary>
        /// Questo costruttore (senza parametri) viene chiamato quando l'applicazione
        /// viene lanciata per la prima volta facendo doppio click sul .exe
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            notifyIcon.Icon = Properties.Resources.defaultIcon;
            notifyIcon.Text = String.Format("ShareOnLan{0}Modalità {1}", Environment.NewLine, Properties.Settings.Default.IsOnline ? "Pubblica" : "Privata");
            modalitàToolStripMenuItem.Text = Properties.Settings.Default.IsOnline ? "Passa alla modalità privata" : "Passa alla modalità pubblica";
            StartupSetup();
            //avvio l'applicazione in background nella system tray
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        /// <summary>
        /// Questo costruttore (senza parametri) viene chiamato quando l'applicazione
        /// viene lanciata per la prima volta facendo click col tasto
        /// destro sul file/cartella da inviare
        /// </summary>
        /// <param name="selectedFilePath">Il path del file da inviare</param>
        public MainForm(string selectedFilePath)
        {

            InitializeComponent();
            //setto la title bar del form con il nome del file da inviare
            ChangeTitleBar(selectedFilePath);
            notifyIcon.Icon = Properties.Resources.defaultIcon;
            notifyIcon.Text = String.Format("ShareOnLan{0}Modalità {1}", Environment.NewLine, Properties.Settings.Default.IsOnline ? "Pubblica" : "Privata");
            modalitàToolStripMenuItem.Text = Properties.Settings.Default.IsOnline ? "Passa alla modalità pubblica" : "Passa alla modalità privata";
            StartupSetup();
            //setto il form a Normal per fare apparire la lista di tutti gli utenti online
            WindowState = FormWindowState.Normal;
            //setto il path del file selezionato da inviare
            SelectedFilePath = selectedFilePath;

        }

        /// <summary>
        /// Crea la lista degli utenti e i background worker
        /// </summary>
        private void StartupSetup()
        {
            //istanzio lista degli utenti
            UsersDB = new UsersDB();
            //worker1 -> annuncia l'host a tutti gli altri appartenenti al gruppo multicast
            MyWorker1.DoWork += new DoWorkEventHandler(AnnounceUDP);
            MyWorker1.WorkerReportsProgress = true;
            MyWorker1.WorkerSupportsCancellation = true;
            //worker -> sta in ascolto di nuovi utenti che si annunciano
            MyWorker2.DoWork += new DoWorkEventHandler(ListenerUDP);
            MyWorker2.WorkerSupportsCancellation = true;
            //worker3 -> rimuove utenti inattivi dalla lista/form
            MyWorker3.DoWork += new DoWorkEventHandler(CheckOnlineUsers);
            MyWorker3.WorkerSupportsCancellation = true;
            //worker4 -> sta in ascolto per la ricezione dei file (tcp)
            MyWorker4.DoWork += new DoWorkEventHandler(ListenerTCP);
            MyWorker4.WorkerSupportsCancellation = true;
        }

        //Property per ottenere i BackgroundWorker dall'esterno
        public BackgroundWorker MyWorker1 { get; set; } = new BackgroundWorker();
        public BackgroundWorker MyWorker2 { get; set; } = new BackgroundWorker();
        public BackgroundWorker MyWorker3 { get; set; } = new BackgroundWorker();
        public BackgroundWorker MyWorker4 { get; set; } = new BackgroundWorker();

        //Property path del file selezionato da inviare
        public string SelectedFilePath { get; set; }

        //Property per settare il path del file nella titlebar
        public string PathTitleBar
        {
            get { return Text; }
            set { Text = value; Refresh(); }
        }

        //property per richiamare la notify icon da altri form
        public NotifyIcon DefaultNotifyIcon
        {
            get { return notifyIcon; }
        }

        //Property della lista degli utenti (grafica)
        public ListView UsersListView
        {
            get { return usersListView; }
            set { usersListView = value; }
        }

        //Property della lista degli utenti online (concurrent dictionary)
        public UsersDB UsersDB { get; set; }
        public object Obj { get; set; } = new object();

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set the mainform hide (it hides both from the taskbar icon and the ctrl-alt-tab)
            Hide();

            try
            {
                //avvio il worker1 (AnnounceUDP)
                if (!MyWorker1.IsBusy)
                {
                    MyWorker1.RunWorkerAsync();
                }
                //avvio il worker2 (ListenerUDP)
                if (!MyWorker2.IsBusy)
                {
                    MyWorker2.RunWorkerAsync();
                }
                //avvio il worker3 (CheckOnlineUsers)
                if (!MyWorker3.IsBusy)
                {
                    MyWorker3.RunWorkerAsync();
                }

                //avvio il worker4 (ListenerTCP)
                if (!MyWorker4.IsBusy)
                {
                    MyWorker4.RunWorkerAsync();
                }

            }
            catch (Exception)
            {

                Invoke((MethodInvoker)delegate
                {
                    MaterialMessageBox.Show("Errore threads. L'applicazione verrà chiusa");
                    Application.Exit();
                });
            }

        }

        //evento per gestire la riduzione a icona nella system tray
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {


                //la notifica di avvio in background è mostrata solo all'avvio
                if (firstTime)
                {
                    notifyIcon.BalloonTipTitle = "ShareOnLan";
                    notifyIcon.BalloonTipText = "è in esecuzione in background";
                    notifyIcon.BalloonTipIcon = ToolTipIcon.None;
                    notifyIcon.ShowBalloonTip(1000);
                    firstTime = false;
                }

                //Set the mainform hide (it hides both from the taskbar icon and the ctrl-alt-tab)
                Hide();
            }
            else if (WindowState == FormWindowState.Normal)
            {
                ShowInTaskbar = true;
            }
        }

        //il click sulla x riduce l'applicazione a icona nella system tray
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }

        /* END MAIN FORM EVENTS */

        //worker1
        //metodo che annuncia l'host a tutti gli altri appartenenti al gruppo multicast
        protected void AnnounceUDP(object sender, DoWorkEventArgs e)
        {
            if (Thread.CurrentThread.Name == null)
                Thread.CurrentThread.Name = "AnnounceUDP Thread";
            //ho spostato il setup dell'udp dentro il while, così posso chiamare la close ad ogni giro e rilasciare
            // le risorse
            try
            {
                //NON SO SE è UNA BUONA IDEA, MA PENSO DI SI
                UdpTxMulticast udp = new UdpTxMulticast();
                udp.SetUdpConfiguration();
                //finchè online=true
                while (Properties.Settings.Default.IsOnline && !MyWorker1.CancellationPending)
                {
                    try
                    {
                        if (udp.CheckNIC())
                        {
                            udp.SendMulticastPacket();
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Thread.Sleep(5000);
                    }
                }
            }
            catch (Exception)
            {
                Invoke((MethodInvoker)delegate
                {
                    MaterialMessageBox.Show("Errore! L'applicazione verrà chiusa");
                    Application.Exit();
                });
            }
        }


        //worker 2
        //metodo che sta in ascolto su una porta e memorizza utenti in una lista
        //ne aggiorna il timestamp
        //visualizza sul form il nuovo utente connesso
        protected void ListenerUDP(object sender, DoWorkEventArgs e)
        {
            if (Thread.CurrentThread.Name == null)
                Thread.CurrentThread.Name = "ListenerUDP Thread";
            UdpRxMulticast udp = new UdpRxMulticast();

            try
            {
                udp.SetUdpConfiguration();
                while (!MyWorker2.CancellationPending)
                {
                    try
                    {
                        if (NetworkInterface.GetIsNetworkAvailable())
                        {
                            //sto in ascolto sulla 1700 e ritorno oggetto UserInfo
                            UserInfo userInfo = udp.ListenOnMulticastPort();

                            //se il pacchetto contiene il mio IP non devo aggiungerlo alla lista
                            //quindi se il pacchetto non contiene il mio IP
                            if (!userInfo.LocalEp.Address.ToString().Equals(Properties.Settings.Default.MyIpAddress))
                            {
                                //aggiungo o aggiorno database utenti
                                //memorizzo su una lista concorrente il nuovo utente (se non c'è già)
                                //oppure ne aggiorno il timestamp (se c'è già)
                                UsersDB.StoreUsersToDB(userInfo);

                                //aggiungo l'utente alla lista (UI)
                                Invoke((MethodInvoker)delegate
                                {

                                    Monitor.Enter(Obj);
                                    if (!usersListView.Items.ContainsKey(userInfo.LocalEp.Address.ToString()) && !userInfo.Username.Equals(String.Empty))
                                    {
                                        ListViewItem item = new ListViewItem
                                        {
                                            //come chiave dell'item uso l'indirizzo IP remoto dell'utente 
                                            Name = userInfo.LocalEp.Address.ToString(),
                                            Text = userInfo.Username
                                        };
                                        spinnerBox.Visible = false;
                                        usersPictures.Images.Add(userInfo.LocalEp.Address.ToString(), Properties.Resources.defaultProfileImage);
                                        var listViewItem = usersListView.Items.Add(item);
                                        listViewItem.ImageKey = userInfo.LocalEp.Address.ToString();

                                    }
                                    Monitor.Exit(Obj);
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (Exception)
            {
                Invoke((MethodInvoker)delegate
                {
                    MaterialMessageBox.Show("Errore! L'applicazione verrà chiusa");
                    Application.Exit();
                });
            }
        }


        //worker3
        //blocco la lista, controllo utenti memorizzati in lista
        //se diff timestamp >20s li elimino da lista
        //li rimuovo dalla lista (UI)
        protected void CheckOnlineUsers(object sender, DoWorkEventArgs e)
        {
            if (Thread.CurrentThread.Name == null)
                Thread.CurrentThread.Name = "CheckOnlineUsers Thread";
            try
            {
                while (true)
                {
                    try
                    {
                        if (NetworkInterface.GetIsNetworkAvailable())
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                noConnectionBox.Visible = false;
                                usersListView.Visible = true;
                            });
                            //se la lista ha almeno un elemento
                            if (UsersDB.UsersList.Count > 0)
                            {
                                DateTime now = DateTime.Now;
                                foreach (var pair in UsersDB.UsersList)
                                {
                                    var diffInSeconds = (now - (pair.Value.Timestamp)).TotalSeconds;
                                    if (diffInSeconds > 15)
                                    {
                                        //if (Visible)
                                        //{
                                        //rimuovo dal form l'utente
                                        Invoke((MethodInvoker)delegate
                                        {

                                            Monitor.Enter(Obj);
                                            usersListView.Items.RemoveByKey(pair.Key);
                                            Monitor.Exit(Obj);
                                        });
                                        //}
                                        UsersDB.UsersList.TryRemove(pair.Key, out UserInfo removed_userInfo);
                                        if (UsersDB.UsersList.Count == 0)
                                        {
                                            break;
                                        }
                                    }
                                }
                                if (UsersDB.UsersList.Count == 0)
                                {
                                    Invoke((MethodInvoker)delegate
                                    {
                                        spinnerBox.Visible = true;
                                    });
                                }

                            }
                            else //non ci sono utenti online quindi compare lo spinner
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    spinnerBox.Visible = true;
                                });
                            }
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                spinnerBox.Visible = false;
                                usersListView.Visible = false;
                                noConnectionBox.Visible = true;
                            });
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (Exception)
            {
                Invoke((MethodInvoker)delegate
                {
                    MaterialMessageBox.Show("Errore! L'applicazione verrà chiusa");
                    Application.Exit();
                });
            }

        }

        //ListenerTCP Thread
        //metodo che sta in ascolto sulla porta TCP per la ricezione di File
        protected void ListenerTCP(object sender, DoWorkEventArgs e)
        {
            if (Thread.CurrentThread.Name == null)
                Thread.CurrentThread.Name = "ListenerTCP Thread";
            //avvio listener tcp, gli passo config app e riferimento al form
            //all'interno di TcoTxFile il listener passa socket a pool di thread
            try
            {
                TcpRxFile tcp = new TcpRxFile(this);
                tcp.StartTcpListener();
            }
            catch (Exception)
            {
                Invoke((MethodInvoker)delegate
                {
                    MaterialMessageBox.Show("Errore! L'applicazione verrà chiusa");
                    Application.Exit();
                });
            }
        }

        //metodo grazie al quale cambio il titolo del mainForm
        //passandogli il nome del file da condividere
        public void ChangeTitleBar(string selectedFilePath)
        {
            if (selectedFilePath != null || !selectedFilePath.Equals(String.Empty))
            {
                string fileName = Path.GetFileName(selectedFilePath);
                PathTitleBar = String.Format("Condividi \"{0}\" con", fileName);
            }

        }

        /* EVENTI ELEMENTI UI */
        private void SettingButton_Click(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm(this);
            settingsForm.Show();
            Enabled = false;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ShareButton_Click(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count > 0)
            {

                /*creo lista utenti invio file*/
                foreach (ListViewItem item in usersListView.Items)
                {
                    if (item.Selected)
                    {
                        try
                        {
                            //creo oggetto utente a cui inviare (mi manca da prendere username)
                            UserInfo userInfo = new UserInfo(item.Text, item.Name, DateTime.Now);
                            TcpTxFile tcp = new TcpTxFile(userInfo, this);
                            tcp.SendInitialization();

                            //Set the mainform hide(it hides both from the taskbar icon and the ctrl-alt - tab)
                            Hide();
                        }
                        catch (Exception)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                MaterialMessageBox.Show("Errore invio file! Riprova.");
                            });
                        }
                    }
                }

            }

        }

        private void EsciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImpostazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm(this);
            settingsForm.Show();
            if (Visible)
            {
                Enabled = false;
            }
        }

        private void ModalitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsOnline == false)
            {
                //avvio il worker1 (AnnounceUDP)
                if (!MyWorker1.IsBusy)
                    MyWorker1.RunWorkerAsync();
                //setto la modalità pubblica
                Properties.Settings.Default.IsOnline = true;
                Properties.Settings.Default.Save();
                notifyIcon.Text = String.Format("ShareOnLan{0}Modalità Pubblica", Environment.NewLine);
                if (settingsForm != null && settingsForm.Visible)
                {
                    settingsForm.OnlineRadioButton.Checked = true;
                }
            }
            else
            {
                //setto la modalità pubblica
                Properties.Settings.Default.IsOnline = false;
                Properties.Settings.Default.Save();
                notifyIcon.Text = String.Format("ShareOnLan{0}Modalità Privata", Environment.NewLine);
                if (settingsForm != null && settingsForm.Visible)
                {
                    settingsForm.PrivateRadioButton.Checked = true;
                }
            }
        }

        private void ContextMenuSystemTray_Opening(object sender, CancelEventArgs e)
        {
            modalitàToolStripMenuItem.Text = Properties.Settings.Default.IsOnline ? "Passa alla modalità privata" : "Passa alla modalità pubblica";
        }

        private void UsersListView_ItemActivate(object sender, EventArgs e)
        {
            shareButton.Enabled = true;
        }
    }
}
