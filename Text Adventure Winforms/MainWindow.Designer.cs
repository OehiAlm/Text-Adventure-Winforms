namespace Text_Adventure_Winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.KindleButton = new System.Windows.Forms.Button();
            this.OutputStream = new System.Windows.Forms.TextBox();
            this.FireControlsLabel = new System.Windows.Forms.Label();
            this.ExtinguishButton = new System.Windows.Forms.Button();
            this.AdventureTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // KindleButton
            // 
            this.KindleButton.Location = new System.Drawing.Point(12, 29);
            this.KindleButton.Name = "KindleButton";
            this.KindleButton.Size = new System.Drawing.Size(75, 23);
            this.KindleButton.TabIndex = 0;
            this.KindleButton.Text = "Kindle";
            this.KindleButton.UseVisualStyleBackColor = true;
            this.KindleButton.Click += new System.EventHandler(this.KindleButton_Click);
            // 
            // OutputStream
            // 
            this.OutputStream.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputStream.Enabled = false;
            this.OutputStream.Location = new System.Drawing.Point(152, 14);
            this.OutputStream.Multiline = true;
            this.OutputStream.Name = "OutputStream";
            this.OutputStream.ReadOnly = true;
            this.OutputStream.Size = new System.Drawing.Size(280, 170);
            this.OutputStream.TabIndex = 1;
            this.OutputStream.Text = "The Room is dark.";
            // 
            // FireControlsLabel
            // 
            this.FireControlsLabel.AutoSize = true;
            this.FireControlsLabel.Location = new System.Drawing.Point(13, 13);
            this.FireControlsLabel.Name = "FireControlsLabel";
            this.FireControlsLabel.Size = new System.Drawing.Size(65, 13);
            this.FireControlsLabel.TabIndex = 3;
            this.FireControlsLabel.Text = "Fire Controls";
            // 
            // ExtinguishButton
            // 
            this.ExtinguishButton.Location = new System.Drawing.Point(12, 58);
            this.ExtinguishButton.Name = "ExtinguishButton";
            this.ExtinguishButton.Size = new System.Drawing.Size(75, 23);
            this.ExtinguishButton.TabIndex = 4;
            this.ExtinguishButton.Text = "Extinguish";
            this.ExtinguishButton.UseVisualStyleBackColor = true;
            this.ExtinguishButton.Click += new System.EventHandler(this.ExtinguishButton_Click);
            // 
            // AdventureTick
            // 
            this.AdventureTick.Interval = 2500;
            this.AdventureTick.Tick += new System.EventHandler(this.StandardTick_Tick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.ExtinguishButton);
            this.Controls.Add(this.FireControlsLabel);
            this.Controls.Add(this.OutputStream);
            this.Controls.Add(this.KindleButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uninitialized";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FireControlsLabel;
        private System.Windows.Forms.Button ExtinguishButton;
        public System.Windows.Forms.Button KindleButton;
        private System.Windows.Forms.TextBox OutputStream;
        private System.Windows.Forms.Timer AdventureTick;
    }
}

