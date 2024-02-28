using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj
{
    public partial class Form7 : Form
    {
        private string kullaniciIsmi;
        private int kullanici_Id;
        public Form7(int kullanici_Id)
        {
            InitializeComponent();
            this.kullanici_Id = kullanici_Id;
        }
        public int kullaniciID
        {
            get { return kullanici_Id; }
        }
        private string kullaniciAdi;
        private void KullaniciGirisYapti(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            SiparisListele();
        }
        void SiparisListele()
        {
            string sorgu = @"SELECT s.SiparisID as 'Sipariş ID',m.MalzemeAd as 'Ürün İsmi',ss.SiparisAdedi as 'Miktar',ss.BirimFiyat as 'Birim Fiyat',s.Tarih, s.SiparisDurumu as 'Durum', ss.Aciklama
                FROM TblSiparis s
                INNER JOIN TblSiparisSatiri ss ON s.SiparisID = ss.SiparisID
                INNER JOIN TblMalzeme m ON ss.MalzemeID = m.MalzemeID
                WHERE s.KullaniciID = @KullaniciID AND s.SiparisDurumu != 'Teslim Edildi'";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                int kullaniciID = this.kullaniciID;
                cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = kullaniciID;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }
        private int KullaniciIdGetir(string kullaniciAdi)
        {
            int kullaniciId = -1;
            string sorgu = "SELECT KullaniciID FROM TblKullanici WHERE KullaniciAdi = @KullaniciAdi";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = kullaniciAdi;
                object sonuc = cmd.ExecuteScalar();
                if (sonuc != null && sonuc != DBNull.Value)
                {
                    kullaniciId = Convert.ToInt32(sonuc);
                }
            }
            return kullaniciId;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = e.RowIndex;
            int sutun = e.ColumnIndex;
            if (satir < 0 || sutun < 0)
            {
                return;
            }
            int siparisId = Convert.ToInt32(dataGridView1.Rows[satir].Cells["Sipariş ID"].Value);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int suankiSiparisId = Convert.ToInt32(row.Cells["Sipariş ID"].Value);
                if (suankiSiparisId == siparisId)
                {
                    row.Selected = true;
                }
            }
        }
        private void ToplamTutariHesapla()
        {
            decimal toplamTutar = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                decimal siparisTutari = Convert.ToDecimal(row.Cells["Birim Fiyat"].Value);
                decimal siparisAdedi = Convert.ToDecimal(row.Cells["Miktar"].Value);
                toplamTutar += siparisTutari * siparisAdedi;
            }
            toplamFiyat.Text = toplamTutar.ToString("C2");
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ToplamTutariHesapla();
        }
        private void menuyeDon_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(kullaniciIsmi, kullanici_Id);
            frm3.Show();
            this.Close();
        }
    }
}
