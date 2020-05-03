namespace Hotel
{
    partial class RacunForm
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
            this.racun_dgv = new System.Windows.Forms.DataGridView();
            this.kreirajRacun_btn = new System.Windows.Forms.Button();
            this.Azuriraj_btn = new System.Windows.Forms.Button();
            this.obrisi_btn = new System.Windows.Forms.Button();
            this.zatvori_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racun_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // racun_dgv
            // 
            this.racun_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racun_dgv.Location = new System.Drawing.Point(34, 58);
            this.racun_dgv.Name = "racun_dgv";
            this.racun_dgv.Size = new System.Drawing.Size(532, 286);
            this.racun_dgv.TabIndex = 0;
            // 
            // kreirajRacun_btn
            // 
            this.kreirajRacun_btn.Location = new System.Drawing.Point(612, 100);
            this.kreirajRacun_btn.Name = "kreirajRacun_btn";
            this.kreirajRacun_btn.Size = new System.Drawing.Size(140, 40);
            this.kreirajRacun_btn.TabIndex = 1;
            this.kreirajRacun_btn.Text = "Kreiraj novi račun";
            this.kreirajRacun_btn.UseVisualStyleBackColor = true;
            this.kreirajRacun_btn.Click += new System.EventHandler(this.kreirajRacun_btn_Click);
            // 
            // Azuriraj_btn
            // 
            this.Azuriraj_btn.Location = new System.Drawing.Point(612, 162);
            this.Azuriraj_btn.Name = "Azuriraj_btn";
            this.Azuriraj_btn.Size = new System.Drawing.Size(140, 40);
            this.Azuriraj_btn.TabIndex = 2;
            this.Azuriraj_btn.Text = "Ažuriraj odabrani račun";
            this.Azuriraj_btn.UseVisualStyleBackColor = true;
            this.Azuriraj_btn.Click += new System.EventHandler(this.Azuriraj_btn_Click);
            // 
            // obrisi_btn
            // 
            this.obrisi_btn.Location = new System.Drawing.Point(612, 232);
            this.obrisi_btn.Name = "obrisi_btn";
            this.obrisi_btn.Size = new System.Drawing.Size(140, 40);
            this.obrisi_btn.TabIndex = 3;
            this.obrisi_btn.Text = "Obriši račun";
            this.obrisi_btn.UseVisualStyleBackColor = true;
            this.obrisi_btn.Click += new System.EventHandler(this.obrisi_btn_Click);
            // 
            // zatvori_btn
            // 
            this.zatvori_btn.Location = new System.Drawing.Point(713, 12);
            this.zatvori_btn.Name = "zatvori_btn";
            this.zatvori_btn.Size = new System.Drawing.Size(75, 40);
            this.zatvori_btn.TabIndex = 6;
            this.zatvori_btn.Text = "Zatvori";
            this.zatvori_btn.UseVisualStyleBackColor = true;
            this.zatvori_btn.Click += new System.EventHandler(this.zatvori_btn_Click);
            // 
            // RacunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zatvori_btn);
            this.Controls.Add(this.obrisi_btn);
            this.Controls.Add(this.Azuriraj_btn);
            this.Controls.Add(this.kreirajRacun_btn);
            this.Controls.Add(this.racun_dgv);
            this.Name = "RacunForm";
            this.Text = "Racun";
            ((System.ComponentModel.ISupportInitialize)(this.racun_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView racun_dgv;
        private System.Windows.Forms.Button kreirajRacun_btn;
        private System.Windows.Forms.Button Azuriraj_btn;
        private System.Windows.Forms.Button obrisi_btn;
        private System.Windows.Forms.Button zatvori_btn;
    }
}