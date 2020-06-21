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
            this.btnOdustaniDR = new System.Windows.Forms.Button();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.cbVrstaRez = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDatumPoc = new System.Windows.Forms.TextBox();
            this.tbDatumZav = new System.Windows.Forms.TextBox();
            this.tbCijenaRez = new System.Windows.Forms.TextBox();
            this.tbImeGosta = new System.Windows.Forms.TextBox();
            this.tbPrezimeGosta = new System.Windows.Forms.TextBox();
            this.cbBrojSobe = new System.Windows.Forms.ComboBox();
            this.asda = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.tbCijenaSobe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIzvrsi
            // 
            this.btnIzvrsi.Location = new System.Drawing.Point(1116, 305);
            this.btnIzvrsi.Name = "btnIzvrsi";
            this.btnIzvrsi.Size = new System.Drawing.Size(105, 39);
            this.btnIzvrsi.TabIndex = 0;
            this.btnIzvrsi.Text = "Izvrši";
            this.btnIzvrsi.UseVisualStyleBackColor = true;
            this.btnIzvrsi.Click += new System.EventHandler(this.btnIzvrsi_Click);
            // 
            // btnOdustaniDR
            // 
            this.btnOdustaniDR.Location = new System.Drawing.Point(1261, 305);
            this.btnOdustaniDR.Name = "btnOdustaniDR";
            this.btnOdustaniDR.Size = new System.Drawing.Size(110, 40);
            this.btnOdustaniDR.TabIndex = 1;
            this.btnOdustaniDR.Text = "Odustani";
            this.btnOdustaniDR.UseVisualStyleBackColor = true;
            this.btnOdustaniDR.Click += new System.EventHandler(this.btnOdustaniDR_Click);
            // 
            // cbUsluga
            // 
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(919, 132);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(121, 24);
            this.cbUsluga.TabIndex = 2;
            // 
            // cbVrstaRez
            // 
            this.cbVrstaRez.FormattingEnabled = true;
            this.cbVrstaRez.Location = new System.Drawing.Point(751, 132);
            this.cbVrstaRez.Name = "cbVrstaRez";
            this.cbVrstaRez.Size = new System.Drawing.Size(121, 24);
            this.cbVrstaRez.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Datum zavrsetka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cijena rezervacije";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezime gosta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ime gosta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datum pocetka";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vrsta rezervacije";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(916, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Usluga";
            // 
            // tbDatumPoc
            // 
            this.tbDatumPoc.Location = new System.Drawing.Point(25, 132);
            this.tbDatumPoc.Name = "tbDatumPoc";
            this.tbDatumPoc.Size = new System.Drawing.Size(124, 22);
            this.tbDatumPoc.TabIndex = 15;
            this.tbDatumPoc.CursorChanged += new System.EventHandler(this.tbDatumPoc_TextChanged);
            // 
            // tbDatumZav
            // 
            this.tbDatumZav.Location = new System.Drawing.Point(171, 132);
            this.tbDatumZav.Name = "tbDatumZav";
            this.tbDatumZav.Size = new System.Drawing.Size(124, 22);
            this.tbDatumZav.TabIndex = 16;
            this.tbDatumZav.CursorChanged += new System.EventHandler(this.tbDatumZav_TextChanged);
            // 
            // tbCijenaRez
            // 
            this.tbCijenaRez.Location = new System.Drawing.Point(315, 132);
            this.tbCijenaRez.Name = "tbCijenaRez";
            this.tbCijenaRez.Size = new System.Drawing.Size(124, 22);
            this.tbCijenaRez.TabIndex = 17;
            // 
            // tbImeGosta
            // 
            this.tbImeGosta.Location = new System.Drawing.Point(461, 132);
            this.tbImeGosta.Name = "tbImeGosta";
            this.tbImeGosta.Size = new System.Drawing.Size(124, 22);
            this.tbImeGosta.TabIndex = 18;
            // 
            // tbPrezimeGosta
            // 
            this.tbPrezimeGosta.Location = new System.Drawing.Point(607, 132);
            this.tbPrezimeGosta.Name = "tbPrezimeGosta";
            this.tbPrezimeGosta.Size = new System.Drawing.Size(124, 22);
            this.tbPrezimeGosta.TabIndex = 19;
            // 
            // cbBrojSobe
            // 
            this.cbBrojSobe.FormattingEnabled = true;
            this.cbBrojSobe.Location = new System.Drawing.Point(1085, 132);
            this.cbBrojSobe.Name = "cbBrojSobe";
            this.cbBrojSobe.Size = new System.Drawing.Size(121, 24);
            this.cbBrojSobe.TabIndex = 20;
            this.cbBrojSobe.SelectedIndexChanged += new System.EventHandler(this.cbBrojSobe_SelectedIndexChanged);
            // 
            // asda
            // 
            this.asda.AutoSize = true;
            this.asda.Location = new System.Drawing.Point(1082, 101);
            this.asda.Name = "asda";
            this.asda.Size = new System.Drawing.Size(66, 17);
            this.asda.TabIndex = 22;
            this.asda.Text = "BrojSobe";
            this.asda.Click += new System.EventHandler(this.label9_Click);
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(1258, 101);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(82, 17);
            this.asd.TabIndex = 23;
            this.asd.Text = "Cijena sobe";
            // 
            // tbCijenaSobe
            // 
            this.tbCijenaSobe.Location = new System.Drawing.Point(1261, 134);
            this.tbCijenaSobe.Name = "tbCijenaSobe";
            this.tbCijenaSobe.Size = new System.Drawing.Size(100, 22);
            this.tbCijenaSobe.TabIndex = 24;
            // 
            // DodavanjeRezervacijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 402);
            this.Controls.Add(this.tbCijenaSobe);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.asda);
            this.Controls.Add(this.cbBrojSobe);
            this.Controls.Add(this.tbPrezimeGosta);
            this.Controls.Add(this.tbImeGosta);
            this.Controls.Add(this.tbCijenaRez);
            this.Controls.Add(this.tbDatumZav);
            this.Controls.Add(this.tbDatumPoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVrstaRez);
            this.Controls.Add(this.cbUsluga);
            this.Controls.Add(this.btnOdustaniDR);
            this.Controls.Add(this.btnIzvrsi);
            this.Name = "DodavanjeRezervacijeForm";
            this.Text = "DodavanjeRezervacijeForm";
            this.Load += new System.EventHandler(this.DodavanjeRezervacijeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzvrsi;
        private System.Windows.Forms.Button btnOdustaniDR;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.ComboBox cbVrstaRez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDatumPoc;
        private System.Windows.Forms.TextBox tbDatumZav;
        private System.Windows.Forms.TextBox tbCijenaRez;
        private System.Windows.Forms.TextBox tbImeGosta;
        private System.Windows.Forms.TextBox tbPrezimeGosta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBrojSobe;
        private System.Windows.Forms.Label asda;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox tbCijenaSobe;
    }
}