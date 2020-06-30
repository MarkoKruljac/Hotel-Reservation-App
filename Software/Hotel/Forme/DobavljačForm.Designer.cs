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
            this.dobavljaci_dtg.Location = new System.Drawing.Point(16, 68);
            this.dobavljaci_dtg.Margin = new System.Windows.Forms.Padding(4);
            this.dobavljaci_dtg.Name = "dobavljaci_dtg";
            this.dobavljaci_dtg.RowHeadersWidth = 51;
            this.dobavljaci_dtg.Size = new System.Drawing.Size(803, 503);
            this.dobavljaci_dtg.TabIndex = 0;
            this.dobavljaci_dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dobavljaci_dgv_CellContentClick);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.dodaj_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj_btn.ForeColor = System.Drawing.Color.White;
            this.dodaj_btn.Location = new System.Drawing.Point(503, 578);
            this.dodaj_btn.Margin = new System.Windows.Forms.Padding(4);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(100, 49);
            this.dodaj_btn.TabIndex = 1;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = false;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // izmijeni_btn
            // 
            this.izmijeni_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.izmijeni_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izmijeni_btn.ForeColor = System.Drawing.Color.White;
            this.izmijeni_btn.Location = new System.Drawing.Point(611, 578);
            this.izmijeni_btn.Margin = new System.Windows.Forms.Padding(4);
            this.izmijeni_btn.Name = "izmijeni_btn";
            this.izmijeni_btn.Size = new System.Drawing.Size(100, 49);
            this.izmijeni_btn.TabIndex = 2;
            this.izmijeni_btn.Text = "Izmijeni";
            this.izmijeni_btn.UseVisualStyleBackColor = false;
            this.izmijeni_btn.Click += new System.EventHandler(this.izmijeni_btn_Click);
            // 
            // izbriši_btn
            // 
            this.izbriši_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.izbriši_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izbriši_btn.ForeColor = System.Drawing.Color.White;
            this.izbriši_btn.Location = new System.Drawing.Point(719, 578);
            this.izbriši_btn.Margin = new System.Windows.Forms.Padding(4);
            this.izbriši_btn.Name = "izbriši_btn";
            this.izbriši_btn.Size = new System.Drawing.Size(100, 49);
            this.izbriši_btn.TabIndex = 3;
            this.izbriši_btn.Text = "Izbriši";
            this.izbriši_btn.UseVisualStyleBackColor = false;
            this.izbriši_btn.Click += new System.EventHandler(this.izbriši_btn_Click);
            // 
            // dobavljač_lbl
            // 
            this.dobavljač_lbl.AutoSize = true;
            this.dobavljač_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dobavljač_lbl.ForeColor = System.Drawing.Color.OliveDrab;
            this.dobavljač_lbl.Location = new System.Drawing.Point(16, 44);
            this.dobavljač_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobavljač_lbl.Name = "dobavljač_lbl";
            this.dobavljač_lbl.Size = new System.Drawing.Size(157, 20);
            this.dobavljač_lbl.TabIndex = 5;
            this.dobavljač_lbl.Text = "Popis dobavljača:";
            this.dobavljač_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOsvjeziDobavljace
            // 
            this.btnOsvjeziDobavljace.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOsvjeziDobavljace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOsvjeziDobavljace.ForeColor = System.Drawing.Color.White;
            this.btnOsvjeziDobavljace.Location = new System.Drawing.Point(671, 21);
            this.btnOsvjeziDobavljace.Margin = new System.Windows.Forms.Padding(4);
            this.btnOsvjeziDobavljace.Name = "btnOsvjeziDobavljace";
            this.btnOsvjeziDobavljace.Size = new System.Drawing.Size(93, 39);
            this.btnOsvjeziDobavljace.TabIndex = 6;
            this.btnOsvjeziDobavljace.Text = "Osvjezi";
            this.btnOsvjeziDobavljace.UseVisualStyleBackColor = false;
            this.btnOsvjeziDobavljace.Click += new System.EventHandler(this.btnOsvjeziDobavljace_Click);
            // 
            // DobavljačForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 663);
            this.Controls.Add(this.btnOsvjeziDobavljace);
            this.Controls.Add(this.dobavljač_lbl);
            this.Controls.Add(this.izbriši_btn);
            this.Controls.Add(this.izmijeni_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.dobavljaci_dtg);
            this.Margin = new System.Windows.Forms.Padding(4);
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

