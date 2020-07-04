namespace Hotel.Forme
{
    partial class DodavanjeRezervacijeForm
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
            this.btnIzvrsi = new System.Windows.Forms.Button();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.cbVrstaRez = new System.Windows.Forms.ComboBox();
            this.tbDatumPoc = new System.Windows.Forms.TextBox();
            this.tbDatumZav = new System.Windows.Forms.TextBox();
            this.tbCijenaRez = new System.Windows.Forms.TextBox();
            this.tbImeGosta = new System.Windows.Forms.TextBox();
            this.tbPrezimeGosta = new System.Windows.Forms.TextBox();
            this.cbBrojSobe = new System.Windows.Forms.ComboBox();
            this.tbCijenaSobe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datumPocetka = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzvrsi
            // 
            this.btnIzvrsi.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIzvrsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvrsi.ForeColor = System.Drawing.Color.White;
            this.btnIzvrsi.Location = new System.Drawing.Point(308, 387);
            this.btnIzvrsi.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzvrsi.Name = "btnIzvrsi";
            this.btnIzvrsi.Size = new System.Drawing.Size(125, 50);
            this.btnIzvrsi.TabIndex = 0;
            this.btnIzvrsi.Text = "Spremi";
            this.btnIzvrsi.UseVisualStyleBackColor = false;
            this.btnIzvrsi.Click += new System.EventHandler(this.btnIzvrsi_Click);
            // 
            // cbUsluga
            // 
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(479, 284);
            this.cbUsluga.Margin = new System.Windows.Forms.Padding(2);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(156, 21);
            this.cbUsluga.TabIndex = 2;
            // 
            // cbVrstaRez
            // 
            this.cbVrstaRez.FormattingEnabled = true;
            this.cbVrstaRez.Location = new System.Drawing.Point(479, 186);
            this.cbVrstaRez.Margin = new System.Windows.Forms.Padding(2);
            this.cbVrstaRez.Name = "cbVrstaRez";
            this.cbVrstaRez.Size = new System.Drawing.Size(156, 21);
            this.cbVrstaRez.TabIndex = 4;
            // 
            // tbDatumPoc
            // 
            this.tbDatumPoc.Location = new System.Drawing.Point(69, 98);
            this.tbDatumPoc.Margin = new System.Windows.Forms.Padding(2);
            this.tbDatumPoc.Name = "tbDatumPoc";
            this.tbDatumPoc.Size = new System.Drawing.Size(150, 20);
            this.tbDatumPoc.TabIndex = 15;
            this.tbDatumPoc.CursorChanged += new System.EventHandler(this.tbDatumPoc_TextChanged);
            // 
            // tbDatumZav
            // 
            this.tbDatumZav.Location = new System.Drawing.Point(270, 98);
            this.tbDatumZav.Margin = new System.Windows.Forms.Padding(2);
            this.tbDatumZav.Name = "tbDatumZav";
            this.tbDatumZav.Size = new System.Drawing.Size(162, 20);
            this.tbDatumZav.TabIndex = 16;
            this.tbDatumZav.CursorChanged += new System.EventHandler(this.tbDatumZav_TextChanged);
            // 
            // tbCijenaRez
            // 
            this.tbCijenaRez.Location = new System.Drawing.Point(479, 98);
            this.tbCijenaRez.Margin = new System.Windows.Forms.Padding(2);
            this.tbCijenaRez.Name = "tbCijenaRez";
            this.tbCijenaRez.Size = new System.Drawing.Size(156, 20);
            this.tbCijenaRez.TabIndex = 17;
            // 
            // tbImeGosta
            // 
            this.tbImeGosta.Location = new System.Drawing.Point(69, 186);
            this.tbImeGosta.Margin = new System.Windows.Forms.Padding(2);
            this.tbImeGosta.Name = "tbImeGosta";
            this.tbImeGosta.Size = new System.Drawing.Size(150, 20);
            this.tbImeGosta.TabIndex = 18;
            // 
            // tbPrezimeGosta
            // 
            this.tbPrezimeGosta.Location = new System.Drawing.Point(270, 186);
            this.tbPrezimeGosta.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrezimeGosta.Name = "tbPrezimeGosta";
            this.tbPrezimeGosta.Size = new System.Drawing.Size(162, 20);
            this.tbPrezimeGosta.TabIndex = 19;
            // 
            // cbBrojSobe
            // 
            this.cbBrojSobe.FormattingEnabled = true;
            this.cbBrojSobe.Location = new System.Drawing.Point(69, 285);
            this.cbBrojSobe.Margin = new System.Windows.Forms.Padding(2);
            this.cbBrojSobe.Name = "cbBrojSobe";
            this.cbBrojSobe.Size = new System.Drawing.Size(150, 21);
            this.cbBrojSobe.TabIndex = 20;
            this.cbBrojSobe.SelectedIndexChanged += new System.EventHandler(this.cbBrojSobe_SelectedIndexChanged);
            // 
            // tbCijenaSobe
            // 
            this.tbCijenaSobe.Location = new System.Drawing.Point(270, 285);
            this.tbCijenaSobe.Margin = new System.Windows.Forms.Padding(2);
            this.tbCijenaSobe.Name = "tbCijenaSobe";
            this.tbCijenaSobe.Size = new System.Drawing.Size(162, 20);
            this.tbCijenaSobe.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datumPocetka);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(38, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 311);
            this.panel1.TabIndex = 25;
            // 
            // datumPocetka
            // 
            this.datumPocetka.AutoSize = true;
            this.datumPocetka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumPocetka.ForeColor = System.Drawing.Color.OliveDrab;
            this.datumPocetka.Location = new System.Drawing.Point(28, 24);
            this.datumPocetka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datumPocetka.Name = "datumPocetka";
            this.datumPocetka.Size = new System.Drawing.Size(103, 15);
            this.datumPocetka.TabIndex = 40;
            this.datumPocetka.Text = "Datum početka";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.OliveDrab;
            this.label16.Location = new System.Drawing.Point(438, 210);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 48;
            this.label16.Text = "Usluga";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.OliveDrab;
            this.label11.Location = new System.Drawing.Point(28, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 43;
            this.label11.Text = "Ime gosta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.OliveDrab;
            this.label9.Location = new System.Drawing.Point(229, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Datum završetka";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.OliveDrab;
            this.label15.Location = new System.Drawing.Point(229, 210);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 15);
            this.label15.TabIndex = 47;
            this.label15.Text = "Cijena sobe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.OliveDrab;
            this.label10.Location = new System.Drawing.Point(438, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Cijena rezervacije";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.OliveDrab;
            this.label12.Location = new System.Drawing.Point(229, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Prezime gosta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.OliveDrab;
            this.label13.Location = new System.Drawing.Point(438, 112);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 15);
            this.label13.TabIndex = 45;
            this.label13.Text = "Vrsta rezervacije";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.OliveDrab;
            this.label14.Location = new System.Drawing.Point(30, 211);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 15);
            this.label14.TabIndex = 46;
            this.label14.Text = "Broj sobe";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(38, 387);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 26;
            // 
            // DodavanjeRezervacijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbCijenaSobe);
            this.Controls.Add(this.cbBrojSobe);
            this.Controls.Add(this.tbPrezimeGosta);
            this.Controls.Add(this.tbImeGosta);
            this.Controls.Add(this.tbCijenaRez);
            this.Controls.Add(this.tbDatumZav);
            this.Controls.Add(this.tbDatumPoc);
            this.Controls.Add(this.cbVrstaRez);
            this.Controls.Add(this.cbUsluga);
            this.Controls.Add(this.btnIzvrsi);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodavanjeRezervacijeForm";
            this.Text = "DodavanjeRezervacijeForm";
            this.Load += new System.EventHandler(this.DodavanjeRezervacijeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzvrsi;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.ComboBox cbVrstaRez;
        private System.Windows.Forms.TextBox tbDatumPoc;
        private System.Windows.Forms.TextBox tbDatumZav;
        private System.Windows.Forms.TextBox tbCijenaRez;
        private System.Windows.Forms.TextBox tbImeGosta;
        private System.Windows.Forms.TextBox tbPrezimeGosta;
        private System.Windows.Forms.ComboBox cbBrojSobe;
        private System.Windows.Forms.TextBox tbCijenaSobe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label datumPocetka;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblError;
    }
}