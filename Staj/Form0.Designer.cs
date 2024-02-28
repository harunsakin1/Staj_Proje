namespace Staj
{
    partial class Form0
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.musteriAdSoyad = new System.Windows.Forms.TextBox();
            this.Aciklama = new System.Windows.Forms.TextBox();
            this.Miktar = new System.Windows.Forms.NumericUpDown();
            this.urunSecimi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.araToplam = new System.Windows.Forms.Label();
            this.siparisOlustur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.siparisOnayla = new System.Windows.Forms.Button();
            this.siparisSil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toplamTutar = new System.Windows.Forms.Label();
            this.menuyeDon = new System.Windows.Forms.Button();
            this.musteriAdres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.odemeYontemi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.zamanlayici = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Seçimi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Açıklama :";
            // 
            // musteriAdSoyad
            // 
            this.musteriAdSoyad.Location = new System.Drawing.Point(233, 66);
            this.musteriAdSoyad.Name = "musteriAdSoyad";
            this.musteriAdSoyad.Size = new System.Drawing.Size(169, 30);
            this.musteriAdSoyad.TabIndex = 4;
            // 
            // Aciklama
            // 
            this.Aciklama.Location = new System.Drawing.Point(233, 260);
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Size = new System.Drawing.Size(169, 30);
            this.Aciklama.TabIndex = 6;
            // 
            // Miktar
            // 
            this.Miktar.Location = new System.Drawing.Point(233, 195);
            this.Miktar.Name = "Miktar";
            this.Miktar.Size = new System.Drawing.Size(169, 30);
            this.Miktar.TabIndex = 7;
            this.Miktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Miktar.ValueChanged += new System.EventHandler(this.Miktar_ValueChanged);
            // 
            // urunSecimi
            // 
            this.urunSecimi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.urunSecimi.FormattingEnabled = true;
            this.urunSecimi.Location = new System.Drawing.Point(233, 121);
            this.urunSecimi.Name = "urunSecimi";
            this.urunSecimi.Size = new System.Drawing.Size(169, 31);
            this.urunSecimi.TabIndex = 8;
            this.urunSecimi.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.urunSecimi_DrawItem);
            this.urunSecimi.SelectedIndexChanged += new System.EventHandler(this.urunSecimi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tutar :";
            // 
            // araToplam
            // 
            this.araToplam.AutoSize = true;
            this.araToplam.Location = new System.Drawing.Point(270, 443);
            this.araToplam.Name = "araToplam";
            this.araToplam.Size = new System.Drawing.Size(61, 25);
            this.araToplam.TabIndex = 10;
            this.araToplam.Text = "00,00";
            // 
            // siparisOlustur
            // 
            this.siparisOlustur.Location = new System.Drawing.Point(120, 493);
            this.siparisOlustur.Name = "siparisOlustur";
            this.siparisOlustur.Size = new System.Drawing.Size(200, 48);
            this.siparisOlustur.TabIndex = 13;
            this.siparisOlustur.Text = "SEPETE EKLE";
            this.siparisOlustur.UseVisualStyleBackColor = true;
            this.siparisOlustur.Click += new System.EventHandler(this.siparisOlustur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(474, 355);
            this.dataGridView1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(425, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 384);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEPET";
            // 
            // siparisOnayla
            // 
            this.siparisOnayla.Location = new System.Drawing.Point(425, 500);
            this.siparisOnayla.Name = "siparisOnayla";
            this.siparisOnayla.Size = new System.Drawing.Size(195, 41);
            this.siparisOnayla.TabIndex = 17;
            this.siparisOnayla.Text = "SİPARİŞ ONAYLA";
            this.siparisOnayla.UseVisualStyleBackColor = true;
            this.siparisOnayla.Click += new System.EventHandler(this.siparisOnayla_Click);
            // 
            // siparisSil
            // 
            this.siparisSil.Location = new System.Drawing.Point(790, 500);
            this.siparisSil.Name = "siparisSil";
            this.siparisSil.Size = new System.Drawing.Size(112, 41);
            this.siparisSil.TabIndex = 18;
            this.siparisSil.Text = "SİL";
            this.siparisSil.UseVisualStyleBackColor = true;
            this.siparisSil.Click += new System.EventHandler(this.siparisSil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "SEPET TUTARI :";
            // 
            // toplamTutar
            // 
            this.toplamTutar.AutoSize = true;
            this.toplamTutar.Location = new System.Drawing.Point(722, 461);
            this.toplamTutar.Name = "toplamTutar";
            this.toplamTutar.Size = new System.Drawing.Size(61, 25);
            this.toplamTutar.TabIndex = 20;
            this.toplamTutar.Text = "00,00";
            // 
            // menuyeDon
            // 
            this.menuyeDon.Location = new System.Drawing.Point(12, 12);
            this.menuyeDon.Name = "menuyeDon";
            this.menuyeDon.Size = new System.Drawing.Size(138, 35);
            this.menuyeDon.TabIndex = 21;
            this.menuyeDon.Text = "Geri";
            this.menuyeDon.UseVisualStyleBackColor = true;
            this.menuyeDon.Click += new System.EventHandler(this.menuyeDon_Click);
            // 
            // musteriAdres
            // 
            this.musteriAdres.Location = new System.Drawing.Point(233, 325);
            this.musteriAdres.Name = "musteriAdres";
            this.musteriAdres.Size = new System.Drawing.Size(169, 30);
            this.musteriAdres.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Adres :";
            // 
            // odemeYontemi
            // 
            this.odemeYontemi.FormattingEnabled = true;
            this.odemeYontemi.Location = new System.Drawing.Point(233, 384);
            this.odemeYontemi.Name = "odemeYontemi";
            this.odemeYontemi.Size = new System.Drawing.Size(169, 33);
            this.odemeYontemi.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ödeme Yöntemi :";
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(917, 564);
            this.Controls.Add(this.odemeYontemi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.musteriAdres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuyeDon);
            this.Controls.Add(this.toplamTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.siparisSil);
            this.Controls.Add(this.siparisOnayla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.siparisOlustur);
            this.Controls.Add(this.araToplam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.urunSecimi);
            this.Controls.Add(this.Miktar);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.musteriAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form0";
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.Form0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox musteriAdSoyad;
        private System.Windows.Forms.TextBox Aciklama;
        private System.Windows.Forms.NumericUpDown Miktar;
        private System.Windows.Forms.ComboBox urunSecimi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label araToplam;
        private System.Windows.Forms.Button siparisOlustur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button siparisOnayla;
        private System.Windows.Forms.Button siparisSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label toplamTutar;
        private System.Windows.Forms.Button menuyeDon;
        private System.Windows.Forms.TextBox musteriAdres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox odemeYontemi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer zamanlayici;
    }
}