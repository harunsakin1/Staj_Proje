namespace Staj
{
    partial class Form9
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.siparisDurumu = new System.Windows.Forms.ComboBox();
            this.siparisDurumuGüncelle = new System.Windows.Forms.Button();
            this.menuyeDon = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(50, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİPARİŞ(KURYE)";
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
            this.dataGridView1.Size = new System.Drawing.Size(949, 212);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(330, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİPARİŞİN ŞUANKİ DURUMUNU SEÇİNİZ.";
            // 
            // siparisDurumu
            // 
            this.siparisDurumu.FormattingEnabled = true;
            this.siparisDurumu.Items.AddRange(new object[] {
            "Yola Çıktı",
            "Teslim Edildi"});
            this.siparisDurumu.Location = new System.Drawing.Point(335, 346);
            this.siparisDurumu.Name = "siparisDurumu";
            this.siparisDurumu.Size = new System.Drawing.Size(369, 33);
            this.siparisDurumu.TabIndex = 2;
            this.siparisDurumu.SelectedIndexChanged += new System.EventHandler(this.siparisDurumu_SelectedIndexChanged);
            // 
            // siparisDurumuGüncelle
            // 
            this.siparisDurumuGüncelle.Location = new System.Drawing.Point(335, 404);
            this.siparisDurumuGüncelle.Name = "siparisDurumuGüncelle";
            this.siparisDurumuGüncelle.Size = new System.Drawing.Size(369, 45);
            this.siparisDurumuGüncelle.TabIndex = 3;
            this.siparisDurumuGüncelle.Text = "Sipariş Durumu Güncelle";
            this.siparisDurumuGüncelle.UseVisualStyleBackColor = true;
            this.siparisDurumuGüncelle.Click += new System.EventHandler(this.siparisDurumuGüncelle_Click);
            // 
            // menuyeDon
            // 
            this.menuyeDon.Location = new System.Drawing.Point(26, 12);
            this.menuyeDon.Name = "menuyeDon";
            this.menuyeDon.Size = new System.Drawing.Size(104, 40);
            this.menuyeDon.TabIndex = 4;
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
            this.label2.Location = new System.Drawing.Point(909, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = " ";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(1063, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuyeDon);
            this.Controls.Add(this.siparisDurumuGüncelle);
            this.Controls.Add(this.siparisDurumu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox siparisDurumu;
        private System.Windows.Forms.Button siparisDurumuGüncelle;
        private System.Windows.Forms.Button menuyeDon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}