namespace ShareOnLan
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.shareButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.undoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.settingButton = new System.Windows.Forms.Button();
            this.usersListView = new System.Windows.Forms.ListView();
            this.usersPictures = new System.Windows.Forms.ImageList(this.components);
            this.spinnerBox = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuSystemTray = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.modalitàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impostazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noConnectionBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerBox)).BeginInit();
            this.contextMenuSystemTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noConnectionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shareButton
            // 
            this.shareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shareButton.AutoSize = true;
            this.shareButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shareButton.Depth = 0;
            this.shareButton.Enabled = false;
            this.shareButton.Icon = null;
            this.shareButton.Location = new System.Drawing.Point(618, 469);
            this.shareButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.shareButton.Name = "shareButton";
            this.shareButton.Primary = true;
            this.shareButton.Size = new System.Drawing.Size(88, 36);
            this.shareButton.TabIndex = 13;
            this.shareButton.Text = "Condividi";
            this.shareButton.UseVisualStyleBackColor = true;
            this.shareButton.Click += new System.EventHandler(this.ShareButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.undoButton.AutoSize = true;
            this.undoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.undoButton.Depth = 0;
            this.undoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.undoButton.Icon = null;
            this.undoButton.Location = new System.Drawing.Point(526, 469);
            this.undoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.undoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.undoButton.Name = "undoButton";
            this.undoButton.Primary = false;
            this.undoButton.Size = new System.Drawing.Size(83, 36);
            this.undoButton.TabIndex = 11;
            this.undoButton.Text = "Annulla";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 460);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(715, 54);
            this.bottomPanel.TabIndex = 12;
            // 
            // settingButton
            // 
            this.settingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.settingButton.FlatAppearance.BorderSize = 0;
            this.settingButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.settingButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Image = global::ShareOnLan.Properties.Resources.settingButton;
            this.settingButton.Location = new System.Drawing.Point(10, 472);
            this.settingButton.MaximumSize = new System.Drawing.Size(30, 30);
            this.settingButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(30, 30);
            this.settingButton.TabIndex = 0;
            this.settingButton.UseVisualStyleBackColor = false;
            this.settingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // usersListView
            // 
            this.usersListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.usersListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.usersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersListView.GridLines = true;
            this.usersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.usersListView.HideSelection = false;
            this.usersListView.LargeImageList = this.usersPictures;
            this.usersListView.Location = new System.Drawing.Point(0, 64);
            this.usersListView.Margin = new System.Windows.Forms.Padding(1000);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(715, 396);
            this.usersListView.TabIndex = 15;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.ItemActivate += new System.EventHandler(this.UsersListView_ItemActivate);
            // 
            // usersPictures
            // 
            this.usersPictures.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.usersPictures.ImageSize = new System.Drawing.Size(100, 100);
            this.usersPictures.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // spinnerBox
            // 
            this.spinnerBox.Image = global::ShareOnLan.Properties.Resources.spinner;
            this.spinnerBox.Location = new System.Drawing.Point(322, 227);
            this.spinnerBox.Name = "spinnerBox";
            this.spinnerBox.Size = new System.Drawing.Size(70, 70);
            this.spinnerBox.TabIndex = 16;
            this.spinnerBox.TabStop = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuSystemTray;
            this.notifyIcon.Text = "ShareOnLan";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuSystemTray
            // 
            this.contextMenuSystemTray.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contextMenuSystemTray.Depth = 0;
            this.contextMenuSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modalitàToolStripMenuItem,
            this.impostazioniToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.contextMenuSystemTray.MouseState = MaterialSkin.MouseState.HOVER;
            this.contextMenuSystemTray.Name = "contextMenuSystemTray";
            this.contextMenuSystemTray.Size = new System.Drawing.Size(143, 70);
            this.contextMenuSystemTray.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuSystemTray_Opening);
            // 
            // modalitàToolStripMenuItem
            // 
            this.modalitàToolStripMenuItem.Name = "modalitàToolStripMenuItem";
            this.modalitàToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.modalitàToolStripMenuItem.Text = "Modalità";
            this.modalitàToolStripMenuItem.Click += new System.EventHandler(this.ModalitaToolStripMenuItem_Click);
            // 
            // impostazioniToolStripMenuItem
            // 
            this.impostazioniToolStripMenuItem.Name = "impostazioniToolStripMenuItem";
            this.impostazioniToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.impostazioniToolStripMenuItem.Text = "Impostazioni";
            this.impostazioniToolStripMenuItem.Click += new System.EventHandler(this.ImpostazioniToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.EsciToolStripMenuItem_Click);
            // 
            // noConnectionBox
            // 
            this.noConnectionBox.Image = global::ShareOnLan.Properties.Resources.noConnection;
            this.noConnectionBox.Location = new System.Drawing.Point(322, 227);
            this.noConnectionBox.Name = "noConnectionBox";
            this.noConnectionBox.Size = new System.Drawing.Size(70, 70);
            this.noConnectionBox.TabIndex = 17;
            this.noConnectionBox.TabStop = false;
            this.noConnectionBox.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.shareButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.undoButton;
            this.ClientSize = new System.Drawing.Size(715, 514);
            this.Controls.Add(this.noConnectionBox);
            this.Controls.Add(this.spinnerBox);
            this.Controls.Add(this.usersListView);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.shareButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.bottomPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(715, 514);
            this.MinimumSize = new System.Drawing.Size(715, 514);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.spinnerBox)).EndInit();
            this.contextMenuSystemTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noConnectionBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton shareButton;
        private MaterialSkin.Controls.MaterialFlatButton undoButton;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.PictureBox spinnerBox;
        private System.Windows.Forms.ImageList usersPictures;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MaterialSkin.Controls.MaterialContextMenuStrip contextMenuSystemTray;
        private System.Windows.Forms.ToolStripMenuItem modalitàToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impostazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.PictureBox noConnectionBox;
    }
}

