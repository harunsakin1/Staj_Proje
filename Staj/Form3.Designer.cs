namespace Staj
{
    partial class Form3
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
            this.menuKullaniciEkle = new System.Windows.Forms.Button();
            this.menuMalzeme = new System.Windows.Forms.Button();
            this.menuStok = new System.Windows.Forms.Button();
            this.menuRolEkle = new System.Windows.Forms.Button();
            this.menuSiparisVer = new System.Windows.Forms.Button();
            this.menuSiparisDurumu = new System.Windows.Forms.Button();
            this.menuMutfak = new System.Windows.Forms.Button();
            this.menuKurye = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuKullaniciEkle
            // 
            this.menuKullaniciEkle.Location = new System.Drawing.Point(31, 27);
            this.menuKullaniciEkle.Name = "menuKullaniciEkle";
            this.menuKullaniciEkle.Size = new System.Drawing.Size(104, 77);
            this.menuKullaniciEkle.TabIndex = 0;
            this.menuKullaniciEkle.Text = "Kullanıcı Ekle";
            this.menuKullaniciEkle.UseVisualStyleBackColor = true;
            this.menuKullaniciEkle.Click += new System.EventHandler(this.menuKullaniciEkle_Click);
            // 
            // menuMalzeme
            // 
            this.menuMalzeme.Location = new System.Drawing.Point(215, 27);
            this.menuMalzeme.Name = "menuMalzeme";
            this.menuMalzeme.Size = new System.Drawing.Size(104, 77);
            this.menuMalzeme.TabIndex = 1;
            this.menuMalzeme.Text = "Malzeme Menüsü";
            this.menuMalzeme.UseVisualStyleBackColor = true;
            this.menuMalzeme.Click += new System.EventHandler(this.menuMalzeme_Click);
            // 
            // menuStok
            // 
            this.menuStok.Location = new System.Drawing.Point(215, 144);
            this.menuStok.Name = "menuStok";
            this.menuStok.Size = new System.Drawing.Size(104, 77);
            this.menuStok.TabIndex = 2;
            this.menuStok.Text = "Stok Menüsü";
            this.menuStok.UseVisualStyleBackColor = true;
            this.menuStok.Click += new System.EventHandler(this.menuStok_Click);
            // 
            // menuRolEkle
            // 
            this.menuRolEkle.Location = new System.Drawing.Point(31, 144);
            this.menuRolEkle.Name = "menuRolEkle";
            this.menuRolEkle.Size = new System.Drawing.Size(104, 77);
            this.menuRolEkle.TabIndex = 3;
            this.menuRolEkle.Text = "Rol Ekle";
            this.menuRolEkle.UseVisualStyleBackColor = true;
            this.menuRolEkle.Click += new System.EventHandler(this.menuRolEkle_Click);
            // 
            // menuSiparisVer
            // 
            this.menuSiparisVer.Location = new System.Drawing.Point(31, 244);
            this.menuSiparisVer.Name = "menuSiparisVer";
            this.menuSiparisVer.Size = new System.Drawing.Size(104, 77);
            this.menuSiparisVer.TabIndex = 4;
            this.menuSiparisVer.Text = "Sipariş Ver";
            this.menuSiparisVer.UseVisualStyleBackColor = true;
            this.menuSiparisVer.Click += new System.EventHandler(this.siparisVer_Click);
            // 
            // menuSiparisDurumu
            // 
            this.menuSiparisDurumu.Location = new System.Drawing.Point(204, 244);
            this.menuSiparisDurumu.Name = "menuSiparisDurumu";
            this.menuSiparisDurumu.Size = new System.Drawing.Size(115, 83);
            this.menuSiparisDurumu.TabIndex = 5;
            this.menuSiparisDurumu.Text = "Sipariş Durumunu Gör";
            this.menuSiparisDurumu.UseVisualStyleBackColor = true;
            this.menuSiparisDurumu.Click += new System.EventHandler(this.menuSiparisDurumu_Click);
            // 
            // menuMutfak
            // 
            this.menuMutfak.Location = new System.Drawing.Point(31, 352);
            this.menuMutfak.Name = "menuMutfak";
            this.menuMutfak.Size = new System.Drawing.Size(104, 77);
            this.menuMutfak.TabIndex = 6;
            this.menuMutfak.Text = "Mutfak";
            this.menuMutfak.UseVisualStyleBackColor = true;
            this.menuMutfak.Click += new System.EventHandler(this.menuMutfak_Click);
            // 
            // menuKurye
            // 
            this.menuKurye.Location = new System.Drawing.Point(215, 352);
            this.menuKurye.Name = "menuKurye";
            this.menuKurye.Size = new System.Drawing.Size(104, 77);
            this.menuKurye.TabIndex = 7;
            this.menuKurye.Text = "Kurye";
            this.menuKurye.UseVisualStyleBackColor = true;
            this.menuKurye.Click += new System.EventHandler(this.menuKurye_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(77, 458);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(195, 39);
            this.cikis.TabIndex = 8;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(360, 509);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.menuKurye);
            this.Controls.Add(this.menuMutfak);
            this.Controls.Add(this.menuSiparisDurumu);
            this.Controls.Add(this.menuSiparisVer);
            this.Controls.Add(this.menuRolEkle);
            this.Controls.Add(this.menuStok);
            this.Controls.Add(this.menuMalzeme);
            this.Controls.Add(this.menuKullaniciEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuKullaniciEkle;
        private System.Windows.Forms.Button menuMalzeme;
        private System.Windows.Forms.Button menuStok;
        private System.Windows.Forms.Button menuRolEkle;
        private System.Windows.Forms.Button menuSiparisVer;
        private System.Windows.Forms.Button menuSiparisDurumu;
        private System.Windows.Forms.Button menuMutfak;
        private System.Windows.Forms.Button menuKurye;
        private System.Windows.Forms.Button cikis;
    }
}