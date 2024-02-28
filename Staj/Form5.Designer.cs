namespace Staj
{
    partial class Form5
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
            this.label3 = new System.Windows.Forms.Label();
            this.yeniKullaniciAdi = new System.Windows.Forms.TextBox();
            this.kullaniciRolu = new System.Windows.Forms.ComboBox();
            this.kullaniciEkle = new System.Windows.Forms.Button();
            this.menuyeDon = new System.Windows.Forms.Button();
            this.yeniKullaniciSifre = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Rolü :";
            // 
            // yeniKullaniciAdi
            // 
            this.yeniKullaniciAdi.Location = new System.Drawing.Point(285, 70);
            this.yeniKullaniciAdi.Name = "yeniKullaniciAdi";
            this.yeniKullaniciAdi.Size = new System.Drawing.Size(173, 30);
            this.yeniKullaniciAdi.TabIndex = 3;
            // 
            // kullaniciRolu
            // 
            this.kullaniciRolu.FormattingEnabled = true;
            this.kullaniciRolu.Location = new System.Drawing.Point(285, 179);
            this.kullaniciRolu.Name = "kullaniciRolu";
            this.kullaniciRolu.Size = new System.Drawing.Size(173, 33);
            this.kullaniciRolu.TabIndex = 5;
            this.kullaniciRolu.SelectedIndexChanged += new System.EventHandler(this.kullaniciRolu_SelectedIndexChanged);
            // 
            // kullaniciEkle
            // 
            this.kullaniciEkle.Location = new System.Drawing.Point(285, 238);
            this.kullaniciEkle.Name = "kullaniciEkle";
            this.kullaniciEkle.Size = new System.Drawing.Size(173, 65);
            this.kullaniciEkle.TabIndex = 6;
            this.kullaniciEkle.Text = "Kullanıcı Ekle";
            this.kullaniciEkle.UseVisualStyleBackColor = true;
            this.kullaniciEkle.Click += new System.EventHandler(this.kullaniciEkle_Click);
            // 
            // menuyeDon
            // 
            this.menuyeDon.Location = new System.Drawing.Point(12, 12);
            this.menuyeDon.Name = "menuyeDon";
            this.menuyeDon.Size = new System.Drawing.Size(113, 31);
            this.menuyeDon.TabIndex = 7;
            this.menuyeDon.Text = "GERİ";
            this.menuyeDon.UseVisualStyleBackColor = true;
            this.menuyeDon.Click += new System.EventHandler(this.menuyeDon_Click);
            // 
            // yeniKullaniciSifre
            // 
            this.yeniKullaniciSifre.Location = new System.Drawing.Point(285, 123);
            this.yeniKullaniciSifre.Name = "yeniKullaniciSifre";
            this.yeniKullaniciSifre.Size = new System.Drawing.Size(173, 30);
            this.yeniKullaniciSifre.TabIndex = 8;
            this.yeniKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(510, 332);
            this.Controls.Add(this.yeniKullaniciSifre);
            this.Controls.Add(this.menuyeDon);
            this.Controls.Add(this.kullaniciEkle);
            this.Controls.Add(this.kullaniciRolu);
            this.Controls.Add(this.yeniKullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Yeni Kullanıcı Kayıt";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yeniKullaniciAdi;
        private System.Windows.Forms.ComboBox kullaniciRolu;
        private System.Windows.Forms.Button kullaniciEkle;
        private System.Windows.Forms.Button menuyeDon;
        private System.Windows.Forms.MaskedTextBox yeniKullaniciSifre;
    }
}