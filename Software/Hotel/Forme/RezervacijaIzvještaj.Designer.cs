namespace Hotel.Forme
{
    partial class RezervacijaIzvještaj
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvRezervacija = new Microsoft.Reporting.WinForms.ReportViewer();
            this.brojRezervacijaDanasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brojRezervacijaMjesecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brojRezervacijaGodinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.brojRezervacijaDanasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojRezervacijaMjesecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojRezervacijaGodinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvRezervacija
            // 
            this.rvRezervacija.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDani";
            reportDataSource1.Value = this.brojRezervacijaDanasBindingSource;
            reportDataSource2.Name = "DataSetMjesec";
            reportDataSource2.Value = this.brojRezervacijaMjesecBindingSource;
            reportDataSource3.Name = "DataSetGodina";
            reportDataSource3.Value = this.brojRezervacijaGodinaBindingSource;
            this.rvRezervacija.LocalReport.DataSources.Add(reportDataSource1);
            this.rvRezervacija.LocalReport.DataSources.Add(reportDataSource2);
            this.rvRezervacija.LocalReport.DataSources.Add(reportDataSource3);
            this.rvRezervacija.LocalReport.ReportEmbeddedResource = "Hotel.Forme.ReportStatRez.rdlc";
            this.rvRezervacija.Location = new System.Drawing.Point(0, 0);
            this.rvRezervacija.Name = "rvRezervacija";
            this.rvRezervacija.ServerReport.BearerToken = null;
            this.rvRezervacija.Size = new System.Drawing.Size(800, 450);
            this.rvRezervacija.TabIndex = 0;
            // 
            // RezervacijaIzvještaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvRezervacija);
            this.Name = "RezervacijaIzvještaj";
            this.Text = "RezervacijaIzvještaj";
            this.Load += new System.EventHandler(this.RezervacijaIzvještaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brojRezervacijaDanasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojRezervacijaMjesecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojRezervacijaGodinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvRezervacija;
        private System.Windows.Forms.BindingSource brojRezervacijaDanasBindingSource;
        private System.Windows.Forms.BindingSource brojRezervacijaMjesecBindingSource;
        private System.Windows.Forms.BindingSource brojRezervacijaGodinaBindingSource;
    }
}