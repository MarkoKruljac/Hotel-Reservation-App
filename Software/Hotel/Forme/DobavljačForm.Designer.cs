namespace Hotel
{
    partial class DobavljačForm
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
            this.dobavljaci_dtg = new System.Windows.Forms.DataGridView();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.izmijeni_btn = new System.Windows.Forms.Button();
            this.izbriši_btn = new System.Windows.Forms.Button();
            this.dobavljač_lbl = new System.Windows.Forms.Label();
            this.btnOsvjeziDobavljace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaci_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // dobavljaci_dtg
            // 
            this.dobavljaci_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dobavljaci_dtg.Location = new System.Drawing.Point(12, 55);
            this.dobavljaci_dtg.Name = "dobavljaci_dtg";
            this.dobavljaci_dtg.RowHeadersWidth = 51;
            this.dobavljaci_dtg.Size = new System.Drawing.Size(602, 409);
            this.dobavljaci_dtg.TabIndex = 0;
            this.dobavljaci_dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dobavljaci_dgv_CellContentClick);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(377, 470);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(75, 40);
            this.dodaj_btn.TabIndex = 1;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // izmijeni_btn
            // 
            this.izmijeni_btn.Location = new System.Drawing.Point(458, 470);
            this.izmijeni_btn.Name = "izmijeni_btn";
            this.izmijeni_btn.Size = new System.Drawing.Size(75, 40);
            this.izmijeni_btn.TabIndex = 2;
            this.izmijeni_btn.Text = "Izmijeni";
            this.izmijeni_btn.UseVisualStyleBackColor = true;
            this.izmijeni_btn.Click += new System.EventHandler(this.izmijeni_btn_Click);
            // 
            // izbriši_btn
            // 
            this.izbriši_btn.Location = new System.Drawing.Point(539, 470);
            this.izbriši_btn.Name = "izbriši_btn";
            this.izbriši_btn.Size = new System.Drawing.Size(75, 40);
            this.izbriši_btn.TabIndex = 3;
            this.izbriši_btn.Text = "Izbriši";
            this.izbriši_btn.UseVisualStyleBackColor = true;
            this.izbriši_btn.Click += new System.EventHandler(this.izbriši_btn_Click);
            // 
            // dobavljač_lbl
            // 
            this.dobavljač_lbl.AutoSize = true;
            this.dobavljač_lbl.Location = new System.Drawing.Point(12, 36);
            this.dobavljač_lbl.Name = "dobavljač_lbl";
            this.dobavljač_lbl.Size = new System.Drawing.Size(91, 13);
            this.dobavljač_lbl.TabIndex = 5;
            this.dobavljač_lbl.Text = "Popis dobavljača:";
            this.dobavljač_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOsvjeziDobavljace
            // 
            this.btnOsvjeziDobavljace.Location = new System.Drawing.Point(503, 17);
            this.btnOsvjeziDobavljace.Name = "btnOsvjeziDobavljace";
            this.btnOsvjeziDobavljace.Size = new System.Drawing.Size(70, 32);
            this.btnOsvjeziDobavljace.TabIndex = 6;
            this.btnOsvjeziDobavljace.Text = "Osvjezi";
            this.btnOsvjeziDobavljace.UseVisualStyleBackColor = true;
            this.btnOsvjeziDobavljace.Click += new System.EventHandler(this.btnOsvjeziDobavljace_Click);
            // 
            // DobavljačForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 539);
            this.Controls.Add(this.btnOsvjeziDobavljace);
            this.Controls.Add(this.dobavljač_lbl);
            this.Controls.Add(this.izbriši_btn);
            this.Controls.Add(this.izmijeni_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.dobavljaci_dtg);
            this.Name = "DobavljačForm";
            this.Text = "Dobavljač";
            this.Load += new System.EventHandler(this.Dobavljači_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaci_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dobavljaci_dtg;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button izmijeni_btn;
        private System.Windows.Forms.Button izbriši_btn;
        private System.Windows.Forms.Label dobavljač_lbl;
        private System.Windows.Forms.Button btnOsvjeziDobavljace;
    }
}

