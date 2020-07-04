namespace Hotel.Forme
{
    partial class RezervacijaIzvještaji
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvRezervacija = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvRezervacija
            // 
            this.rvRezervacija.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetRezervacija";
            reportDataSource3.Value = this.RezervacijaBindingSource;
            reportDataSource4.Name = "DataSetGost";
            reportDataSource4.Value = this.GostBindingSource;
            this.rvRezervacija.LocalReport.DataSources.Add(reportDataSource3);
            this.rvRezervacija.LocalReport.DataSources.Add(reportDataSource4);
            this.rvRezervacija.LocalReport.ReportEmbeddedResource = "Hotel.Forme.ReportRezervacija.rdlc";
            this.rvRezervacija.Location = new System.Drawing.Point(0, 0);
            this.rvRezervacija.Name = "rvRezervacija";
            this.rvRezervacija.ServerReport.BearerToken = null;
            this.rvRezervacija.Size = new System.Drawing.Size(800, 450);
            this.rvRezervacija.TabIndex = 0;
            // 
            // RezervacijaBindingSource
            // 
            this.RezervacijaBindingSource.DataMember = "Rezervacija";
            // 
            // GostBindingSource
            // 
            this.GostBindingSource.DataMember = "Gost";
            // 
            // RezervacijaIzvještaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvRezervacija);
            this.Name = "RezervacijaIzvještaji";
            this.Text = "Izvještaji rezervacija";
            this.Load += new System.EventHandler(this.RezervacijaIzvještaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GostBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvRezervacija;
        private System.Windows.Forms.BindingSource RezervacijaBindingSource;
        private System.Windows.Forms.BindingSource GostBindingSource;
    }
}