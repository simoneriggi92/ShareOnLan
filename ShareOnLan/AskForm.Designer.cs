namespace ShareOnLan
{
    partial class AskForm
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
            this.senderInfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.bottomDivider = new System.Windows.Forms.Panel();
            this.topDivider = new System.Windows.Forms.Panel();
            this.acceptButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.undoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.savePathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.defaultPathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.browsePathButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.acceptCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.fileSizeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // senderInfoLabel
            // 
            this.senderInfoLabel.AutoEllipsis = true;
            this.senderInfoLabel.Depth = 0;
            this.senderInfoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.senderInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.senderInfoLabel.Location = new System.Drawing.Point(20, 84);
            this.senderInfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.senderInfoLabel.Name = "senderInfoLabel";
            this.senderInfoLabel.Size = new System.Drawing.Size(468, 19);
            this.senderInfoLabel.TabIndex = 30;
            this.senderInfoLabel.Text = "User ti sta inviando il file:";
            // 
            // bottomDivider
            // 
            this.bottomDivider.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bottomDivider.Location = new System.Drawing.Point(0, 245);
            this.bottomDivider.Name = "bottomDivider";
            this.bottomDivider.Size = new System.Drawing.Size(500, 1);
            this.bottomDivider.TabIndex = 29;
            // 
            // topDivider
            // 
            this.topDivider.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topDivider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.topDivider.Location = new System.Drawing.Point(0, 141);
            this.topDivider.Name = "topDivider";
            this.topDivider.Size = new System.Drawing.Size(500, 1);
            this.topDivider.TabIndex = 28;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.AutoSize = true;
            this.acceptButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.acceptButton.Depth = 0;
            this.acceptButton.Icon = null;
            this.acceptButton.Location = new System.Drawing.Point(409, 319);
            this.acceptButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Primary = true;
            this.acceptButton.Size = new System.Drawing.Size(82, 36);
            this.acceptButton.TabIndex = 26;
            this.acceptButton.Text = "Accetta";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.undoButton.AutoSize = true;
            this.undoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.undoButton.Depth = 0;
            this.undoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.undoButton.Icon = null;
            this.undoButton.Location = new System.Drawing.Point(318, 319);
            this.undoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.undoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.undoButton.Name = "undoButton";
            this.undoButton.Primary = false;
            this.undoButton.Size = new System.Drawing.Size(83, 36);
            this.undoButton.TabIndex = 25;
            this.undoButton.Text = "Annulla";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 310);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(500, 54);
            this.bottomPanel.TabIndex = 27;
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoEllipsis = true;
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Depth = 0;
            this.savePathLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.savePathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.savePathLabel.Location = new System.Drawing.Point(105, 189);
            this.savePathLabel.MaximumSize = new System.Drawing.Size(383, 0);
            this.savePathLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(186, 19);
            this.savePathLabel.TabIndex = 24;
            this.savePathLabel.Text = "C:\\Users\\javaj\\Downloads";
            // 
            // defaultPathLabel
            // 
            this.defaultPathLabel.AutoSize = true;
            this.defaultPathLabel.Depth = 0;
            this.defaultPathLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.defaultPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.defaultPathLabel.Location = new System.Drawing.Point(20, 155);
            this.defaultPathLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.defaultPathLabel.Name = "defaultPathLabel";
            this.defaultPathLabel.Size = new System.Drawing.Size(61, 19);
            this.defaultPathLabel.TabIndex = 23;
            this.defaultPathLabel.Text = "Salva in";
            // 
            // browsePathButton
            // 
            this.browsePathButton.AutoSize = true;
            this.browsePathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browsePathButton.Depth = 0;
            this.browsePathButton.Icon = null;
            this.browsePathButton.Location = new System.Drawing.Point(20, 180);
            this.browsePathButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.browsePathButton.Name = "browsePathButton";
            this.browsePathButton.Primary = true;
            this.browsePathButton.Size = new System.Drawing.Size(76, 36);
            this.browsePathButton.TabIndex = 22;
            this.browsePathButton.Text = "Sfoglia";
            this.browsePathButton.UseVisualStyleBackColor = true;
            this.browsePathButton.Click += new System.EventHandler(this.BrowsePathButton_Click);
            // 
            // acceptCheckBox
            // 
            this.acceptCheckBox.AutoSize = true;
            this.acceptCheckBox.Depth = 0;
            this.acceptCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.acceptCheckBox.Location = new System.Drawing.Point(20, 263);
            this.acceptCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.acceptCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.acceptCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.acceptCheckBox.Name = "acceptCheckBox";
            this.acceptCheckBox.Ripple = true;
            this.acceptCheckBox.Size = new System.Drawing.Size(247, 30);
            this.acceptCheckBox.TabIndex = 21;
            this.acceptCheckBox.Text = "Accetta automaticamente tutti i file";
            this.acceptCheckBox.UseVisualStyleBackColor = true;
            this.acceptCheckBox.CheckedChanged += new System.EventHandler(this.AcceptCheckBox_CheckedChanged);
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Depth = 0;
            this.fileSizeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fileSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileSizeLabel.Location = new System.Drawing.Point(20, 110);
            this.fileSizeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(93, 19);
            this.fileSizeLabel.TabIndex = 20;
            this.fileSizeLabel.Text = "Dimensione:";
            // 
            // AskForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.undoButton;
            this.ClientSize = new System.Drawing.Size(500, 364);
            this.Controls.Add(this.senderInfoLabel);
            this.Controls.Add(this.bottomDivider);
            this.Controls.Add(this.topDivider);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.savePathLabel);
            this.Controls.Add(this.defaultPathLabel);
            this.Controls.Add(this.browsePathButton);
            this.Controls.Add(this.acceptCheckBox);
            this.Controls.Add(this.fileSizeLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 364);
            this.MinimumSize = new System.Drawing.Size(500, 364);
            this.Name = "AskForm";
            this.Text = "Richiesta da ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel senderInfoLabel;
        private System.Windows.Forms.Panel bottomDivider;
        private System.Windows.Forms.Panel topDivider;
        private MaterialSkin.Controls.MaterialRaisedButton acceptButton;
        private MaterialSkin.Controls.MaterialFlatButton undoButton;
        private System.Windows.Forms.Panel bottomPanel;
        private MaterialSkin.Controls.MaterialLabel savePathLabel;
        private MaterialSkin.Controls.MaterialLabel defaultPathLabel;
        private MaterialSkin.Controls.MaterialRaisedButton browsePathButton;
        private MaterialSkin.Controls.MaterialCheckBox acceptCheckBox;
        private MaterialSkin.Controls.MaterialLabel fileSizeLabel;
    }
}