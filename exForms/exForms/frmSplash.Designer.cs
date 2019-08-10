namespace exForms
{
    partial class frmSplash
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbAbertura = new System.Windows.Forms.ProgressBar();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbAbertura
            // 
            this.pbAbertura.Location = new System.Drawing.Point(102, 199);
            this.pbAbertura.Name = "pbAbertura";
            this.pbAbertura.Size = new System.Drawing.Size(123, 17);
            this.pbAbertura.TabIndex = 2;
            this.pbAbertura.Click += new System.EventHandler(this.pbAbertura_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::exForms.Properties.Resources.LogoHoracio1;
            this.pbxLogo.Location = new System.Drawing.Point(102, 29);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(123, 106);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 374);
            this.Controls.Add(this.pbAbertura);
            this.Controls.Add(this.pbxLogo);
            this.Name = "frmSplash";
            this.Text = "frmSplash";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbAbertura;
    }
}