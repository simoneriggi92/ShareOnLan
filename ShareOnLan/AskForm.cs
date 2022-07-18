using System;
using System.Threading;
using System.Windows.Forms;

namespace ShareOnLan
{
    public partial class AskForm : MaterialFormTemplate
    {
        private MainForm mainForm;
        private HeaderTcp header;
        //passo MainForm per settare la property SavePathFile
        //e la property UseDefault(per utilizzare sempre questo path)
        public AskForm(MainForm mainForm, HeaderTcp header)
        {

            InitializeComponent();
            this.mainForm = mainForm;
            this.header = header;

            string fileSizeByte = header.Filesize.ToString("N0");
            string fileSizeWithUnit = fileSizeWithUnit = Utilities.GetFileSizeWithUnit(header.Filesize);

            //titlebar
            Text = String.Format("Richiesta da: {0}", header.Username);
            //visualizzo nome file in arrivo e dimensione sull'askForm
            senderInfoLabel.Text = String.Format("{0} ti sta inviando il file: {1}", header.Username, header.Filename);
            fileSizeLabel.Text = String.Format("Dimensione: {0} ({1} byte)", fileSizeWithUnit, fileSizeByte);
            savePathLabel.Text = Properties.Settings.Default.DownloadPath;

            //mi registro all'evento così quando il downloadpath cambia lo aggiorna
            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;

        }

        private void Default_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("DownloadPath"))
            {
                mainForm.Invoke((MethodInvoker)delegate
                {
                    //setto il percorso in cui salvare i file
                    savePathLabel.Text = Properties.Settings.Default.DownloadPath;

                });
            }
        }

        //property per settare se l'utente ha accettato il file o no
        public bool FileAccepted { get; set; }

        private void BrowsePathButton_Click(object sender, EventArgs e)
        {
            try
            {
                Thread browse = new Thread(() => { OpenFileDialog(); })
                {
                    Name = "OpenFileDialogThread"
                };
                browse.SetApartmentState(ApartmentState.STA);
                browse.IsBackground = true;
                browse.Start();
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("Impossibile selezionare un file");
            }
        }

        private void OpenFileDialog()
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                //salvo il path nella property SaveFilePath
                Properties.Settings.Default.DownloadPath = browser.SelectedPath;
                Properties.Settings.Default.Save();
                mainForm.Invoke((MethodInvoker)delegate
                {
                    savePathLabel.Text = Properties.Settings.Default.DownloadPath;
                });


            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            //ho accettato il file
            FileAccepted = true;
            //chiudo il form
            Close();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            //rifiuto il file
            FileAccepted = false;
            //chiudo il form
            Close();
        }

        private void AcceptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AcceptAlways = true;
            Properties.Settings.Default.Save();
        }
    }
}
