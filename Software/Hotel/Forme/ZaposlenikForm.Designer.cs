namespace Hotel
{
    partial class ZaposlenikForm
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
            this.zaposlenici_lbl = new System.Windows.Forms.Label();
            this.zaposlenici_dtg = new System.Windows.Forms.DataGridView();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.izbriši_btn = new System.Windows.Forms.Button();
            this.izmijeni_btn = new System.Windows.Forms.Button();
            this.odustani_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenici_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // zaposlenici_lbl
            // 
            this.zaposlenici_lbl.AutoSize = true;
            this.zaposlenici_lbl.Location = new System.Drawing.Point(55, 32);
            this.zaposlenici_lbl.Name = "zaposlenici_lbl";
            this.zaposlenici_lbl.Size = new System.Drawing.Size(95, 13);
            this.zaposlenici_lbl.TabIndex = 0;
            this.zaposlenici_lbl.Text = "Popis zaposlenika:";
            // 
            // zaposlenici_dtg
            // 
            this.zaposlenici_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposlenici_dtg.Location = new System.Drawing.Point(58, 48);
            this.zaposlenici_dtg.Name = "zaposlenici_dtg";
            this.zaposlenici_dtg.Size = new System.Drawing.Size(690, 343);
            this.zaposlenici_dtg.TabIndex = 1;
            this.zaposlenici_dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Zaposlenici_dtg_CellContentClick);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(509, 408);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(75, 30);
            this.dodaj_btn.TabIndex = 2;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // izbriši_btn
            // 
            this.izbriši_btn.Location = new System.Drawing.Point(673, 408);
            this.izbriši_btn.Name = "izbriši_btn";
            this.izbriši_btn.Size = new System.Drawing.Size(75, 30);
            this.izbriši_btn.TabIndex = 3;
            this.izbriši_btn.Text = "Izbriši";
            this.izbriši_btn.UseVisualStyleBackColor = true;
            this.izbriši_btn.Click += new System.EventHandler(this.izbriši_btn_Click);
            // 
            // izmijeni_btn
            // 
            this.izmijeni_btn.Location = new System.Drawing.Point(590, 408);
            this.izmijeni_btn.Name = "izmijeni_btn";
            this.izmijeni_btn.Size = new System.Drawing.Size(75, 30);
            this.izmijeni_btn.TabIndex = 4;
            this.izmijeni_btn.Text = "Izmijeni";
            this.izmijeni_btn.UseVisualStyleBackColor = true;
            this.izmijeni_btn.Click += new System.EventHandler(this.izmijeni_btn_Click);
            // 
            // odustani_btn
            // 
            this.odustani_btn.Location = new System.Drawing.Point(673, 12);
            this.odustani_btn.Name = "odustani_btn";
            this.odustani_btn.Size = new System.Drawing.Size(75, 30);
            this.odustani_btn.TabIndex = 5;
            this.odustani_btn.Text = "Odustani";
            this.odustani_btn.UseVisualStyleBackColor = true;
            this.odustani_btn.Click += new System.EventHandler(this.odustani_btn_Click);
            // 
            // ZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odustani_btn);
            this.Controls.Add(this.izmijeni_btn);
            this.Controls.Add(this.izbriši_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.zaposlenici_dtg);
            this.Controls.Add(this.zaposlenici_lbl);
            this.Name = "ZaposlenikForm";
            this.Text = "Zaposlenik";
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenici_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zaposlenici_lbl;
        private System.Windows.Forms.DataGridView zaposlenici_dtg;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button izbriši_btn;
        private System.Windows.Forms.Button izmijeni_btn;
        private System.Windows.Forms.Button odustani_btn;
    }
}