namespace Hotel.Forme
{
    partial class GostiForma
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
            this.btnDodajGosta = new System.Windows.Forms.Button();
            this.btnIzmjenaGosta = new System.Windows.Forms.Button();
            this.btnIzbrisiGosta = new System.Windows.Forms.Button();
            this.dgvGosti = new System.Windows.Forms.DataGridView();
            this.btnOsvjeziGoste = new System.Windows.Forms.Button();
            this.tbPrezimeGosta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajGosta
            // 
            this.btnDodajGosta.Location = new System.Drawing.Point(541, 362);
            this.btnDodajGosta.Name = "btnDodajGosta";
            this.btnDodajGosta.Size = new System.Drawing.Size(111, 62);
            this.btnDodajGosta.TabIndex = 1;
            this.btnDodajGosta.Text = "Dodaj gosta";
            this.btnDodajGosta.UseVisualStyleBackColor = true;
            this.btnDodajGosta.Click += new System.EventHandler(this.btnDodajGosta_Click);
            // 
            // btnIzmjenaGosta
            // 
            this.btnIzmjenaGosta.Location = new System.Drawing.Point(383, 362);
            this.btnIzmjenaGosta.Name = "btnIzmjenaGosta";
            this.btnIzmjenaGosta.Size = new System.Drawing.Size(111, 62);
            this.btnIzmjenaGosta.TabIndex = 2;
            this.btnIzmjenaGosta.Text = "Izmjeni";
            this.btnIzmjenaGosta.UseVisualStyleBackColor = true;
            this.btnIzmjenaGosta.Click += new System.EventHandler(this.btnIzmjenaGosta_Click);
            // 
            // btnIzbrisiGosta
            // 
            this.btnIzbrisiGosta.Location = new System.Drawing.Point(686, 362);
            this.btnIzbrisiGosta.Name = "btnIzbrisiGosta";
            this.btnIzbrisiGosta.Size = new System.Drawing.Size(111, 62);
            this.btnIzbrisiGosta.TabIndex = 3;
            this.btnIzbrisiGosta.Text = "Izbriši gosta";
            this.btnIzbrisiGosta.UseVisualStyleBackColor = true;
            this.btnIzbrisiGosta.Click += new System.EventHandler(this.btnIzbrisiGosta_Click);
            // 
            // dgvGosti
            // 
            this.dgvGosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGosti.Location = new System.Drawing.Point(24, 50);
            this.dgvGosti.Name = "dgvGosti";
            this.dgvGosti.RowHeadersWidth = 51;
            this.dgvGosti.RowTemplate.Height = 24;
            this.dgvGosti.Size = new System.Drawing.Size(764, 306);
            this.dgvGosti.TabIndex = 4;
            // 
            // btnOsvjeziGoste
            // 
            this.btnOsvjeziGoste.Location = new System.Drawing.Point(686, 12);
            this.btnOsvjeziGoste.Name = "btnOsvjeziGoste";
            this.btnOsvjeziGoste.Size = new System.Drawing.Size(100, 26);
            this.btnOsvjeziGoste.TabIndex = 5;
            this.btnOsvjeziGoste.Text = "Osvježi";
            this.btnOsvjeziGoste.UseVisualStyleBackColor = true;
            this.btnOsvjeziGoste.Click += new System.EventHandler(this.btnOsvjeziGoste_Click);
            // 
            // tbPrezimeGosta
            // 
            this.tbPrezimeGosta.Location = new System.Drawing.Point(470, 22);
            this.tbPrezimeGosta.Name = "tbPrezimeGosta";
            this.tbPrezimeGosta.Size = new System.Drawing.Size(100, 22);
            this.tbPrezimeGosta.TabIndex = 6;
            this.tbPrezimeGosta.TextChanged += new System.EventHandler(this.tbPrezimeGosta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pretraga po prezimenu:";
            // 
            // GostiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrezimeGosta);
            this.Controls.Add(this.btnOsvjeziGoste);
            this.Controls.Add(this.dgvGosti);
            this.Controls.Add(this.btnIzbrisiGosta);
            this.Controls.Add(this.btnIzmjenaGosta);
            this.Controls.Add(this.btnDodajGosta);
            this.Name = "GostiForma";
            this.Text = "GostiForma";
            this.Load += new System.EventHandler(this.GostiForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajGosta;
        private System.Windows.Forms.Button btnIzmjenaGosta;
        private System.Windows.Forms.Button btnIzbrisiGosta;
        private System.Windows.Forms.DataGridView dgvGosti;
        private System.Windows.Forms.Button btnOsvjeziGoste;
        private System.Windows.Forms.TextBox tbPrezimeGosta;
        private System.Windows.Forms.Label label1;
    }
}