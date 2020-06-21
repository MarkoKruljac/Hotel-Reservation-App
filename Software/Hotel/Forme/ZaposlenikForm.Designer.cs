namespace Hotel.Forme
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
            this.btnOsvjeziZaposlenike = new System.Windows.Forms.Button();
            this.btnIzbrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnIzmijeniZaposlenika = new System.Windows.Forms.Button();
            this.btnDodajZaposlenike = new System.Windows.Forms.Button();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.rezervacije_lbl = new System.Windows.Forms.Label();
            this.tbPretragaPoPrezimenu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOsvjeziZaposlenike
            // 
            this.btnOsvjeziZaposlenike.Location = new System.Drawing.Point(691, 12);
            this.btnOsvjeziZaposlenike.Name = "btnOsvjeziZaposlenike";
            this.btnOsvjeziZaposlenike.Size = new System.Drawing.Size(62, 33);
            this.btnOsvjeziZaposlenike.TabIndex = 13;
            this.btnOsvjeziZaposlenike.Text = "Osvježi";
            this.btnOsvjeziZaposlenike.UseVisualStyleBackColor = true;
            this.btnOsvjeziZaposlenike.Click += new System.EventHandler(this.btnOsvjeziZaposlenike_Click);
            // 
            // btnIzbrisiZaposlenika
            // 
            this.btnIzbrisiZaposlenika.Location = new System.Drawing.Point(678, 402);
            this.btnIzbrisiZaposlenika.Name = "btnIzbrisiZaposlenika";
            this.btnIzbrisiZaposlenika.Size = new System.Drawing.Size(75, 40);
            this.btnIzbrisiZaposlenika.TabIndex = 11;
            this.btnIzbrisiZaposlenika.Text = "Izbriši";
            this.btnIzbrisiZaposlenika.UseVisualStyleBackColor = true;
            this.btnIzbrisiZaposlenika.Click += new System.EventHandler(this.btnIzbrisiZaposlenika_Click);
            // 
            // btnIzmijeniZaposlenika
            // 
            this.btnIzmijeniZaposlenika.Location = new System.Drawing.Point(596, 402);
            this.btnIzmijeniZaposlenika.Name = "btnIzmijeniZaposlenika";
            this.btnIzmijeniZaposlenika.Size = new System.Drawing.Size(75, 40);
            this.btnIzmijeniZaposlenika.TabIndex = 10;
            this.btnIzmijeniZaposlenika.Text = "Izmijeni";
            this.btnIzmijeniZaposlenika.UseVisualStyleBackColor = true;
            this.btnIzmijeniZaposlenika.Click += new System.EventHandler(this.btnIzmijeniZaposlenika_Click);
            // 
            // btnDodajZaposlenike
            // 
            this.btnDodajZaposlenike.Location = new System.Drawing.Point(515, 402);
            this.btnDodajZaposlenike.Name = "btnDodajZaposlenike";
            this.btnDodajZaposlenike.Size = new System.Drawing.Size(75, 40);
            this.btnDodajZaposlenike.TabIndex = 9;
            this.btnDodajZaposlenike.Text = "Dodaj";
            this.btnDodajZaposlenike.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenike.Click += new System.EventHandler(this.btnDodajZaposlenike_Click);
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(50, 51);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowHeadersWidth = 51;
            this.dgvZaposlenici.Size = new System.Drawing.Size(703, 345);
            this.dgvZaposlenici.TabIndex = 8;
            // 
            // rezervacije_lbl
            // 
            this.rezervacije_lbl.AutoSize = true;
            this.rezervacije_lbl.Location = new System.Drawing.Point(47, 22);
            this.rezervacije_lbl.Name = "rezervacije_lbl";
            this.rezervacije_lbl.Size = new System.Drawing.Size(95, 13);
            this.rezervacije_lbl.TabIndex = 7;
            this.rezervacije_lbl.Text = "Popis zaposlenika:";
            // 
            // tbPretragaPoPrezimenu
            // 
            this.tbPretragaPoPrezimenu.Location = new System.Drawing.Point(526, 19);
            this.tbPretragaPoPrezimenu.Margin = new System.Windows.Forms.Padding(2);
            this.tbPretragaPoPrezimenu.Name = "tbPretragaPoPrezimenu";
            this.tbPretragaPoPrezimenu.Size = new System.Drawing.Size(125, 20);
            this.tbPretragaPoPrezimenu.TabIndex = 15;
            this.tbPretragaPoPrezimenu.TextChanged += new System.EventHandler(this.tbPretragaPoPrezimenu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pretraga po prezimenu:";
            // 
            // ZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPretragaPoPrezimenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOsvjeziZaposlenike);
            this.Controls.Add(this.btnIzbrisiZaposlenika);
            this.Controls.Add(this.btnIzmijeniZaposlenika);
            this.Controls.Add(this.btnDodajZaposlenike);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.rezervacije_lbl);
            this.Name = "ZaposlenikForm";
            this.Text = "ZaposlenikForm";
            this.Load += new System.EventHandler(this.ZaposlenikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOsvjeziZaposlenike;
        private System.Windows.Forms.Button btnIzbrisiZaposlenika;
        private System.Windows.Forms.Button btnIzmijeniZaposlenika;
        private System.Windows.Forms.Button btnDodajZaposlenike;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Label rezervacije_lbl;
        private System.Windows.Forms.TextBox tbPretragaPoPrezimenu;
        private System.Windows.Forms.Label label1;
    }
}