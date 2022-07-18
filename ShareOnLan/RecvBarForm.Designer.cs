namespace ShareOnLan
{
    partial class RecvBarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecvBarForm));
            this.openFileButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.openFolderButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.closeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.speedTextbox = new MaterialSkin.Controls.MaterialLabel();
            this.speedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fileNameTextbox = new MaterialSkin.Controls.MaterialLabel();
            this.receivedByteLabel = new MaterialSkin.Controls.MaterialLabel();
            this.receivedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.timeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.receivingInfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.undoButton = new System.Windows.Forms.PictureBox();
            this.fileNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.percentageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.undoMaterialButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.timeTextbox = new MaterialSkin.Controls.MaterialLabel();
            this.receivingProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.undoButton)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileButton.AutoSize = true;
            this.openFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFileButton.Depth = 0;
            this.openFileButton.Icon = null;
            this.openFileButton.Location = new System.Drawing.Point(254, 9);
            this.openFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Primary = true;
            this.openFileButton.Size = new System.Drawing.Size(81, 36);
            this.openFileButton.TabIndex = 35;
            this.openFileButton.Text = "Apri File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Visible = false;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // openFolderButton
            // 
            this.openFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openFolderButton.AutoSize = true;
            this.openFolderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFolderButton.Depth = 0;
            this.openFolderButton.Icon = null;
            this.openFolderButton.Location = new System.Drawing.Point(340, 9);
            this.openFolderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Primary = true;
            this.openFolderButton.Size = new System.Drawing.Size(121, 36);
            this.openFolderButton.TabIndex = 34;
            this.openFolderButton.Text = "Apri Cartella";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Visible = false;
            this.openFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.Icon = null;
            this.closeButton.Location = new System.Drawing.Point(396, 309);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = true;
            this.closeButton.Size = new System.Drawing.Size(65, 36);
            this.closeButton.TabIndex = 49;
            this.closeButton.Text = "Chiudi";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // speedTextbox
            // 
            this.speedTextbox.AutoSize = true;
            this.speedTextbox.Depth = 0;
            this.speedTextbox.Font = new System.Drawing.Font("Roboto", 11F);
            this.speedTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speedTextbox.Location = new System.Drawing.Point(84, 269);
            this.speedTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedTextbox.Name = "speedTextbox";
            this.speedTextbox.Size = new System.Drawing.Size(132, 19);
            this.speedTextbox.TabIndex = 46;
            this.speedTextbox.Text = "Calcolo in corso...";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Depth = 0;
            this.speedLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.speedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speedLabel.Location = new System.Drawing.Point(20, 269);
            this.speedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(65, 19);
            this.speedLabel.TabIndex = 45;
            this.speedLabel.Text = "Velocità";
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.AutoSize = true;
            this.fileNameTextbox.Depth = 0;
            this.fileNameTextbox.Font = new System.Drawing.Font("Roboto", 11F);
            this.fileNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileNameTextbox.Location = new System.Drawing.Point(71, 182);
            this.fileNameTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.Size = new System.Drawing.Size(0, 19);
            this.fileNameTextbox.TabIndex = 43;
            // 
            // receivedByteLabel
            // 
            this.receivedByteLabel.AutoSize = true;
            this.receivedByteLabel.Depth = 0;
            this.receivedByteLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.receivedByteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.receivedByteLabel.Location = new System.Drawing.Point(79, 240);
            this.receivedByteLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.receivedByteLabel.Name = "receivedByteLabel";
            this.receivedByteLabel.Size = new System.Drawing.Size(132, 19);
            this.receivedByteLabel.TabIndex = 42;
            this.receivedByteLabel.Text = "Calcolo in corso...";
            // 
            // receivedLabel
            // 
            this.receivedLabel.AutoSize = true;
            this.receivedLabel.Depth = 0;
            this.receivedLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.receivedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.receivedLabel.Location = new System.Drawing.Point(19, 240);
            this.receivedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.receivedLabel.Name = "receivedLabel";
            this.receivedLabel.Size = new System.Drawing.Size(66, 19);
            this.receivedLabel.TabIndex = 41;
            this.receivedLabel.Text = "Ricevuti:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Depth = 0;
            this.timeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLabel.Location = new System.Drawing.Point(19, 211);
            this.timeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(131, 19);
            this.timeLabel.TabIndex = 40;
            this.timeLabel.Text = "Tempo rimanente:";
            // 
            // receivingInfoLabel
            // 
            this.receivingInfoLabel.AutoSize = true;
            this.receivingInfoLabel.Depth = 0;
            this.receivingInfoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.receivingInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.receivingInfoLabel.Location = new System.Drawing.Point(19, 76);
            this.receivingInfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.receivingInfoLabel.Name = "receivingInfoLabel";
            this.receivingInfoLabel.Size = new System.Drawing.Size(0, 19);
            this.receivingInfoLabel.TabIndex = 39;
            // 
            // undoButton
            // 
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.Location = new System.Drawing.Point(433, 111);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(16, 16);
            this.undoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.undoButton.TabIndex = 38;
            this.undoButton.TabStop = false;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Depth = 0;
            this.fileNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileNameLabel.Location = new System.Drawing.Point(19, 182);
            this.fileNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(54, 19);
            this.fileNameLabel.TabIndex = 36;
            this.fileNameLabel.Text = "Nome:";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Depth = 0;
            this.percentageLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.percentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.percentageLabel.Location = new System.Drawing.Point(19, 107);
            this.percentageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(222, 19);
            this.percentageLabel.TabIndex = 35;
            this.percentageLabel.Text = "Completamento operazione: 0%";
            // 
            // undoMaterialButton
            // 
            this.undoMaterialButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.undoMaterialButton.AutoSize = true;
            this.undoMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.undoMaterialButton.Depth = 0;
            this.undoMaterialButton.Icon = null;
            this.undoMaterialButton.Location = new System.Drawing.Point(378, 309);
            this.undoMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.undoMaterialButton.Name = "undoMaterialButton";
            this.undoMaterialButton.Primary = true;
            this.undoMaterialButton.Size = new System.Drawing.Size(83, 36);
            this.undoMaterialButton.TabIndex = 47;
            this.undoMaterialButton.Text = "Annulla";
            this.undoMaterialButton.UseVisualStyleBackColor = true;
            this.undoMaterialButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bottomPanel.Controls.Add(this.openFileButton);
            this.bottomPanel.Controls.Add(this.openFolderButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 300);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(470, 54);
            this.bottomPanel.TabIndex = 48;
            // 
            // timeTextbox
            // 
            this.timeTextbox.AutoSize = true;
            this.timeTextbox.Depth = 0;
            this.timeTextbox.Font = new System.Drawing.Font("Roboto", 11F);
            this.timeTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeTextbox.Location = new System.Drawing.Point(147, 211);
            this.timeTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.timeTextbox.Name = "timeTextbox";
            this.timeTextbox.Size = new System.Drawing.Size(132, 19);
            this.timeTextbox.TabIndex = 50;
            this.timeTextbox.Text = "Calcolo in corso...";
            // 
            // receivingProgressBar
            // 
            this.receivingProgressBar.Depth = 0;
            this.receivingProgressBar.Location = new System.Drawing.Point(24, 153);
            this.receivingProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.receivingProgressBar.Name = "receivingProgressBar";
            this.receivingProgressBar.Size = new System.Drawing.Size(425, 5);
            this.receivingProgressBar.TabIndex = 37;
            // 
            // RecvBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 354);
            this.Controls.Add(this.timeTextbox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.speedTextbox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.fileNameTextbox);
            this.Controls.Add(this.receivedByteLabel);
            this.Controls.Add(this.receivedLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.receivingInfoLabel);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.receivingProgressBar);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.undoMaterialButton);
            this.Controls.Add(this.bottomPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 354);
            this.MinimumSize = new System.Drawing.Size(470, 354);
            this.Name = "RecvBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Ricezione file...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecvBarForm_Closing);
            this.Resize += new System.EventHandler(this.RecvBarForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.undoButton)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton openFileButton;
        private MaterialSkin.Controls.MaterialRaisedButton openFolderButton;
        private MaterialSkin.Controls.MaterialRaisedButton closeButton;
        private MaterialSkin.Controls.MaterialLabel speedTextbox;
        private MaterialSkin.Controls.MaterialLabel speedLabel;
        private MaterialSkin.Controls.MaterialLabel fileNameTextbox;
        private MaterialSkin.Controls.MaterialLabel receivedByteLabel;
        private MaterialSkin.Controls.MaterialLabel receivedLabel;
        private MaterialSkin.Controls.MaterialLabel timeLabel;
        private MaterialSkin.Controls.MaterialLabel receivingInfoLabel;
        private System.Windows.Forms.PictureBox undoButton;
        private MaterialSkin.Controls.MaterialLabel fileNameLabel;
        private MaterialSkin.Controls.MaterialLabel percentageLabel;
        private MaterialSkin.Controls.MaterialRaisedButton undoMaterialButton;
        private System.Windows.Forms.Panel bottomPanel;
        private MaterialSkin.Controls.MaterialLabel timeTextbox;
        private MaterialSkin.Controls.MaterialProgressBar receivingProgressBar;
    }
}