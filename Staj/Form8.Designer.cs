namespace Staj
{
    partial class Form8
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siparisDurumu = new System.Windows.Forms.ComboBox();
            this.siparisDurumuGüncelle = new System.Windows.Forms.Button();
            this.menuyeDon = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(927, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(36, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİPARİŞ(MUTFAK)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SİPARİŞİN ŞUANKİ DURUMUNU SEÇİNİZ.";
            // 
            // siparisDurumu
            // 
            this.siparisDurumu.FormattingEnabled = true;
            this.siparisDurumu.Items.AddRange(new object[] {
            "Sipariş Hazırlanıyor",
            "Kuryeye Teslim Edildi"});
            this.siparisDurumu.Location = new System.Drawing.Point(386, 368);
            this.siparisDurumu.Name = "siparisDurumu";
            this.siparisDurumu.Size = new System.Drawing.Size(258, 33);
            this.siparisDurumu.TabIndex = 5;
            this.siparisDurumu.SelectedIndexChanged += new System.EventHandler(this.siparisDurumu_SelectedIndexChanged);
            // 
            // siparisDurumuGüncelle
            // 
            this.siparisDurumuGüncelle.Location = new System.Drawing.Point(329, 425);
            this.siparisDurumuGüncelle.Name = "siparisDurumuGüncelle";
            this.siparisDurumuGüncelle.Size = new System.Drawing.Size(353, 47);
            this.siparisDurumuGüncelle.TabIndex = 6;
            this.siparisDurumuGüncelle.Text = "SİPARİŞ DURUMU GÜNCELLE";
            this.siparisDurumuGüncelle.UseVisualStyleBackColor = true;
            this.siparisDurumuGüncelle.Click += new System.EventHandler(this.siparisDurumuGüncelle_Click);
            // 
            // menuyeDon
            // 
            this.menuyeDon.Location = new System.Drawing.Point(23, 12);
            this.menuyeDon.Name = "menuyeDon";
            this.menuyeDon.Size = new System.Drawing.Size(114, 36);
            this.menuyeDon.TabIndex = 7;
            this.menuyeDon.Text = "GERİ";
            this.menuyeDon.UseVisualStyleBackColor = true;
            this.menuyeDon.Click += new System.EventHandler(this.menuyeDon_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(858, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = " ";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1013, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuyeDon);
            this.Controls.Add(this.siparisDurumuGüncelle);
            this.Controls.Add(this.siparisDurumu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox siparisDurumu;
        private System.Windows.Forms.Button siparisDurumuGüncelle;
        private System.Windows.Forms.Button menuyeDon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}