namespace Staj
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciGirisi = new System.Windows.Forms.Button();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.girisSifre = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // kullaniciGirisi
            // 
            this.kullaniciGirisi.Location = new System.Drawing.Point(104, 167);
            this.kullaniciGirisi.Name = "kullaniciGirisi";
            this.kullaniciGirisi.Size = new System.Drawing.Size(356, 65);
            this.kullaniciGirisi.TabIndex = 2;
            this.kullaniciGirisi.Text = "Giriş Yap";
            this.kullaniciGirisi.UseVisualStyleBackColor = true;
            this.kullaniciGirisi.Click += new System.EventHandler(this.kullaniciGirisi_Click);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(277, 59);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(183, 30);
            this.kullaniciAdi.TabIndex = 3;
            // 
            // girisSifre
            // 
            this.girisSifre.Location = new System.Drawing.Point(277, 113);
            this.girisSifre.Name = "girisSifre";
            this.girisSifre.Size = new System.Drawing.Size(183, 30);
            this.girisSifre.TabIndex = 5;
            this.girisSifre.UseSystemPasswordChar = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(500, 302);
            this.Controls.Add(this.girisSifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.kullaniciGirisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Kullanıcı Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kullaniciGirisi;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.MaskedTextBox girisSifre;
    }
}