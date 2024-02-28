namespace Staj
{
    partial class Form2
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
            this.urunAdi = new System.Windows.Forms.ComboBox();
            this.stokAdet = new System.Windows.Forms.Label();
            this.stokAdedi = new System.Windows.Forms.TextBox();
            this.stokEkleme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stokArttir = new System.Windows.Forms.Button();
            this.stokAzalt = new System.Windows.Forms.Button();
            this.menuyeDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urunAdi
            // 
            this.urunAdi.FormattingEnabled = true;
            this.urunAdi.Location = new System.Drawing.Point(252, 67);
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Size = new System.Drawing.Size(230, 24);
            this.urunAdi.Sorted = true;
            this.urunAdi.TabIndex = 0;
            this.urunAdi.SelectedIndexChanged += new System.EventHandler(this.urunAdi_SelectedIndexChanged);
            // 
            // stokAdet
            // 
            this.stokAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokAdet.Location = new System.Drawing.Point(75, 129);
            this.stokAdet.Name = "stokAdet";
            this.stokAdet.Size = new System.Drawing.Size(125, 23);
            this.stokAdet.TabIndex = 1;
            this.stokAdet.Text = "Stok Adedi";
            // 
            // stokAdedi
            // 
            this.stokAdedi.Location = new System.Drawing.Point(252, 129);
            this.stokAdedi.Name = "stokAdedi";
            this.stokAdedi.Size = new System.Drawing.Size(230, 22);
            this.stokAdedi.TabIndex = 2;
            // 
            // stokEkleme
            // 
            this.stokEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokEkleme.Location = new System.Drawing.Point(80, 186);
            this.stokEkleme.Name = "stokEkleme";
            this.stokEkleme.Size = new System.Drawing.Size(402, 57);
            this.stokEkleme.TabIndex = 3;
            this.stokEkleme.Text = "STOK EKLE";
            this.stokEkleme.UseVisualStyleBackColor = true;
            this.stokEkleme.Click += new System.EventHandler(this.stokEkleme_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Malzemeler";
            // 
            // stokArttir
            // 
            this.stokArttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokArttir.Location = new System.Drawing.Point(80, 266);
            this.stokArttir.Name = "stokArttir";
            this.stokArttir.Size = new System.Drawing.Size(175, 57);
            this.stokArttir.TabIndex = 8;
            this.stokArttir.Text = "STOK ARTTIR";
            this.stokArttir.UseVisualStyleBackColor = true;
            this.stokArttir.Click += new System.EventHandler(this.stokGuncelleme_Click);
            // 
            // stokAzalt
            // 
            this.stokAzalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokAzalt.Location = new System.Drawing.Point(307, 266);
            this.stokAzalt.Name = "stokAzalt";
            this.stokAzalt.Size = new System.Drawing.Size(175, 57);
            this.stokAzalt.TabIndex = 9;
            this.stokAzalt.Text = "STOK AZALT";
            this.stokAzalt.UseVisualStyleBackColor = true;
            this.stokAzalt.Click += new System.EventHandler(this.stokAzalt_Click);
            // 
            // menuyeDon
            // 
            this.menuyeDon.Location = new System.Drawing.Point(24, 12);
            this.menuyeDon.Name = "menuyeDon";
            this.menuyeDon.Size = new System.Drawing.Size(95, 37);
            this.menuyeDon.TabIndex = 10;
            this.menuyeDon.Text = "GERİ";
            this.menuyeDon.UseVisualStyleBackColor = true;
            this.menuyeDon.Click += new System.EventHandler(this.menuyeDon_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(558, 357);
            this.Controls.Add(this.menuyeDon);
            this.Controls.Add(this.stokAzalt);
            this.Controls.Add(this.stokArttir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stokEkleme);
            this.Controls.Add(this.stokAdedi);
            this.Controls.Add(this.stokAdet);
            this.Controls.Add(this.urunAdi);
            this.Name = "Form2";
            this.Text = "Stok İşlemleri";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox urunAdi;
        private System.Windows.Forms.Label stokAdet;
        private System.Windows.Forms.TextBox stokAdedi;
        private System.Windows.Forms.Button stokEkleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stokArttir;
        private System.Windows.Forms.Button stokAzalt;
        private System.Windows.Forms.Button menuyeDon;
    }
}