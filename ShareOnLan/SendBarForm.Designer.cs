namespace ShareOnLan
{
    partial class SendBarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendBarForm));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.closeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.undoMaterialButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.speedTextbox = new MaterialSkin.Controls.MaterialLabel();
            this.speedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.timeTextbox = new MaterialSkin.Controls.MaterialLabel();
            this.fileNameTextbox = new MaterialSkin.Controls.MaterialLabel();
            this.sentByteLabel = new MaterialSkin.Controls.MaterialLabel();
            this.inviatiLabel = new MaterialSkin.Controls.MaterialLabel();
            this.timeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.sendingInfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.undoButton = new System.Windows.Forms.PictureBox();
            this.sendingProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.fileNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.percentageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.undoButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bottomPanel.Controls.Add(this.closeButton);
            this.bottomPanel.Controls.Add(this.undoMaterialButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 300);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(470, 54);
            this.bottomPanel.TabIndex = 48;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.Icon = null;
            this.closeButton.Location = new System.Drawing.Point(396, 9);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = true;
            this.closeButton.Size = new System.Drawing.Size(65, 36);
            this.closeButton.TabIndex = 34;
            this.closeButton.Text = "Chiudi";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // undoMaterialButton
            // 
            this.undoMaterialButton.AutoSize = true;
            this.undoMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.undoMaterialButton.Depth = 0;
            this.undoMaterialButton.Icon = null;
            this.undoMaterialButton.Location = new System.Drawing.Point(379, 9);
            this.undoMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.undoMaterialButton.Name = "undoMaterialButton";
            this.undoMaterialButton.Primary = true;
            this.undoMaterialButton.Size = new System.Drawing.Size(83, 36);
            this.undoMaterialButton.TabIndex = 38;
            this.undoMaterialButton.Text = "Annulla";
            this.undoMaterialButton.UseVisualStyleBackColor = true;
            this.undoMaterialButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // speedTextbox
            // 
            this.speedTextbox.AutoSize = true;
            this.speedTextbox.Depth = 0;
            this.speedTextbox.Font = new System.Drawing.Font("Roboto", 11F);
            this.speedTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speedTextbox.Location = new System.Drawing.Point(88, 267);
            this.speedTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedTextbox.Name = "speedTextbox";
            this.speedTextbox.Size = new System.Drawing.Size(132, 19);
            this.speedTextbox.TabIndex = 47;
            this.speedTextbox.Text = "Calcolo in corso...";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Depth = 0;
            this.speedLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.speedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speedLabel.Location = new System.Drawing.Point(21, 267);
            this.speedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(69, 19);
            this.speedLabel.TabIndex = 46;
            this.speedLabel.Text = "Velocità:";
            // 
            // timeTextbox
            // 
            this.timeTextbox.AutoSize = true;
            this.timeTextbox.Depth = 0;
            this.timeTextbox.Font = new System.Drawing.Font("Roboto", 11F);
            this.timeTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeTextbox.Location = new System.Drawing.Point(148, 209);
            this.timeTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.timeTextbox.Name = "timeTextbox";
            this.timeTextbox.Size = new System.Drawing.Size(132, 19);
            this.timeTextbox.TabIndex = 45;
            this.timeTextbox.Text = "Calcolo in corso...";
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.AutoSize = true;
            this.fileNameTextbox.Depth = 0;
            this.fileNameTextbox.Font = new System.Drawing.Font("Roboto", 11F);
            this.fileNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileNameTextbox.Location = new System.Drawing.Point(72, 180);
            this.fileNameTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.Size = new System.Drawing.Size(0, 19);
            this.fileNameTextbox.TabIndex = 44;
            // 
            // sentByteLabel
            // 
            this.sentByteLabel.AutoSize = true;
            this.sentByteLabel.Depth = 0;
            this.sentByteLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.sentByteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sentByteLabel.Location = new System.Drawing.Point(70, 238);
            this.sentByteLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.sentByteLabel.Name = "sentByteLabel";
            this.sentByteLabel.Size = new System.Drawing.Size(132, 19);
            this.sentByteLabel.TabIndex = 43;
            this.sentByteLabel.Text = "Calcolo in corso...";
            // 
            // inviatiLabel
            // 
            this.inviatiLabel.AutoSize = true;
            this.inviatiLabel.Depth = 0;
            this.inviatiLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.inviatiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inviatiLabel.Location = new System.Drawing.Point(20, 238);
            this.inviatiLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.inviatiLabel.Name = "inviatiLabel";
            this.inviatiLabel.Size = new System.Drawing.Size(53, 19);
            this.inviatiLabel.TabIndex = 42;
            this.inviatiLabel.Text = "Inviati:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Depth = 0;
            this.timeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLabel.Location = new System.Drawing.Point(20, 209);
            this.timeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(131, 19);
            this.timeLabel.TabIndex = 41;
            this.timeLabel.Text = "Tempo rimanente:";
            // 
            // sendingInfoLabel
            // 
            this.sendingInfoLabel.AutoSize = true;
            this.sendingInfoLabel.Depth = 0;
            this.sendingInfoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.sendingInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sendingInfoLabel.Location = new System.Drawing.Point(20, 74);
            this.sendingInfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendingInfoLabel.Name = "sendingInfoLabel";
            this.sendingInfoLabel.Size = new System.Drawing.Size(0, 19);
            this.sendingInfoLabel.TabIndex = 40;
            // 
            // undoButton
            // 
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.Location = new System.Drawing.Point(434, 109);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(16, 16);
            this.undoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.undoButton.TabIndex = 39;
            this.undoButton.TabStop = false;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // sendingProgressBar
            // 
            this.sendingProgressBar.Depth = 0;
            this.sendingProgressBar.Location = new System.Drawing.Point(25, 151);
            this.sendingProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendingProgressBar.Name = "sendingProgressBar";
            this.sendingProgressBar.Size = new System.Drawing.Size(425, 5);
            this.sendingProgressBar.TabIndex = 38;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Depth = 0;
            this.fileNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileNameLabel.Location = new System.Drawing.Point(20, 180);
            this.fileNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(54, 19);
            this.fileNameLabel.TabIndex = 37;
            this.fileNameLabel.Text = "Nome:";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Depth = 0;
            this.percentageLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.percentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.percentageLabel.Location = new System.Drawing.Point(20, 105);
            this.percentageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(222, 19);
            this.percentageLabel.TabIndex = 36;
            this.percentageLabel.Text = "Completamento operazione: 0%";
            // 
            // SendBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 354);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.speedTextbox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.timeTextbox);
            this.Controls.Add(this.fileNameTextbox);
            this.Controls.Add(this.sentByteLabel);
            this.Controls.Add(this.inviatiLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.sendingInfoLabel);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.sendingProgressBar);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.percentageLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 354);
            this.MinimumSize = new System.Drawing.Size(470, 354);
            this.Name = "SendBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Invio file...";
            this.Resize += new System.EventHandler(this.SendBarForm_Resize);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.undoButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private MaterialSkin.Controls.MaterialRaisedButton undoMaterialButton;
        private MaterialSkin.Controls.MaterialRaisedButton closeButton;
        private MaterialSkin.Controls.MaterialLabel speedTextbox;
        private MaterialSkin.Controls.MaterialLabel speedLabel;
        private MaterialSkin.Controls.MaterialLabel timeTextbox;
        private MaterialSkin.Controls.MaterialLabel fileNameTextbox;
        private MaterialSkin.Controls.MaterialLabel sentByteLabel;
        private MaterialSkin.Controls.MaterialLabel inviatiLabel;
        private MaterialSkin.Controls.MaterialLabel timeLabel;
        private MaterialSkin.Controls.MaterialLabel sendingInfoLabel;
        private System.Windows.Forms.PictureBox undoButton;
        private MaterialSkin.Controls.MaterialProgressBar sendingProgressBar;
        private MaterialSkin.Controls.MaterialLabel fileNameLabel;
        private MaterialSkin.Controls.MaterialLabel percentageLabel;
    }
}