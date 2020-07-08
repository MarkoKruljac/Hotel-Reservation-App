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
            this.pbPrijava = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.imetextbox = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.administrator_rbtn = new System.Windows.Forms.RadioButton();
            this.zaposlenik_rbtn = new System.Windows.Forms.RadioButton();
            this.lbPrijava = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrijava)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPrijava
            // 
            this.pbPrijava.Image = ((System.Drawing.Image)(resources.GetObject("pbPrijava.Image")));
            this.pbPrijava.Location = new System.Drawing.Point(13, 10);
            this.pbPrijava.Name = "pbPrijava";
            this.pbPrijava.Size = new System.Drawing.Size(401, 452);
            this.pbPrijava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrijava.TabIndex = 1;
            this.pbPrijava.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(13, 457);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 2;
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKorisnickoIme.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbKorisnickoIme.Location = new System.Drawing.Point(476, 135);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(129, 20);
            this.lbKorisnickoIme.TabIndex = 7;
            this.lbKorisnickoIme.Text = "Korisničko ime:";
            this.lbKorisnickoIme.Click += new System.EventHandler(this.lbKorisnickoIme_Click);
            // 
            // tbLozinka
            // 
            this.tbLozinka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLozinka.Location = new System.Drawing.Point(486, 237);
            this.tbLozinka.Multiline = true;
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(250, 22);
            this.tbLozinka.TabIndex = 2;
            // 
            // lbLozinka
            // 
            this.lbLozinka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLozinka.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbLozinka.Location = new System.Drawing.Point(482, 214);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(76, 20);
            this.lbLozinka.TabIndex = 7;
            this.lbLozinka.Text = "Lozinka:";
            // 
            // imetextbox
            // 
            this.imetextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imetextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imetextbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imetextbox.Location = new System.Drawing.Point(480, 158);
            this.imetextbox.Multiline = true;
            this.imetextbox.Name = "imetextbox";
            this.imetextbox.Size = new System.Drawing.Size(250, 22);
            this.imetextbox.TabIndex = 0;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrijava.AutoSize = true;
            this.btnPrijava.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPrijava.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrijava.FlatAppearance.BorderSize = 2;
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.Location = new System.Drawing.Point(480, 412);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(125, 50);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijavi se ";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.prijavi_btn_Click);
            // 
            // administrator_rbtn
            // 
            this.administrator_rbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.administrator_rbtn.AutoSize = true;
            this.administrator_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.administrator_rbtn.Location = new System.Drawing.Point(488, 344);
            this.administrator_rbtn.Name = "administrator_rbtn";
            this.administrator_rbtn.Size = new System.Drawing.Size(117, 20);
            this.administrator_rbtn.TabIndex = 1;
            this.administrator_rbtn.TabStop = true;
            this.administrator_rbtn.Text = "Administrator";
            this.administrator_rbtn.UseVisualStyleBackColor = true;
            // 
            // zaposlenik_rbtn
            // 
            this.zaposlenik_rbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zaposlenik_rbtn.AutoSize = true;
            this.zaposlenik_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaposlenik_rbtn.Location = new System.Drawing.Point(488, 370);
            this.zaposlenik_rbtn.Name = "zaposlenik_rbtn";
            this.zaposlenik_rbtn.Size = new System.Drawing.Size(103, 20);
            this.zaposlenik_rbtn.TabIndex = 1;
            this.zaposlenik_rbtn.TabStop = true;
            this.zaposlenik_rbtn.Text = "Zaposlenik";
            this.zaposlenik_rbtn.UseVisualStyleBackColor = true;
            // 
            // lbPrijava
            // 
            this.lbPrijava.AutoSize = true;
            this.lbPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPrijava.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbPrijava.Location = new System.Drawing.Point(518, 71);
            this.lbPrijava.Name = "lbPrijava";
            this.lbPrijava.Size = new System.Drawing.Size(135, 31);
            this.lbPrijava.TabIndex = 6;
            this.lbPrijava.Text = "PRIJAVA";
            this.lbPrijava.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.AutoSize = true;
            this.btnOdustani.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOdustani.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(620, 412);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 50);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.administrator_rbtn);
            this.groupBox1.Controls.Add(this.pbPrijava);
            this.groupBox1.Controls.Add(this.zaposlenik_rbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbPrijava);
            this.groupBox1.Controls.Add(this.btnPrijava);
            this.groupBox1.Controls.Add(this.btnOdustani);
            this.groupBox1.Controls.Add(this.tbLozinka);
            this.groupBox1.Controls.Add(this.lbKorisnickoIme);
            this.groupBox1.Controls.Add(this.lbLozinka);
            this.groupBox1.Controls.Add(this.imetextbox);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 568);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(482, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Uloga:";
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(793, 538);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrijavaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrijava)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPrijava;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.TextBox imetextbox;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.RadioButton administrator_rbtn;
        private System.Windows.Forms.RadioButton zaposlenik_rbtn;
        private System.Windows.Forms.Label lbPrijava;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}