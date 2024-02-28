namespace Staj
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.malzemeAdi = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.malzemeFiyati = new System.Windows.Forms.Label();
            this.malzemeKategorisi = new System.Windows.Forms.Label();
            this.malzemeFiyat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.malzeme_ID = new System.Windows.Forms.Label();
            this.malzemeId = new System.Windows.Forms.TextBox();
            this.stok = new System.Windows.Forms.Button();
            this.malzemeKod = new System.Windows.Forms.Label();
            this.malzemeKodu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Guncelle = new System.Windows.Forms.Button();
            this.malzemeAd = new System.Windows.Forms.TextBox();
            this.kategoriSec = new System.Windows.Forms.ComboBox();
            this.menuyeDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // malzemeAdi
            // 
            this.malzemeAdi.AutoSize = true;
            this.malzemeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeAdi.Location = new System.Drawing.Point(38, 90);
            this.malzemeAdi.Name = "malzemeAdi";
            this.malzemeAdi.Size = new System.Drawing.Size(126, 25);
            this.malzemeAdi.TabIndex = 0;
            this.malzemeAdi.Text = "Malzeme Adı";
            // 
            // Ekle
            // 
            this.Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle.Location = new System.Drawing.Point(451, 12);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(165, 62);
            this.Ekle.TabIndex = 2;
            this.Ekle.Text = "EKLE";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(451, 148);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(165, 62);
            this.sil.TabIndex = 3;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // malzemeFiyati
            // 
            this.malzemeFiyati.AutoSize = true;
            this.malzemeFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeFiyati.Location = new System.Drawing.Point(38, 130);
            this.malzemeFiyati.Name = "malzemeFiyati";
            this.malzemeFiyati.Size = new System.Drawing.Size(143, 25);
            this.malzemeFiyati.TabIndex = 5;
            this.malzemeFiyati.Text = "Malzeme Fiyatı";
            // 
            // malzemeKategorisi
            // 
            this.malzemeKategorisi.AutoSize = true;
            this.malzemeKategorisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeKategorisi.Location = new System.Drawing.Point(23, 171);
            this.malzemeKategorisi.Name = "malzemeKategorisi";
            this.malzemeKategorisi.Size = new System.Drawing.Size(184, 25);
            this.malzemeKategorisi.TabIndex = 6;
            this.malzemeKategorisi.Text = "Malzeme Kategorisi";
            // 
            // malzemeFiyat
            // 
            this.malzemeFiyat.Location = new System.Drawing.Point(269, 130);
            this.malzemeFiyat.Name = "malzemeFiyat";
            this.malzemeFiyat.Size = new System.Drawing.Size(150, 22);
            this.malzemeFiyat.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1129, 306);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // malzeme_ID
            // 
            this.malzeme_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzeme_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.malzeme_ID.Location = new System.Drawing.Point(38, 8);
            this.malzeme_ID.Name = "malzeme_ID";
            this.malzeme_ID.Size = new System.Drawing.Size(155, 38);
            this.malzeme_ID.TabIndex = 10;
            this.malzeme_ID.Text = "Malzeme ID";
            // 
            // malzemeId
            // 
            this.malzemeId.Enabled = false;
            this.malzemeId.Location = new System.Drawing.Point(269, 8);
            this.malzemeId.Name = "malzemeId";
            this.malzemeId.Size = new System.Drawing.Size(150, 22);
            this.malzemeId.TabIndex = 11;
            // 
            // stok
            // 
            this.stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok.Location = new System.Drawing.Point(849, 573);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(295, 65);
            this.stok.TabIndex = 12;
            this.stok.Text = "STOK İŞLEMLERİ";
            this.stok.UseVisualStyleBackColor = true;
            this.stok.Click += new System.EventHandler(this.stok_Click_1);
            // 
            // malzemeKod
            // 
            this.malzemeKod.AutoSize = true;
            this.malzemeKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeKod.Location = new System.Drawing.Point(38, 47);
            this.malzemeKod.Name = "malzemeKod";
            this.malzemeKod.Size = new System.Drawing.Size(144, 25);
            this.malzemeKod.TabIndex = 13;
            this.malzemeKod.Text = "Malzeme Kodu";
            // 
            // malzemeKodu
            // 
            this.malzemeKodu.Location = new System.Drawing.Point(269, 46);
            this.malzemeKodu.Name = "malzemeKodu";
            this.malzemeKodu.Size = new System.Drawing.Size(150, 22);
            this.malzemeKodu.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 330);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Malzeme Kategorileri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(495, 157);
            this.dataGridView2.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(643, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 223);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // Guncelle
            // 
            this.Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncelle.Location = new System.Drawing.Point(451, 80);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(165, 62);
            this.Guncelle.TabIndex = 20;
            this.Guncelle.Text = "GÜNCELLE";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // malzemeAd
            // 
            this.malzemeAd.Location = new System.Drawing.Point(269, 90);
            this.malzemeAd.Name = "malzemeAd";
            this.malzemeAd.Size = new System.Drawing.Size(150, 22);
            this.malzemeAd.TabIndex = 21;
            // 
            // kategoriSec
            // 
            this.kategoriSec.FormattingEnabled = true;
            this.kategoriSec.Location = new System.Drawing.Point(269, 175);
            this.kategoriSec.Name = "kategoriSec";
            this.kategoriSec.Size = new System.Drawing.Size(150, 24);
            this.kategoriSec.TabIndex = 22;
            this.kategoriSec.SelectedIndexChanged += new System.EventHandler(this.kategoriSec_SelectedIndexChanged);
            // 
            // menuyeDon
            // 
            this.menuyeDon.Location = new System.Drawing.Point(28, 586);
            this.menuyeDon.Name = "menuyeDon";
            this.menuyeDon.Size = new System.Drawing.Size(136, 52);
            this.menuyeDon.TabIndex = 23;
            this.menuyeDon.Text = "GERİ";
            this.menuyeDon.UseVisualStyleBackColor = true;
            this.menuyeDon.Click += new System.EventHandler(this.menuyeDon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1159, 650);
            this.Controls.Add(this.menuyeDon);
            this.Controls.Add(this.kategoriSec);
            this.Controls.Add(this.malzemeAd);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.malzemeKodu);
            this.Controls.Add(this.malzemeKod);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.malzemeId);
            this.Controls.Add(this.malzeme_ID);
            this.Controls.Add(this.malzemeFiyat);
            this.Controls.Add(this.malzemeKategorisi);
            this.Controls.Add(this.malzemeFiyati);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.malzemeAdi);
            this.Name = "Form1";
            this.Text = "Ekle, Sil, Güncelle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label malzemeAdi;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label malzemeFiyati;
        private System.Windows.Forms.Label malzemeKategorisi;
        private System.Windows.Forms.TextBox malzemeFiyat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label malzeme_ID;
        private System.Windows.Forms.TextBox malzemeId;
        private System.Windows.Forms.Button stok;
        private System.Windows.Forms.Label malzemeKod;
        private System.Windows.Forms.TextBox malzemeKodu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.TextBox malzemeAd;
        private System.Windows.Forms.ComboBox kategoriSec;
        private System.Windows.Forms.Button menuyeDon;
    }
}

