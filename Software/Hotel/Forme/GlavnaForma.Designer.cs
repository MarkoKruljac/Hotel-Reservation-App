namespace Hotel
{
    partial class GlavnaForma
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
            this.zaposlenici_btn = new System.Windows.Forms.Button();
            this.racun_btn = new System.Windows.Forms.Button();
            this.rezervacije_btn = new System.Windows.Forms.Button();
            this.dobavljaci_btn = new System.Windows.Forms.Button();
            this.dnevniPlan_btn = new System.Windows.Forms.Button();
            this.pomoc_btn = new System.Windows.Forms.Button();
            this.odjava_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zaposlenici_btn
            // 
            this.zaposlenici_btn.Location = new System.Drawing.Point(456, 248);
            this.zaposlenici_btn.Name = "zaposlenici_btn";
            this.zaposlenici_btn.Size = new System.Drawing.Size(100, 50);
            this.zaposlenici_btn.TabIndex = 0;
            this.zaposlenici_btn.Text = "Zaposlenici";
            this.zaposlenici_btn.UseVisualStyleBackColor = true;
            this.zaposlenici_btn.Click += new System.EventHandler(this.zaposlenici_btn_Click);
            // 
            // racun_btn
            // 
            this.racun_btn.Location = new System.Drawing.Point(182, 248);
            this.racun_btn.Name = "racun_btn";
            this.racun_btn.Size = new System.Drawing.Size(100, 50);
            this.racun_btn.TabIndex = 1;
            this.racun_btn.Text = "Račun";
            this.racun_btn.UseVisualStyleBackColor = true;
            this.racun_btn.Click += new System.EventHandler(this.racun_btn_Click);
            // 
            // rezervacije_btn
            // 
            this.rezervacije_btn.Location = new System.Drawing.Point(324, 248);
            this.rezervacije_btn.Name = "rezervacije_btn";
            this.rezervacije_btn.Size = new System.Drawing.Size(100, 50);
            this.rezervacije_btn.TabIndex = 2;
            this.rezervacije_btn.Text = "Rezervacije";
            this.rezervacije_btn.UseVisualStyleBackColor = true;
            this.rezervacije_btn.Click += new System.EventHandler(this.rezervacije_btn_Click);
            // 
            // dobavljaci_btn
            // 
            this.dobavljaci_btn.Location = new System.Drawing.Point(397, 147);
            this.dobavljaci_btn.Name = "dobavljaci_btn";
            this.dobavljaci_btn.Size = new System.Drawing.Size(100, 50);
            this.dobavljaci_btn.TabIndex = 3;
            this.dobavljaci_btn.Text = "Dobavljači";
            this.dobavljaci_btn.UseVisualStyleBackColor = true;
            this.dobavljaci_btn.Click += new System.EventHandler(this.dobavljaci_btn_Click);
            // 
            // dnevniPlan_btn
            // 
            this.dnevniPlan_btn.Location = new System.Drawing.Point(246, 147);
            this.dnevniPlan_btn.Name = "dnevniPlan_btn";
            this.dnevniPlan_btn.Size = new System.Drawing.Size(100, 50);
            this.dnevniPlan_btn.TabIndex = 4;
            this.dnevniPlan_btn.Text = "Dnevni plan";
            this.dnevniPlan_btn.UseVisualStyleBackColor = true;
            this.dnevniPlan_btn.Click += new System.EventHandler(this.dnevniPlan_btn_Click);
            // 
            // pomoc_btn
            // 
            this.pomoc_btn.Location = new System.Drawing.Point(633, 23);
            this.pomoc_btn.Name = "pomoc_btn";
            this.pomoc_btn.Size = new System.Drawing.Size(75, 40);
            this.pomoc_btn.TabIndex = 5;
            this.pomoc_btn.Text = "Pomoć";
            this.pomoc_btn.UseVisualStyleBackColor = true;
            this.pomoc_btn.Click += new System.EventHandler(this.pomoc_btn_Click);
            // 
            // odjava_btn
            // 
            this.odjava_btn.Location = new System.Drawing.Point(714, 23);
            this.odjava_btn.Name = "odjava_btn";
            this.odjava_btn.Size = new System.Drawing.Size(75, 40);
            this.odjava_btn.TabIndex = 6;
            this.odjava_btn.Text = "Odjava";
            this.odjava_btn.UseVisualStyleBackColor = true;
            this.odjava_btn.Click += new System.EventHandler(this.odjava_btn_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odjava_btn);
            this.Controls.Add(this.pomoc_btn);
            this.Controls.Add(this.dnevniPlan_btn);
            this.Controls.Add(this.dobavljaci_btn);
            this.Controls.Add(this.rezervacije_btn);
            this.Controls.Add(this.racun_btn);
            this.Controls.Add(this.zaposlenici_btn);
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zaposlenici_btn;
        private System.Windows.Forms.Button racun_btn;
        private System.Windows.Forms.Button rezervacije_btn;
        private System.Windows.Forms.Button dobavljaci_btn;
        private System.Windows.Forms.Button dnevniPlan_btn;
        private System.Windows.Forms.Button pomoc_btn;
        private System.Windows.Forms.Button odjava_btn;
    }
}