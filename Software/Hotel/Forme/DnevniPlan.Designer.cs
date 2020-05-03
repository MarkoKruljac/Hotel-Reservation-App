namespace Hotel
{
    partial class DnevniPlan
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
            this.zatvori_btn = new System.Windows.Forms.Button();
            this.dnevniPlan_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dnevniPlan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // zatvori_btn
            // 
            this.zatvori_btn.Location = new System.Drawing.Point(713, 12);
            this.zatvori_btn.Name = "zatvori_btn";
            this.zatvori_btn.Size = new System.Drawing.Size(75, 40);
            this.zatvori_btn.TabIndex = 6;
            this.zatvori_btn.Text = "Zatvori";
            this.zatvori_btn.UseVisualStyleBackColor = true;
            // 
            // dnevniPlan_dgv
            // 
            this.dnevniPlan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dnevniPlan_dgv.Location = new System.Drawing.Point(12, 59);
            this.dnevniPlan_dgv.Name = "dnevniPlan_dgv";
            this.dnevniPlan_dgv.Size = new System.Drawing.Size(776, 379);
            this.dnevniPlan_dgv.TabIndex = 7;
            this.dnevniPlan_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dnevniPlan_dgv_CellContentClick);
            // 
            // DnevniPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dnevniPlan_dgv);
            this.Controls.Add(this.zatvori_btn);
            this.Name = "DnevniPlan";
            this.Text = "DnevniPlan";
            ((System.ComponentModel.ISupportInitialize)(this.dnevniPlan_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zatvori_btn;
        private System.Windows.Forms.DataGridView dnevniPlan_dgv;
    }
}