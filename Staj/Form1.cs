using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Staj
{
    public partial class Form1 : Form
    {

        private string kullaniciIsmi;
        private int kullaniciId;
        SqlDataAdapter da;
        public Form1(string kullaniciIsmi, int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciIsmi = kullaniciIsmi;
            this.kullaniciId = kullaniciId;
        }
        public int kullaniciID
        {
            get { return kullaniciId; }
        }
        public Form1()
        {
        }

        public int id;
        void KategoriGetir()
        {
            string sorgu = "SELECT * FROM TblKategori";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView2.DataSource = table;
            }
        }
        void MalzemeGetir()
        {
            string sorgu = "SELECT m.MalzemeId, m.MalzemeKod, m.MalzemeAd, m.MalzemeFiyat, k.KategoriAd MalzemeKategori FROM TblMalzeme m inner join TblKategori k ON m.MalzemeKategori=k.KategoriId";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string sorgu2 = "SELECT * FROM TblKategori";
            using (SqlCommand cmd = new SqlCommand(sorgu2, DbYonetimi.BaglantiTestEt()))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kategoriSec.Items.Add(dr["KategoriAd"]);
                }
            }
            KategoriGetir();
            MalzemeGetir();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "SELECT COUNT(*) FROM TblMalzeme WHERE MalzemeAd=@MalzemeAd OR MalzemeKod = @MalzemeKod";
            using (SqlCommand cmd = new SqlCommand(sorgu2, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@MalzemeAd", SqlDbType.VarChar).Value = malzemeAd.Text;
                cmd.Parameters.Add("@MalzemeKod", SqlDbType.Char).Value = malzemeKodu.Text;
                if (cmd.ExecuteScalar() != null)
                {
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Bu isimde veya koda ait bir malzeme zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            string sorgu = @"INSERT INTO TblMalzeme(MalzemeKod, MalzemeAd, MalzemeFiyat, MalzemeKategori) VALUES (@MalzemeKod, @MalzemeAd, @MalzemeFiyat, @MalzemeKategori) 
                             EXECUTE BirimFiyatGuncelle";

            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@MalzemeKod", SqlDbType.Char).Value = malzemeKodu.Text;
                cmd.Parameters.Add("@MalzemeAd", SqlDbType.VarChar).Value = malzemeAd.Text;
                cmd.Parameters.Add("@MalzemeFiyat", SqlDbType.Float).Value = malzemeFiyat.Text;
                cmd.Parameters.Add("@MalzemeKategori", SqlDbType.Int).Value = id;
                Convert.ToInt32(cmd.ExecuteNonQuery());
                MalzemeGetir();
                MessageBox.Show("Malzeme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM TblMalzeme WHERE MalzemeId=@MalzemeId";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@MalzemeId", SqlDbType.Int).Value = Convert.ToInt32(malzemeId.Text);
                Convert.ToInt32(cmd.ExecuteNonQuery());
                MalzemeGetir();
                MessageBox.Show("Silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Guncelle_Click(object sender, EventArgs e)
        {
            double miktar;
            if (!double.TryParse(malzemeFiyat.Text, out miktar))
            {
                MessageBox.Show("Geçersiz Miktar.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sorgu = "UPDATE TblMalzeme SET MalzemeKod=@MalzemeKod, MalzemeAd=@MalzemeAd, MalzemeFiyat=@MalzemeFiyat, MalzemeKategori=@MalzemeKategori WHERE MalzemeId=@MalzemeId";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@MalzemeId", SqlDbType.Int).Value = malzemeId.Text;
                cmd.Parameters.Add("@MalzemeKod", SqlDbType.VarChar).Value = malzemeKodu.Text;
                cmd.Parameters.Add("@MalzemeAd", SqlDbType.VarChar).Value = malzemeAd.Text;
                cmd.Parameters.Add("@MalzemeFiyat", SqlDbType.Float).Value = malzemeFiyat.Text;
                cmd.Parameters.Add("@MalzemeKategori", SqlDbType.Int).Value = id;
                Convert.ToInt32(cmd.ExecuteNonQuery());
                MalzemeGetir();
                MessageBox.Show("Güncelleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string sorgu2 = "EXECUTE BirimFiyatGuncelle ";
            using (SqlCommand cmd = new SqlCommand(sorgu2, DbYonetimi.BaglantiTestEt()))
            {
                cmd.ExecuteNonQuery();
            }
        }
        private void stok_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(kullaniciIsmi, kullaniciID);
            frm2.Show();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {   // DataGrid Satırlarına çift tıklandığında satırları textbox'lara yazdırır.
            malzemeId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            malzemeKodu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            malzemeAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            malzemeFiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kategoriSec.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void kategoriSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDeger = kategoriSec.SelectedItem.ToString();
            string sorgu = "SELECT KategoriId FROM TblKategori WHERE KategoriAd=@KategoriAd";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@KategoriAd", SqlDbType.VarChar).Value = secilenDeger;
                if (cmd.ExecuteScalar() != null)
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    MessageBox.Show("ID Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void menuyeDon_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(kullaniciIsmi, kullaniciId);
            frm3.Show();
            this.Close();
        }
    }
}