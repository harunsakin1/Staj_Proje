namespace Staj
{
    partial class Form6
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
            this.malzemeGor = new System.Windows.Forms.CheckBox();
            this.stokGor = new System.Windows.Forms.CheckBox();
            this.yeniKullaniciEkle = new System.Windows.Forms.CheckBox();
            this.yetkiAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yetkiEkle = new System.Windows.Forms.Button();
            this.rolEkle = new System.Windows.Forms.CheckBox();
            this.siparisVer = new System.Windows.Forms.CheckBox();
            this.siparisDurumu = new System.Windows.Forms.CheckBox();
            this.Mutfak = new System.Windows.Forms.CheckBox();
            this.Kurye = new System.Windows.Forms.CheckBox();
            this.menuyeDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // malzemeGor
            // 
            this.malzemeGor.AutoSize = true;
            this.malzemeGor.Location = new System.Drawing.Point(84, 126);
            this.malzemeGor.Name = "malzemeGor";
            this.malzemeGor.Size = new System.Drawing.Size(151, 29);
            this.malzemeGor.TabIndex = 0;
            this.malzemeGor.Text = "Malzeme Gör";
            this.malzemeGor.UseVisualStyleBackColor = true;
            // 
            // stokGor
            // 
            this.stokGor.AutoSize = true;
            this.stokGor.Location = new System.Drawing.Point(341, 186);
            this.stokGor.Name = "stokGor";
            this.stokGor.Size = new System.Drawing.Size(111, 29);
            this.stokGor.TabIndex = 1;
            this.stokGor.Text = "Stok Gör";
            this.stokGor.UseVisualStyleBackColor = true;
            // 
            // yeniKullaniciEkle
            // 
            this.yeniKullaniciEkle.AutoSize = true;
            this.yeniKullaniciEkle.Location = new System.Drawing.Point(84, 186);
            this.yeniKullaniciEkle.Name = "yeniKullaniciEkle";
            this.yeniKullaniciEkle.Size = new System.Drawing.Size(194, 29);
            this.yeniKullaniciEkle.TabIndex = 2;
            this.yeniKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.yeniKullaniciEkle.UseVisualStyleBackColor = true;
            // 
            // yetkiAdi
            // 
            this.yetkiAdi.Location = new System.Drawing.Point(242, 63);
            this.yetkiAdi.Name = "yetkiAdi";
            this.yetkiAdi.Size = new System.Drawing.Size(131, 30);
            this.yetkiAdi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yetki Adı :";
            // 
            // yetkiEkle
            // 
            this.yetkiEkle.Location = new System.Drawing.Point(175, 335);
            this.yetkiEkle.Name = "yetkiEkle";
            this.yetkiEkle.Size = new System.Drawing.Size(187, 54);
            this.yetkiEkle.TabIndex = 6;
            this.yetkiEkle.Text = "EKLE";
            this.yetkiEkle.UseVisualStyleBackColor = true;
            this.yetkiEkle.Click += new System.EventHandler(this.yetkiEkle_Click);
            // 
            // rolEkle
            // 
            this.rolEkle.AutoSize = true;
            this.rolEkle.Location = new System.Drawing.Point(341, 126);
            this.rolEkle.Name = "rolEkle";
            this.rolEkle.Size = new System.Drawing.Size(105, 29);
            this.rolEkle.TabIndex = 7;
            this.rolEkle.Text = "Rol Ekle";
            this.rolEkle.UseVisualStyleBackColor = true;
            // 
            // siparisVer
            // 
            this.siparisVer.AutoSize = true;
            this.siparisVer.Location = new System.Drawing.Point(84, 235);
            this.siparisVer.Name = "siparisVer";
            this.siparisVer.Size = new System.Drawing.Size(130, 29);
            this.siparisVer.TabIndex = 8;
            this.siparisVer.Text = "Sipariş Ver";
            this.siparisVer.UseVisualStyleBackColor = true;
            // 
            // siparisDurumu
            // 
            this.siparisDurumu.AutoSize = true;
            this.siparisDurumu.Location = new System.Drawing.Point(341, 235);
            this.siparisDurumu.Name = "siparisDurumu";
            this.siparisDurumu.Size = new System.Drawing.Size(168, 29);
            this.siparisDurumu.TabIndex = 9;
            this.siparisDurumu.Text = "Sipariş Durumu";
            this.siparisDurumu.UseVisualStyleBackColor = true;
            // 
            // Mutfak
            // 
            this.Mutfak.AutoSize = true;
            this.Mutfak.Location = new System.Drawing.Point(84, 283);
            this.Mutfak.Name = "Mutfak";
            this.Mutfak.Size = new System.Drawing.Size(93, 29);
            this.Mutfak.TabIndex = 10;
            this.Mutfak.Text = "Mutfak";
            this.Mutfak.UseVisualStyleBackColor = true;
            // 
            // Kurye
            // 
            this.Kurye.AutoSize = true;
            this.Kurye.Location = new System.Drawing.Point(341, 283);
            this.Kurye.Name = "Kurye";
            this.Kurye.Size = new System.Drawing.Size(86, 29);
            this.Kurye.TabIndex = 11;
            this.Kurye.Text = "Kurye";
            this.Kurye.UseVisualStyleBackColor = true;
            // 
            // menuyeDon
            // 
            this.menuyeDon.Location = new System.Drawing.Point(12, 12);
            this.menuyeDon.Name = "menuyeDon";
            this.menuyeDon.Size = new System.Drawing.Size(106, 29);
            this.menuyeDon.TabIndex = 12;
            this.menuyeDon.Text = "GERİ";
            this.menuyeDon.UseVisualStyleBackColor = true;
            this.menuyeDon.Click += new System.EventHandler(this.menuyeDon_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(524, 415);
            this.Controls.Add(this.menuyeDon);
            this.Controls.Add(this.Kurye);
            this.Controls.Add(this.Mutfak);
            this.Controls.Add(this.siparisDurumu);
            this.Controls.Add(this.siparisVer);
            this.Controls.Add(this.rolEkle);
            this.Controls.Add(this.yetkiEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yetkiAdi);
            this.Controls.Add(this.yeniKullaniciEkle);
            this.Controls.Add(this.stokGor);
            this.Controls.Add(this.malzemeGor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox malzemeGor;
        private System.Windows.Forms.CheckBox stokGor;
        private System.Windows.Forms.CheckBox yeniKullaniciEkle;
        private System.Windows.Forms.TextBox yetkiAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yetkiEkle;
        private System.Windows.Forms.CheckBox rolEkle;
        private System.Windows.Forms.CheckBox siparisVer;
        private System.Windows.Forms.CheckBox siparisDurumu;
        private System.Windows.Forms.CheckBox Mutfak;
        private System.Windows.Forms.CheckBox Kurye;
        private System.Windows.Forms.Button menuyeDon;
    }
}