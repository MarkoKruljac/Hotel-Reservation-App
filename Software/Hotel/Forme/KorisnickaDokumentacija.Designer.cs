namespace Hotel
{
    partial class KorisnickaDokumentacija
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
            this.korisnickaDokumentacija_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zatvori_btn
            // 
            this.zatvori_btn.Location = new System.Drawing.Point(713, 12);
            this.zatvori_btn.Name = "zatvori_btn";
            this.zatvori_btn.Size = new System.Drawing.Size(75, 40);
            this.zatvori_btn.TabIndex = 0;
            this.zatvori_btn.Text = "Zatvori";
            this.zatvori_btn.UseVisualStyleBackColor = true;
            this.zatvori_btn.Click += new System.EventHandler(this.zatvori_btn_Click);
            // 
            // korisnickaDokumentacija_txt
            // 
            this.korisnickaDokumentacija_txt.Location = new System.Drawing.Point(12, 58);
            this.korisnickaDokumentacija_txt.Multiline = true;
            this.korisnickaDokumentacija_txt.Name = "korisnickaDokumentacija_txt";
            this.korisnickaDokumentacija_txt.Size = new System.Drawing.Size(776, 384);
            this.korisnickaDokumentacija_txt.TabIndex = 1;
            this.korisnickaDokumentacija_txt.TextChanged += new System.EventHandler(this.korisnickaDokumentacija_txt_TextChanged);
            // 
            // KorisnickaDokumentacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.korisnickaDokumentacija_txt);
            this.Controls.Add(this.zatvori_btn);
            this.Name = "KorisnickaDokumentacija";
            this.Text = "KorisnickaDokumentacija";
            this.Load += new System.EventHandler(this.KorisnickaDokumentacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zatvori_btn;
        private System.Windows.Forms.TextBox korisnickaDokumentacija_txt;
    }
}