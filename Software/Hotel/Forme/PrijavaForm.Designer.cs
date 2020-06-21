namespace Hotel
{
    partial class frmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijava));
            this.prijavagroupBox = new System.Windows.Forms.GroupBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lbPrijava = new System.Windows.Forms.Label();
            this.gbUloga = new System.Windows.Forms.GroupBox();
            this.zaposlenik_rbtn = new System.Windows.Forms.RadioButton();
            this.administrator_rbtn = new System.Windows.Forms.RadioButton();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.imetextbox = new System.Windows.Forms.TextBox();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.pbPrijava = new System.Windows.Forms.PictureBox();
            this.prijavagroupBox.SuspendLayout();
            this.gbUloga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrijava)).BeginInit();
            this.SuspendLayout();
            // 
            // prijavagroupBox
            // 
            this.prijavagroupBox.Controls.Add(this.btnOdustani);
            this.prijavagroupBox.Controls.Add(this.lbPrijava);
            this.prijavagroupBox.Controls.Add(this.gbUloga);
            this.prijavagroupBox.Controls.Add(this.btnPrijava);
            this.prijavagroupBox.Controls.Add(this.imetextbox);
            this.prijavagroupBox.Controls.Add(this.lbLozinka);
            this.prijavagroupBox.Controls.Add(this.tbLozinka);
            this.prijavagroupBox.Controls.Add(this.lbKorisnickoIme);
            this.prijavagroupBox.Location = new System.Drawing.Point(370, 0);
            this.prijavagroupBox.Name = "prijavagroupBox";
            this.prijavagroupBox.Size = new System.Drawing.Size(372, 450);
            this.prijavagroupBox.TabIndex = 0;
            this.prijavagroupBox.TabStop = false;
            this.prijavagroupBox.Enter += new System.EventHandler(this.prijavagroupBox_Enter);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOdustani.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(52, 388);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 50);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lbPrijava
            // 
            this.lbPrijava.AutoSize = true;
            this.lbPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPrijava.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbPrijava.Location = new System.Drawing.Point(113, 39);
            this.lbPrijava.Name = "lbPrijava";
            this.lbPrijava.Size = new System.Drawing.Size(135, 31);
            this.lbPrijava.TabIndex = 6;
            this.lbPrijava.Text = "PRIJAVA";
            this.lbPrijava.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // gbUloga
            // 
            this.gbUloga.Controls.Add(this.zaposlenik_rbtn);
            this.gbUloga.Controls.Add(this.administrator_rbtn);
            this.gbUloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbUloga.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.gbUloga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbUloga.Location = new System.Drawing.Point(56, 250);
            this.gbUloga.Name = "gbUloga";
            this.gbUloga.Size = new System.Drawing.Size(250, 100);
            this.gbUloga.TabIndex = 3;
            this.gbUloga.TabStop = false;
            this.gbUloga.Text = "Uloga";
            // 
            // zaposlenik_rbtn
            // 
            this.zaposlenik_rbtn.AutoSize = true;
            this.zaposlenik_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaposlenik_rbtn.Location = new System.Drawing.Point(10, 57);
            this.zaposlenik_rbtn.Name = "zaposlenik_rbtn";
            this.zaposlenik_rbtn.Size = new System.Drawing.Size(103, 20);
            this.zaposlenik_rbtn.TabIndex = 1;
            this.zaposlenik_rbtn.TabStop = true;
            this.zaposlenik_rbtn.Text = "Zaposlenik";
            this.zaposlenik_rbtn.UseVisualStyleBackColor = true;
            // 
            // administrator_rbtn
            // 
            this.administrator_rbtn.AutoSize = true;
            this.administrator_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.administrator_rbtn.Location = new System.Drawing.Point(10, 33);
            this.administrator_rbtn.Name = "administrator_rbtn";
            this.administrator_rbtn.Size = new System.Drawing.Size(117, 20);
            this.administrator_rbtn.TabIndex = 1;
            this.administrator_rbtn.TabStop = true;
            this.administrator_rbtn.Text = "Administrator";
            this.administrator_rbtn.UseVisualStyleBackColor = true;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPrijava.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrijava.FlatAppearance.BorderSize = 2;
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.Location = new System.Drawing.Point(188, 388);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(125, 50);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijavi se ";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.prijavi_btn_Click);
            // 
            // imetextbox
            // 
            this.imetextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imetextbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imetextbox.Location = new System.Drawing.Point(56, 127);
            this.imetextbox.Multiline = true;
            this.imetextbox.Name = "imetextbox";
            this.imetextbox.Size = new System.Drawing.Size(250, 25);
            this.imetextbox.TabIndex = 0;
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLozinka.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbLozinka.Location = new System.Drawing.Point(52, 177);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(76, 20);
            this.lbLozinka.TabIndex = 7;
            this.lbLozinka.Text = "Lozinka:";
            this.lbLozinka.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbLozinka
            // 
            this.tbLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLozinka.Location = new System.Drawing.Point(56, 200);
            this.tbLozinka.Multiline = true;
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(250, 25);
            this.tbLozinka.TabIndex = 2;
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKorisnickoIme.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbKorisnickoIme.Location = new System.Drawing.Point(52, 104);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(129, 20);
            this.lbKorisnickoIme.TabIndex = 7;
            this.lbKorisnickoIme.Text = "Korisničko ime:";
            this.lbKorisnickoIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbPrijava
            // 
            this.pbPrijava.Image = ((System.Drawing.Image)(resources.GetObject("pbPrijava.Image")));
            this.pbPrijava.Location = new System.Drawing.Point(1, 0);
            this.pbPrijava.Name = "pbPrijava";
            this.pbPrijava.Size = new System.Drawing.Size(372, 450);
            this.pbPrijava.TabIndex = 1;
            this.pbPrijava.TabStop = false;
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.pbPrijava);
            this.Controls.Add(this.prijavagroupBox);
            this.Name = "frmPrijava";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.PrijavaForm_Load);
            this.prijavagroupBox.ResumeLayout(false);
            this.prijavagroupBox.PerformLayout();
            this.gbUloga.ResumeLayout(false);
            this.gbUloga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrijava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox prijavagroupBox;
        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.GroupBox gbUloga;
        private System.Windows.Forms.RadioButton zaposlenik_rbtn;
        private System.Windows.Forms.RadioButton administrator_rbtn;
        private System.Windows.Forms.PictureBox pbPrijava;
        private System.Windows.Forms.Label lbPrijava;
        private System.Windows.Forms.TextBox imetextbox;
        private System.Windows.Forms.Button btnOdustani;
    }
}