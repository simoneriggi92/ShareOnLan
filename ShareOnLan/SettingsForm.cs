using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShareOnLan
{
    public partial class SettingsForm : MaterialFormTemplate
    {
        private MainForm mainForm;

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();

            //istanzio mainForm per salvare il path default 
            this.mainForm = mainForm;

            //setto l'username
            userNameTextBox.Text = Properties.Settings.Default.PublicUsername;

            //setto il percorso in cui salvare i file
            defaultPathLabel.Text = Properties.Settings.Default.DownloadPath;

            //sposto il bottone SFOGLIA in base alla dimensione della label
            browsePathButton.Location = new Point(defaultPathLabel.Location.X + 0, defaultPathLabel.Bottom + 10);

            //accept tutti i file
            if (Properties.Settings.Default.AcceptAlways)
                acceptCheckBox.Checked = true;

            //se modalità online
            if (Properties.Settings.Default.IsOnline)
            {
                onlineRadioButton.Checked = true;
                privateRadioButton.Checked = false;
            }
            else
            {
                onlineRadioButton.Checked = false;
                privateRadioButton.Checked = true;
            }

            tcpPortTextBox.Text = Properties.Settings.Default.PortTCP.ToString();
            udpPortTextBox.Text = Properties.Settings.Default.PortUDP.ToString();

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
                    defaultPathLabel.Text = Properties.Settings.Default.DownloadPath;

                    //sposto il bottone SFOGLIA in base alla dimensione della label
                    browsePathButton.Location = new Point(defaultPathLabel.Location.X + 0, defaultPathLabel.Bottom + 10);
                });
            }
        }

        public MaterialRadioButton OnlineRadioButton
        {
            get
            {
                return onlineRadioButton;
            }
        }

        public MaterialRadioButton PrivateRadioButton
        {
            get
            {
                return privateRadioButton;
            }
        }

        private void BrowsePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                //salvo il path nella property SaveFilePath
                Properties.Settings.Default.DownloadPath = browser.SelectedPath;
                Properties.Settings.Default.Save();
                defaultPathLabel.Text = Properties.Settings.Default.DownloadPath;
                browsePathButton.Location = new Point(defaultPathLabel.Location.X + 0, defaultPathLabel.Bottom + 10);

            }
        }

        private void AcceptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (acceptCheckBox.Checked)
            {
                Properties.Settings.Default.AcceptAlways = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.AcceptAlways = false;
                Properties.Settings.Default.Save();
            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void CloseSettingButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnlineRadioButton_Click(object sender, EventArgs e)
        {
            if (!mainForm.MyWorker1.IsBusy)
                mainForm.MyWorker1.RunWorkerAsync();

            if (onlineRadioButton.Checked)
            {
                Properties.Settings.Default.IsOnline = true;
                Properties.Settings.Default.Save();
                if (mainForm.DefaultNotifyIcon.Visible == true)
                    mainForm.DefaultNotifyIcon.Text = String.Format("ShareOnLan{0}Modalità Pubblica", Environment.NewLine);
            }
        }

        private void PrivateRadioButton_Click(object sender, EventArgs e)
        {
            if (privateRadioButton.Checked)
            {
                Properties.Settings.Default.IsOnline = false;
                Properties.Settings.Default.Save();

                if (mainForm.DefaultNotifyIcon.Visible == true)
                    mainForm.DefaultNotifyIcon.Text = String.Format("ShareOnLan{0}Modalità Privata", Environment.NewLine);
            }
        }

        private void UserNameTextBox_Leave(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.PublicUsername.Equals(userNameTextBox.Text))
            {
                Properties.Settings.Default.PublicUsername = userNameTextBox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void UserNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Properties.Settings.Default.PublicUsername.Equals(userNameTextBox.Text))
                {
                    Properties.Settings.Default.PublicUsername = userNameTextBox.Text;
                    Properties.Settings.Default.Save();
                }
                SendKeys.Send("{TAB}");

            }
        }

        private void ProfileTabPage_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.PublicUsername.Equals(userNameTextBox.Text))
            {
                Properties.Settings.Default.PublicUsername = userNameTextBox.Text;
                Properties.Settings.Default.Save();
            }
            SendKeys.Send("{TAB}");
        }

    }
}
