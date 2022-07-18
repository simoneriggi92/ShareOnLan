namespace ShareOnLan
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.settingTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.privateRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.onlineRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.userNameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.downloadTabPage = new System.Windows.Forms.TabPage();
            this.browsePathButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.acceptCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.downloadTopDivider = new MaterialSkin.Controls.MaterialDivider();
            this.defaultPathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.positionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.configTabPage = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.configBottomDivider = new MaterialSkin.Controls.MaterialDivider();
            this.versionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.configTopDivider = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tcpPortTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.udpPortTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.settingTabControl.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.downloadTabPage.SuspendLayout();
            this.configTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // settingTabSelector
            // 
            this.settingTabSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingTabSelector.BaseTabControl = this.settingTabControl;
            this.settingTabSelector.Depth = 0;
            this.settingTabSelector.Location = new System.Drawing.Point(0, 64);
            this.settingTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingTabSelector.Name = "settingTabSelector";
            this.settingTabSelector.Size = new System.Drawing.Size(330, 40);
            this.settingTabSelector.TabIndex = 16;
            // 
            // settingTabControl
            // 
            this.settingTabControl.Controls.Add(this.profileTabPage);
            this.settingTabControl.Controls.Add(this.downloadTabPage);
            this.settingTabControl.Controls.Add(this.configTabPage);
            this.settingTabControl.Depth = 0;
            this.settingTabControl.Location = new System.Drawing.Point(0, 110);
            this.settingTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingTabControl.Name = "settingTabControl";
            this.settingTabControl.SelectedIndex = 0;
            this.settingTabControl.Size = new System.Drawing.Size(330, 310);
            this.settingTabControl.TabIndex = 17;
            // 
            // profileTabPage
            // 
            this.profileTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profileTabPage.Controls.Add(this.pictureBox2);
            this.profileTabPage.Controls.Add(this.pictureBox1);
            this.profileTabPage.Controls.Add(this.userIcon);
            this.profileTabPage.Controls.Add(this.userPicture);
            this.profileTabPage.Controls.Add(this.privateRadioButton);
            this.profileTabPage.Controls.Add(this.onlineRadioButton);
            this.profileTabPage.Controls.Add(this.userNameTextBox);
            this.profileTabPage.Location = new System.Drawing.Point(4, 22);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(322, 284);
            this.profileTabPage.TabIndex = 0;
            this.profileTabPage.Text = "Profilo";
            this.profileTabPage.Click += new System.EventHandler(this.ProfileTabPage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShareOnLan.Properties.Resources.hide;
            this.pictureBox2.Location = new System.Drawing.Point(70, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShareOnLan.Properties.Resources.show;
            this.pictureBox1.Location = new System.Drawing.Point(70, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.Image = global::ShareOnLan.Properties.Resources.user;
            this.userIcon.Location = new System.Drawing.Point(70, 140);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(30, 30);
            this.userIcon.TabIndex = 17;
            this.userIcon.TabStop = false;
            // 
            // userPicture
            // 
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
            this.userPicture.Location = new System.Drawing.Point(115, 20);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(100, 100);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userPicture.TabIndex = 16;
            this.userPicture.TabStop = false;
            // 
            // privateRadioButton
            // 
            this.privateRadioButton.AutoSize = true;
            this.privateRadioButton.Depth = 0;
            this.privateRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.privateRadioButton.Location = new System.Drawing.Point(108, 231);
            this.privateRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.privateRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.privateRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.privateRadioButton.Name = "privateRadioButton";
            this.privateRadioButton.Ripple = true;
            this.privateRadioButton.Size = new System.Drawing.Size(130, 30);
            this.privateRadioButton.TabIndex = 14;
            this.privateRadioButton.Text = "Modalità Privata";
            this.privateRadioButton.UseVisualStyleBackColor = true;
            this.privateRadioButton.Click += new System.EventHandler(this.PrivateRadioButton_Click);
            // 
            // onlineRadioButton
            // 
            this.onlineRadioButton.AutoSize = true;
            this.onlineRadioButton.Checked = true;
            this.onlineRadioButton.Depth = 0;
            this.onlineRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.onlineRadioButton.Location = new System.Drawing.Point(108, 184);
            this.onlineRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.onlineRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.onlineRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.onlineRadioButton.Name = "onlineRadioButton";
            this.onlineRadioButton.Ripple = true;
            this.onlineRadioButton.Size = new System.Drawing.Size(140, 30);
            this.onlineRadioButton.TabIndex = 13;
            this.onlineRadioButton.TabStop = true;
            this.onlineRadioButton.Text = "Modalità Pubblica";
            this.onlineRadioButton.UseVisualStyleBackColor = true;
            this.onlineRadioButton.Click += new System.EventHandler(this.OnlineRadioButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Depth = 0;
            this.userNameTextBox.Hint = "";
            this.userNameTextBox.Location = new System.Drawing.Point(115, 144);
            this.userNameTextBox.MaximumSize = new System.Drawing.Size(200, 23);
            this.userNameTextBox.MaxLength = 20;
            this.userNameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.SelectionLength = 0;
            this.userNameTextBox.SelectionStart = 0;
            this.userNameTextBox.Size = new System.Drawing.Size(130, 23);
            this.userNameTextBox.TabIndex = 10;
            this.userNameTextBox.TabStop = false;
            this.userNameTextBox.Text = "username";
            this.userNameTextBox.UseSystemPasswordChar = false;
            this.userNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameTextBox_KeyDown);
            this.userNameTextBox.Leave += new System.EventHandler(this.UserNameTextBox_Leave);
            // 
            // downloadTabPage
            // 
            this.downloadTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.downloadTabPage.Controls.Add(this.browsePathButton);
            this.downloadTabPage.Controls.Add(this.acceptCheckBox);
            this.downloadTabPage.Controls.Add(this.downloadTopDivider);
            this.downloadTabPage.Controls.Add(this.defaultPathLabel);
            this.downloadTabPage.Controls.Add(this.positionLabel);
            this.downloadTabPage.Location = new System.Drawing.Point(4, 22);
            this.downloadTabPage.Name = "downloadTabPage";
            this.downloadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.downloadTabPage.Size = new System.Drawing.Size(322, 284);
            this.downloadTabPage.TabIndex = 1;
            this.downloadTabPage.Text = "Download";
            // 
            // browsePathButton
            // 
            this.browsePathButton.AutoSize = true;
            this.browsePathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browsePathButton.Depth = 0;
            this.browsePathButton.Icon = null;
            this.browsePathButton.Location = new System.Drawing.Point(20, 100);
            this.browsePathButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.browsePathButton.Name = "browsePathButton";
            this.browsePathButton.Primary = true;
            this.browsePathButton.Size = new System.Drawing.Size(76, 36);
            this.browsePathButton.TabIndex = 5;
            this.browsePathButton.Text = "Sfoglia";
            this.browsePathButton.UseVisualStyleBackColor = true;
            this.browsePathButton.Click += new System.EventHandler(this.BrowsePathButton_Click);
            // 
            // acceptCheckBox
            // 
            this.acceptCheckBox.AutoSize = true;
            this.acceptCheckBox.Depth = 0;
            this.acceptCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.acceptCheckBox.Location = new System.Drawing.Point(20, 170);
            this.acceptCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.acceptCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.acceptCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.acceptCheckBox.Name = "acceptCheckBox";
            this.acceptCheckBox.Ripple = true;
            this.acceptCheckBox.Size = new System.Drawing.Size(247, 30);
            this.acceptCheckBox.TabIndex = 4;
            this.acceptCheckBox.Text = "Accetta automaticamente tutti i file";
            this.acceptCheckBox.UseVisualStyleBackColor = true;
            this.acceptCheckBox.CheckedChanged += new System.EventHandler(this.AcceptCheckBox_CheckedChanged);
            // 
            // downloadTopDivider
            // 
            this.downloadTopDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.downloadTopDivider.Depth = 0;
            this.downloadTopDivider.Location = new System.Drawing.Point(0, 48);
            this.downloadTopDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadTopDivider.Name = "downloadTopDivider";
            this.downloadTopDivider.Size = new System.Drawing.Size(330, 1);
            this.downloadTopDivider.TabIndex = 8;
            this.downloadTopDivider.Text = "materialDivider1";
            // 
            // defaultPathLabel
            // 
            this.defaultPathLabel.AutoSize = true;
            this.defaultPathLabel.Depth = 0;
            this.defaultPathLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.defaultPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.defaultPathLabel.Location = new System.Drawing.Point(20, 70);
            this.defaultPathLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.defaultPathLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.defaultPathLabel.Name = "defaultPathLabel";
            this.defaultPathLabel.Size = new System.Drawing.Size(186, 19);
            this.defaultPathLabel.TabIndex = 7;
            this.defaultPathLabel.Text = "C:\\Users\\javaj\\Downloads";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Depth = 0;
            this.positionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.positionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.positionLabel.Location = new System.Drawing.Point(20, 25);
            this.positionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(171, 19);
            this.positionLabel.TabIndex = 6;
            this.positionLabel.Text = "Scegli dove salvare i file";
            // 
            // configTabPage
            // 
            this.configTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.configTabPage.Controls.Add(this.materialLabel4);
            this.configTabPage.Controls.Add(this.configBottomDivider);
            this.configTabPage.Controls.Add(this.versionLabel);
            this.configTabPage.Controls.Add(this.nameLabel);
            this.configTabPage.Controls.Add(this.pictureBox3);
            this.configTabPage.Controls.Add(this.configTopDivider);
            this.configTabPage.Controls.Add(this.materialLabel3);
            this.configTabPage.Controls.Add(this.materialLabel2);
            this.configTabPage.Controls.Add(this.materialLabel1);
            this.configTabPage.Controls.Add(this.tcpPortTextBox);
            this.configTabPage.Controls.Add(this.udpPortTextBox);
            this.configTabPage.Location = new System.Drawing.Point(4, 22);
            this.configTabPage.Name = "configTabPage";
            this.configTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.configTabPage.Size = new System.Drawing.Size(322, 284);
            this.configTabPage.TabIndex = 2;
            this.configTabPage.Text = "TCP/IP";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(126, 249);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(137, 19);
            this.materialLabel4.TabIndex = 33;
            this.materialLabel4.Text = "G.Giavatto - S.Riggi";
            // 
            // configBottomDivider
            // 
            this.configBottomDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.configBottomDivider.Depth = 0;
            this.configBottomDivider.Location = new System.Drawing.Point(-4, 174);
            this.configBottomDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.configBottomDivider.Name = "configBottomDivider";
            this.configBottomDivider.Size = new System.Drawing.Size(330, 1);
            this.configBottomDivider.TabIndex = 32;
            this.configBottomDivider.Text = "materialDivider1";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Depth = 0;
            this.versionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.versionLabel.Location = new System.Drawing.Point(126, 230);
            this.versionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(109, 19);
            this.versionLabel.TabIndex = 31;
            this.versionLabel.Text = "Versione: 1.0.0";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Depth = 0;
            this.nameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameLabel.Location = new System.Drawing.Point(126, 211);
            this.nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(89, 19);
            this.nameLabel.TabIndex = 30;
            this.nameLabel.Text = "ShareOnLan";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ShareOnLan.Properties.Resources.icon;
            this.pictureBox3.Location = new System.Drawing.Point(40, 197);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // configTopDivider
            // 
            this.configTopDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.configTopDivider.Depth = 0;
            this.configTopDivider.Location = new System.Drawing.Point(0, 48);
            this.configTopDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.configTopDivider.Name = "configTopDivider";
            this.configTopDivider.Size = new System.Drawing.Size(330, 1);
            this.configTopDivider.TabIndex = 28;
            this.configTopDivider.Text = "materialDivider1";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(20, 25);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(124, 22);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "Configurazione";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(96, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 20);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Porta TCP";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(96, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 20);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Porta UDP";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcpPortTextBox
            // 
            this.tcpPortTextBox.Depth = 0;
            this.tcpPortTextBox.Enabled = false;
            this.tcpPortTextBox.Hint = "";
            this.tcpPortTextBox.Location = new System.Drawing.Point(176, 124);
            this.tcpPortTextBox.MaxLength = 32767;
            this.tcpPortTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcpPortTextBox.Name = "tcpPortTextBox";
            this.tcpPortTextBox.PasswordChar = '\0';
            this.tcpPortTextBox.SelectedText = "";
            this.tcpPortTextBox.SelectionLength = 0;
            this.tcpPortTextBox.SelectionStart = 0;
            this.tcpPortTextBox.Size = new System.Drawing.Size(40, 23);
            this.tcpPortTextBox.TabIndex = 24;
            this.tcpPortTextBox.TabStop = false;
            this.tcpPortTextBox.UseSystemPasswordChar = false;
            // 
            // udpPortTextBox
            // 
            this.udpPortTextBox.Depth = 0;
            this.udpPortTextBox.Enabled = false;
            this.udpPortTextBox.Hint = "";
            this.udpPortTextBox.Location = new System.Drawing.Point(176, 76);
            this.udpPortTextBox.MaxLength = 32767;
            this.udpPortTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.udpPortTextBox.Name = "udpPortTextBox";
            this.udpPortTextBox.PasswordChar = '\0';
            this.udpPortTextBox.SelectedText = "";
            this.udpPortTextBox.SelectionLength = 0;
            this.udpPortTextBox.SelectionStart = 0;
            this.udpPortTextBox.Size = new System.Drawing.Size(40, 23);
            this.udpPortTextBox.TabIndex = 23;
            this.udpPortTextBox.TabStop = false;
            this.udpPortTextBox.UseSystemPasswordChar = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 420);
            this.Controls.Add(this.settingTabControl);
            this.Controls.Add(this.settingTabSelector);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 420);
            this.Name = "SettingsForm";
            this.Text = "Impostazioni";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.settingTabControl.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.profileTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.downloadTabPage.ResumeLayout(false);
            this.downloadTabPage.PerformLayout();
            this.configTabPage.ResumeLayout(false);
            this.configTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector settingTabSelector;
        private MaterialSkin.Controls.MaterialTabControl settingTabControl;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.TabPage downloadTabPage;
        private MaterialSkin.Controls.MaterialRaisedButton browsePathButton;
        private MaterialSkin.Controls.MaterialCheckBox acceptCheckBox;
        private MaterialSkin.Controls.MaterialDivider downloadTopDivider;
        private MaterialSkin.Controls.MaterialLabel defaultPathLabel;
        private MaterialSkin.Controls.MaterialLabel positionLabel;
        private System.Windows.Forms.TabPage configTabPage;
        private MaterialSkin.Controls.MaterialDivider configTopDivider;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tcpPortTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField udpPortTextBox;
        private MaterialSkin.Controls.MaterialRadioButton privateRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton onlineRadioButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField userNameTextBox;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel versionLabel;
        private MaterialSkin.Controls.MaterialLabel nameLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialDivider configBottomDivider;
    }
}