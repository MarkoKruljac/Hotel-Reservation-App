namespace Hotel
{
    partial class RezervacijaForm
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
            this.rezervacije_lbl = new System.Windows.Forms.Label();
            this.rezervacija_dtg = new System.Windows.Forms.DataGridView();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.izmijeni_btn = new System.Windows.Forms.Button();
            this.izbriši_btn = new System.Windows.Forms.Button();
            this.zatvori_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacija_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervacije_lbl
            // 
            this.rezervacije_lbl.AutoSize = true;
            this.rezervacije_lbl.Location = new System.Drawing.Point(41, 34);
            this.rezervacije_lbl.Name = "rezervacije_lbl";
            this.rezervacije_lbl.Size = new System.Drawing.Size(90, 13);
            this.rezervacije_lbl.TabIndex = 0;
            this.rezervacije_lbl.Text = "Popis rezervacija:";
            // 
            // rezervacija_dtg
            // 
            this.rezervacija_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervacija_dtg.Location = new System.Drawing.Point(44, 50);
            this.rezervacija_dtg.Name = "rezervacija_dtg";
            this.rezervacija_dtg.Size = new System.Drawing.Size(703, 345);
            this.rezervacija_dtg.TabIndex = 1;
            this.rezervacija_dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rezervacija_dtg_CellContentClick);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(509, 401);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(75, 40);
            this.dodaj_btn.TabIndex = 2;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // izmijeni_btn
            // 
            this.izmijeni_btn.Location = new System.Drawing.Point(590, 401);
            this.izmijeni_btn.Name = "izmijeni_btn";
            this.izmijeni_btn.Size = new System.Drawing.Size(75, 40);
            this.izmijeni_btn.TabIndex = 3;
            this.izmijeni_btn.Text = "Izmijeni";
            this.izmijeni_btn.UseVisualStyleBackColor = true;
            this.izmijeni_btn.Click += new System.EventHandler(this.izmijeni_btn_Click);
            // 
            // izbriši_btn
            // 
            this.izbriši_btn.Location = new System.Drawing.Point(672, 401);
            this.izbriši_btn.Name = "izbriši_btn";
            this.izbriši_btn.Size = new System.Drawing.Size(75, 40);
            this.izbriši_btn.TabIndex = 4;
            this.izbriši_btn.Text = "Izbriši";
            this.izbriši_btn.UseVisualStyleBackColor = true;
            this.izbriši_btn.Click += new System.EventHandler(this.izbriši_btn_Click);
            // 
            // zatvori_btn
            // 
            this.zatvori_btn.Location = new System.Drawing.Point(672, 7);
            this.zatvori_btn.Name = "zatvori_btn";
            this.zatvori_btn.Size = new System.Drawing.Size(75, 40);
            this.zatvori_btn.TabIndex = 5;
            this.zatvori_btn.Text = "Zatvori";
            this.zatvori_btn.UseVisualStyleBackColor = true;
            this.zatvori_btn.Click += new System.EventHandler(this.zatvori_btn_Click);
            // 
            // RezervacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zatvori_btn);
            this.Controls.Add(this.izbriši_btn);
            this.Controls.Add(this.izmijeni_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.rezervacija_dtg);
            this.Controls.Add(this.rezervacije_lbl);
            this.Name = "RezervacijaForm";
            this.Text = "Rezervacija";
            ((System.ComponentModel.ISupportInitialize)(this.rezervacija_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rezervacije_lbl;
        private System.Windows.Forms.DataGridView rezervacija_dtg;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button izmijeni_btn;
        private System.Windows.Forms.Button izbriši_btn;
        private System.Windows.Forms.Button zatvori_btn;
    }
}