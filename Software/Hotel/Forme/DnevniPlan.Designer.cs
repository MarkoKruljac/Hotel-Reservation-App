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
            this.dnevniPlanUseljenje_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIseljenjeDnevniPlan = new System.Windows.Forms.DataGridView();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnObaviIseljenja = new System.Windows.Forms.Button();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dnevniPlanUseljenje_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIseljenjeDnevniPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // dnevniPlanUseljenje_dgv
            // 
            this.dnevniPlanUseljenje_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dnevniPlanUseljenje_dgv.Location = new System.Drawing.Point(13, 63);
            this.dnevniPlanUseljenje_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dnevniPlanUseljenje_dgv.Name = "dnevniPlanUseljenje_dgv";
            this.dnevniPlanUseljenje_dgv.RowHeadersWidth = 51;
            this.dnevniPlanUseljenje_dgv.Size = new System.Drawing.Size(1035, 183);
            this.dnevniPlanUseljenje_dgv.TabIndex = 7;
            this.dnevniPlanUseljenje_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dnevniPlan_dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danas useljavaju:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(25, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danas iseljavaju:";
            // 
            // dgvIseljenjeDnevniPlan
            // 
            this.dgvIseljenjeDnevniPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIseljenjeDnevniPlan.Location = new System.Drawing.Point(13, 295);
            this.dgvIseljenjeDnevniPlan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvIseljenjeDnevniPlan.Name = "dgvIseljenjeDnevniPlan";
            this.dgvIseljenjeDnevniPlan.RowHeadersWidth = 51;
            this.dgvIseljenjeDnevniPlan.Size = new System.Drawing.Size(1035, 183);
            this.dgvIseljenjeDnevniPlan.TabIndex = 9;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOsvjezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOsvjezi.ForeColor = System.Drawing.Color.White;
            this.btnOsvjezi.Location = new System.Drawing.Point(1117, 14);
            this.btnOsvjezi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(121, 30);
            this.btnOsvjezi.TabIndex = 12;
            this.btnOsvjezi.Text = "Osvjezi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnObaviIseljenja
            // 
            this.btnObaviIseljenja.BackColor = System.Drawing.Color.OliveDrab;
            this.btnObaviIseljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObaviIseljenja.ForeColor = System.Drawing.Color.White;
            this.btnObaviIseljenja.Location = new System.Drawing.Point(1068, 385);
            this.btnObaviIseljenja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObaviIseljenja.Name = "btnObaviIseljenja";
            this.btnObaviIseljenja.Size = new System.Drawing.Size(171, 50);
            this.btnObaviIseljenja.TabIndex = 13;
            this.btnObaviIseljenja.Text = "Obavljeno Iseljenje";
            this.btnObaviIseljenja.UseVisualStyleBackColor = false;
            this.btnObaviIseljenja.Click += new System.EventHandler(this.btnObaviIseljenja_Click);
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIzdajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzdajRacun.ForeColor = System.Drawing.Color.White;
            this.btnIzdajRacun.Location = new System.Drawing.Point(1056, 122);
            this.btnIzdajRacun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(125, 50);
            this.btnIzdajRacun.TabIndex = 14;
            this.btnIzdajRacun.Text = "Prikaži račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = false;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(16, 498);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 15;
            // 
            // DnevniPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1262, 553);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnIzdajRacun);
            this.Controls.Add(this.btnObaviIseljenja);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvIseljenjeDnevniPlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dnevniPlanUseljenje_dgv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DnevniPlan";
            this.Text = "DnevniPlan";
            this.Load += new System.EventHandler(this.DnevniPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dnevniPlanUseljenje_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIseljenjeDnevniPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dnevniPlanUseljenje_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIseljenjeDnevniPlan;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnObaviIseljenja;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.Label lblError;
    }
}