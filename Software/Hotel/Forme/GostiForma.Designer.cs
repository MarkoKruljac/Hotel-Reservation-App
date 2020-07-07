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
            this.dgvGosti = new System.Windows.Forms.DataGridView();
            this.btnOsvjeziGoste = new System.Windows.Forms.Button();
            this.tbPrezimeGosta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzbrisiGosta = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajGosta
            // 
            this.btnDodajGosta.BackColor = System.Drawing.Color.OliveDrab;
            this.btnDodajGosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajGosta.ForeColor = System.Drawing.Color.White;
            this.btnDodajGosta.Location = new System.Drawing.Point(406, 338);
            this.btnDodajGosta.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajGosta.Name = "btnDodajGosta";
            this.btnDodajGosta.Size = new System.Drawing.Size(125, 50);
            this.btnDodajGosta.TabIndex = 1;
            this.btnDodajGosta.Text = "Dodaj ";
            this.btnDodajGosta.UseVisualStyleBackColor = false;
            this.btnDodajGosta.Click += new System.EventHandler(this.btnDodajGosta_Click);
            // 
            // btnIzmjenaGosta
            // 
            this.btnIzmjenaGosta.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIzmjenaGosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmjenaGosta.ForeColor = System.Drawing.Color.White;
            this.btnIzmjenaGosta.Location = new System.Drawing.Point(277, 338);
            this.btnIzmjenaGosta.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzmjenaGosta.Name = "btnIzmjenaGosta";
            this.btnIzmjenaGosta.Size = new System.Drawing.Size(125, 50);
            this.btnIzmjenaGosta.TabIndex = 2;
            this.btnIzmjenaGosta.Text = "Izmijeni";
            this.btnIzmjenaGosta.UseVisualStyleBackColor = false;
            this.btnIzmjenaGosta.Click += new System.EventHandler(this.btnIzmjenaGosta_Click);
            // 
            // dgvGosti
            // 
            this.dgvGosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGosti.Location = new System.Drawing.Point(11, 51);
            this.dgvGosti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGosti.Name = "dgvGosti";
            this.dgvGosti.RowHeadersWidth = 51;
            this.dgvGosti.RowTemplate.Height = 24;
            this.dgvGosti.Size = new System.Drawing.Size(659, 283);
            this.dgvGosti.TabIndex = 4;
            // 
            // btnOsvjeziGoste
            // 
            this.btnOsvjeziGoste.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOsvjeziGoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOsvjeziGoste.ForeColor = System.Drawing.Color.White;
            this.btnOsvjeziGoste.Location = new System.Drawing.Point(590, 7);
            this.btnOsvjeziGoste.Margin = new System.Windows.Forms.Padding(2);
            this.btnOsvjeziGoste.Name = "btnOsvjeziGoste";
            this.btnOsvjeziGoste.Size = new System.Drawing.Size(80, 40);
            this.btnOsvjeziGoste.TabIndex = 5;
            this.btnOsvjeziGoste.Text = "Osvježi";
            this.btnOsvjeziGoste.UseVisualStyleBackColor = false;
            this.btnOsvjeziGoste.Click += new System.EventHandler(this.btnOsvjeziGoste_Click);
            // 
            // tbPrezimeGosta
            // 
            this.tbPrezimeGosta.Location = new System.Drawing.Point(406, 19);
            this.tbPrezimeGosta.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrezimeGosta.Name = "tbPrezimeGosta";
            this.tbPrezimeGosta.Size = new System.Drawing.Size(155, 20);
            this.tbPrezimeGosta.TabIndex = 6;
            this.tbPrezimeGosta.TextChanged += new System.EventHandler(this.tbPrezimeGosta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(206, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pretraga po prezimenu:";
            // 
            // btnIzbrisiGosta
            // 
            this.btnIzbrisiGosta.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIzbrisiGosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiGosta.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiGosta.Location = new System.Drawing.Point(535, 338);
            this.btnIzbrisiGosta.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzbrisiGosta.Name = "btnIzbrisiGosta";
            this.btnIzbrisiGosta.Size = new System.Drawing.Size(125, 50);
            this.btnIzbrisiGosta.TabIndex = 3;
            this.btnIzbrisiGosta.Text = "Izbriši ";
            this.btnIzbrisiGosta.UseVisualStyleBackColor = false;
            this.btnIzbrisiGosta.Click += new System.EventHandler(this.btnIzbrisiGosta_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(18, 304);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 8;
            // 
            // GostiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 410);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrezimeGosta);
            this.Controls.Add(this.btnOsvjeziGoste);
            this.Controls.Add(this.dgvGosti);
            this.Controls.Add(this.btnIzbrisiGosta);
            this.Controls.Add(this.btnIzmjenaGosta);
            this.Controls.Add(this.btnDodajGosta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GostiForma";
            this.Load += new System.EventHandler(this.GostiForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajGosta;
        private System.Windows.Forms.Button btnIzmjenaGosta;
        private System.Windows.Forms.DataGridView dgvGosti;
        private System.Windows.Forms.Button btnOsvjeziGoste;
        private System.Windows.Forms.TextBox tbPrezimeGosta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzbrisiGosta;
        private System.Windows.Forms.Label lblError;
    }
}