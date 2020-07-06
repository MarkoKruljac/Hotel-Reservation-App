namespace Hotel.Forme
{
    partial class RezervacijaIzjveštajG
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
            this.rvGraficki = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvGraficki
            // 
            this.rvGraficki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvGraficki.LocalReport.ReportEmbeddedResource = "Hotel.Forme.ReportGrafickiPrikaz.rdlc";
            this.rvGraficki.Location = new System.Drawing.Point(0, 0);
            this.rvGraficki.Name = "rvGraficki";
            this.rvGraficki.ServerReport.BearerToken = null;
            this.rvGraficki.Size = new System.Drawing.Size(800, 450);
            this.rvGraficki.TabIndex = 0;
            // 
            // RezervacijaIzjveštajG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvGraficki);
            this.Name = "RezervacijaIzjveštajG";
            this.Text = "Izvještaj grafički";
            this.Load += new System.EventHandler(this.RezervacijaIzjveštajG_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvGraficki;
    }
}