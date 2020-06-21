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
            this.btnOsvjeziRezervacije = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPretragaPoPrezimenu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacija_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervacije_lbl
            // 
            this.rezervacije_lbl.AutoSize = true;
            this.rezervacije_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezervacije_lbl.ForeColor = System.Drawing.Color.OliveDrab;
            this.rezervacije_lbl.Location = new System.Drawing.Point(26, 35);
            this.rezervacije_lbl.Name = "rezervacije_lbl";
            this.rezervacije_lbl.Size = new System.Drawing.Size(149, 20);
            this.rezervacije_lbl.TabIndex = 0;
            this.rezervacije_lbl.Text = "Popis rezervacija:";
            // 
            // rezervacija_dtg
            // 
            this.rezervacija_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervacija_dtg.Location = new System.Drawing.Point(30, 58);
            this.rezervacija_dtg.Name = "rezervacija_dtg";
            this.rezervacija_dtg.RowHeadersWidth = 51;
            this.rezervacija_dtg.Size = new System.Drawing.Size(691, 345);
            this.rezervacija_dtg.TabIndex = 1;
            this.rezervacija_dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rezervacija_dtg_CellContentClick);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.dodaj_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj_btn.ForeColor = System.Drawing.Color.White;
            this.dodaj_btn.Location = new System.Drawing.Point(469, 409);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(80, 40);
            this.dodaj_btn.TabIndex = 2;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = false;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // izmijeni_btn
            // 
            this.izmijeni_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.izmijeni_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izmijeni_btn.ForeColor = System.Drawing.Color.White;
            this.izmijeni_btn.Location = new System.Drawing.Point(555, 409);
            this.izmijeni_btn.Name = "izmijeni_btn";
            this.izmijeni_btn.Size = new System.Drawing.Size(80, 40);
            this.izmijeni_btn.TabIndex = 3;
            this.izmijeni_btn.Text = "Izmijeni";
            this.izmijeni_btn.UseVisualStyleBackColor = false;
            this.izmijeni_btn.Click += new System.EventHandler(this.izmijeni_btn_Click);
            // 
            // izbriši_btn
            // 
            this.izbriši_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.izbriši_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izbriši_btn.ForeColor = System.Drawing.Color.White;
            this.izbriši_btn.Location = new System.Drawing.Point(641, 409);
            this.izbriši_btn.Name = "izbriši_btn";
            this.izbriši_btn.Size = new System.Drawing.Size(80, 40);
            this.izbriši_btn.TabIndex = 4;
            this.izbriši_btn.Text = "Izbriši";
            this.izbriši_btn.UseVisualStyleBackColor = false;
            this.izbriši_btn.Click += new System.EventHandler(this.izbriši_btn_Click);
            // 
            // btnOsvjeziRezervacije
            // 
            this.btnOsvjeziRezervacije.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOsvjeziRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOsvjeziRezervacije.ForeColor = System.Drawing.Color.White;
            this.btnOsvjeziRezervacije.Location = new System.Drawing.Point(641, 12);
            this.btnOsvjeziRezervacije.Name = "btnOsvjeziRezervacije";
            this.btnOsvjeziRezervacije.Size = new System.Drawing.Size(80, 40);
            this.btnOsvjeziRezervacije.TabIndex = 6;
            this.btnOsvjeziRezervacije.Text = "Osvježi";
            this.btnOsvjeziRezervacije.UseVisualStyleBackColor = false;
            this.btnOsvjeziRezervacije.Click += new System.EventHandler(this.btnOsvjeziRezervacije_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(281, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pretraga po prezimenu:";
            // 
            // tbPretragaPoPrezimenu
            // 
            this.tbPretragaPoPrezimenu.Location = new System.Drawing.Point(469, 23);
            this.tbPretragaPoPrezimenu.Margin = new System.Windows.Forms.Padding(2);
            this.tbPretragaPoPrezimenu.Name = "tbPretragaPoPrezimenu";
            this.tbPretragaPoPrezimenu.Size = new System.Drawing.Size(167, 20);
            this.tbPretragaPoPrezimenu.TabIndex = 8;
            this.tbPretragaPoPrezimenu.TextChanged += new System.EventHandler(this.tbPretragaPoPrezimenu_TextChanged);
            // 
            // RezervacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.tbPretragaPoPrezimenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOsvjeziRezervacije);
            this.Controls.Add(this.izbriši_btn);
            this.Controls.Add(this.izmijeni_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.rezervacija_dtg);
            this.Controls.Add(this.rezervacije_lbl);
            this.Name = "RezervacijaForm";
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.RezervacijaForm_Load);
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
        private System.Windows.Forms.Button btnOsvjeziRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPretragaPoPrezimenu;
    }
}