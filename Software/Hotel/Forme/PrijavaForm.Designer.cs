namespace Hotel
{
    partial class PrijavaForm
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
            this.prijavagroupBox = new System.Windows.Forms.GroupBox();
            this.prijavi_btn = new System.Windows.Forms.Button();
            this.ulogagroupBox = new System.Windows.Forms.GroupBox();
            this.zaposlenik_rbtn = new System.Windows.Forms.RadioButton();
            this.administrator_rbtn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lozinka_lbl = new System.Windows.Forms.Label();
            this.imetextBox = new System.Windows.Forms.TextBox();
            this.korisnickoIme_lbl = new System.Windows.Forms.Label();
            this.odustani_btn = new System.Windows.Forms.Button();
            this.prijavagroupBox.SuspendLayout();
            this.ulogagroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // prijavagroupBox
            // 
            this.prijavagroupBox.Controls.Add(this.odustani_btn);
            this.prijavagroupBox.Controls.Add(this.prijavi_btn);
            this.prijavagroupBox.Controls.Add(this.ulogagroupBox);
            this.prijavagroupBox.Controls.Add(this.textBox1);
            this.prijavagroupBox.Controls.Add(this.lozinka_lbl);
            this.prijavagroupBox.Controls.Add(this.imetextBox);
            this.prijavagroupBox.Controls.Add(this.korisnickoIme_lbl);
            this.prijavagroupBox.Location = new System.Drawing.Point(107, 61);
            this.prijavagroupBox.Name = "prijavagroupBox";
            this.prijavagroupBox.Size = new System.Drawing.Size(566, 366);
            this.prijavagroupBox.TabIndex = 0;
            this.prijavagroupBox.TabStop = false;
            this.prijavagroupBox.Text = "Prijava";
            // 
            // prijavi_btn
            // 
            this.prijavi_btn.Location = new System.Drawing.Point(323, 327);
            this.prijavi_btn.Name = "prijavi_btn";
            this.prijavi_btn.Size = new System.Drawing.Size(75, 23);
            this.prijavi_btn.TabIndex = 6;
            this.prijavi_btn.Text = "Prijavi se ";
            this.prijavi_btn.UseVisualStyleBackColor = true;
            this.prijavi_btn.Click += new System.EventHandler(this.prijavi_btn_Click);
            // 
            // ulogagroupBox
            // 
            this.ulogagroupBox.Controls.Add(this.zaposlenik_rbtn);
            this.ulogagroupBox.Controls.Add(this.administrator_rbtn);
            this.ulogagroupBox.Location = new System.Drawing.Point(198, 174);
            this.ulogagroupBox.Name = "ulogagroupBox";
            this.ulogagroupBox.Size = new System.Drawing.Size(200, 100);
            this.ulogagroupBox.TabIndex = 5;
            this.ulogagroupBox.TabStop = false;
            this.ulogagroupBox.Text = "Uloga";
            // 
            // zaposlenik_rbtn
            // 
            this.zaposlenik_rbtn.AutoSize = true;
            this.zaposlenik_rbtn.Location = new System.Drawing.Point(10, 57);
            this.zaposlenik_rbtn.Name = "zaposlenik_rbtn";
            this.zaposlenik_rbtn.Size = new System.Drawing.Size(77, 17);
            this.zaposlenik_rbtn.TabIndex = 1;
            this.zaposlenik_rbtn.TabStop = true;
            this.zaposlenik_rbtn.Text = "Zaposlenik";
            this.zaposlenik_rbtn.UseVisualStyleBackColor = true;
            // 
            // administrator_rbtn
            // 
            this.administrator_rbtn.AutoSize = true;
            this.administrator_rbtn.Location = new System.Drawing.Point(10, 33);
            this.administrator_rbtn.Name = "administrator_rbtn";
            this.administrator_rbtn.Size = new System.Drawing.Size(85, 17);
            this.administrator_rbtn.TabIndex = 0;
            this.administrator_rbtn.TabStop = true;
            this.administrator_rbtn.Text = "Administrator";
            this.administrator_rbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lozinka_lbl
            // 
            this.lozinka_lbl.AutoSize = true;
            this.lozinka_lbl.Location = new System.Drawing.Point(205, 124);
            this.lozinka_lbl.Name = "lozinka_lbl";
            this.lozinka_lbl.Size = new System.Drawing.Size(47, 13);
            this.lozinka_lbl.TabIndex = 2;
            this.lozinka_lbl.Text = "Lozinka:";
            this.lozinka_lbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // imetextBox
            // 
            this.imetextBox.Location = new System.Drawing.Point(258, 63);
            this.imetextBox.Name = "imetextBox";
            this.imetextBox.Size = new System.Drawing.Size(100, 20);
            this.imetextBox.TabIndex = 1;
            // 
            // korisnickoIme_lbl
            // 
            this.korisnickoIme_lbl.AutoSize = true;
            this.korisnickoIme_lbl.Location = new System.Drawing.Point(174, 63);
            this.korisnickoIme_lbl.Name = "korisnickoIme_lbl";
            this.korisnickoIme_lbl.Size = new System.Drawing.Size(78, 13);
            this.korisnickoIme_lbl.TabIndex = 0;
            this.korisnickoIme_lbl.Text = "Korisničko ime:";
            this.korisnickoIme_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // odustani_btn
            // 
            this.odustani_btn.Location = new System.Drawing.Point(463, 327);
            this.odustani_btn.Name = "odustani_btn";
            this.odustani_btn.Size = new System.Drawing.Size(75, 23);
            this.odustani_btn.TabIndex = 7;
            this.odustani_btn.Text = "Odustani";
            this.odustani_btn.UseVisualStyleBackColor = true;
            this.odustani_btn.Click += new System.EventHandler(this.odustani_btn_Click);
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prijavagroupBox);
            this.Name = "PrijavaForm";
            this.Text = "Prijava";
            this.prijavagroupBox.ResumeLayout(false);
            this.prijavagroupBox.PerformLayout();
            this.ulogagroupBox.ResumeLayout(false);
            this.ulogagroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox prijavagroupBox;
        private System.Windows.Forms.Label korisnickoIme_lbl;
        private System.Windows.Forms.Label lozinka_lbl;
        private System.Windows.Forms.TextBox imetextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button prijavi_btn;
        private System.Windows.Forms.GroupBox ulogagroupBox;
        private System.Windows.Forms.RadioButton zaposlenik_rbtn;
        private System.Windows.Forms.RadioButton administrator_rbtn;
        private System.Windows.Forms.Button odustani_btn;
    }
}