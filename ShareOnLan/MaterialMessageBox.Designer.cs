namespace ShareOnLan
{
    partial class MaterialMessageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.msgLabel = new MaterialSkin.Controls.MaterialLabel();
            this.errorIcon = new System.Windows.Forms.PictureBox();
            this.closeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 54);
            this.panel1.TabIndex = 6;
            // 
            // msgLabel
            // 
            this.msgLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.msgLabel.AutoEllipsis = true;
            this.msgLabel.Depth = 0;
            this.msgLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.msgLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msgLabel.Location = new System.Drawing.Point(66, 84);
            this.msgLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(324, 97);
            this.msgLabel.TabIndex = 7;
            this.msgLabel.Text = "Errore";
            this.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorIcon
            // 
            this.errorIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errorIcon.Image = global::ShareOnLan.Properties.Resources.errorIcon;
            this.errorIcon.Location = new System.Drawing.Point(10, 110);
            this.errorIcon.Name = "errorIcon";
            this.errorIcon.Size = new System.Drawing.Size(50, 50);
            this.errorIcon.TabIndex = 8;
            this.errorIcon.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.Icon = null;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeButton.Location = new System.Drawing.Point(325, 209);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = true;
            this.closeButton.Size = new System.Drawing.Size(65, 36);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "CHIUDI";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 136);
            this.panel2.TabIndex = 10;
            // 
            // MaterialMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 254);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.errorIcon);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.Name = "MaterialMessageBox";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel msgLabel;
        private System.Windows.Forms.PictureBox errorIcon;
        private MaterialSkin.Controls.MaterialRaisedButton closeButton;
        private System.Windows.Forms.Panel panel2;
    }
}