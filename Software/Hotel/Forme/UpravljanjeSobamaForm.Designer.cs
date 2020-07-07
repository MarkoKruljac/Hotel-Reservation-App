namespace Hotel.Forme
{
    partial class UpravljanjeSobamaForm
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
            this.Sobe_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sobe_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Sobe_dgv
            // 
            this.Sobe_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sobe_dgv.Location = new System.Drawing.Point(35, 56);
            this.Sobe_dgv.Name = "Sobe_dgv";
            this.Sobe_dgv.Size = new System.Drawing.Size(710, 353);
            this.Sobe_dgv.TabIndex = 1;
            this.Sobe_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sobe_dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis soba:";
            // 
            // UpravljanjeSobamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.Sobe_dgv);
            this.Controls.Add(this.label1);
            this.Name = "UpravljanjeSobamaForm";
            this.Load += new System.EventHandler(this.UpravljanjeSobamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sobe_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Sobe_dgv;
        private System.Windows.Forms.Label label1;
    }
}