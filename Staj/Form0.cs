using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj
{
    public partial class Form0 : Form
    {
        public DataGridView datagridview1 { get; set; }
        decimal sepetTutari = 0;
        private string kullaniciIsmi;
        private int kullaniciId;

        public Form0(int kullaniciId)
        {
            InitializeComponent();

            this.kullaniciId = kullaniciId;
            dataGridView1.Columns.Add("colAdSoyad", "Ad-Soyad");
            dataGridView1.Columns.Add("colUrunAdi", "Ürün Adı");
            dataGridView1.Columns.Add("colMiktar", "Miktar");
            dataGridView1.Columns.Add("colBirimFiyat", "Birim Fiyat");
            dataGridView1.Columns.Add("colTutar", "Tutar");
        }
        public int kullaniciID
        {
            get { return kullaniciId; }
        }

        public static class Oturum
        {
            private static Random random = new Random();
            private static int oturumID = random.Next(1, 9999);

            public static int OturumIdCagir()
            {
                return oturumID;
            }
        }
        private int id;
        public string secilenDeger;
        private void urunSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenDeger = urunSecimi.SelectedItem.ToString();
            string sorgu = "SELECT MalzemeId FROM TblMalzeme WHERE MalzemeAd=@MalzemeAd";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@MalzemeAd", SqlDbType.VarChar).Value = secilenDeger;

                if (cmd.ExecuteScalar() != null)
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    MessageBox.Show("ID Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (urunSecimi.SelectedItem != null)
            {

                HesaplaVeYazdir();
            }
        }
        private bool StokKontrol(int secilenUrunId, int siparisMiktari)
        {
            string secilenDeger = urunSecimi.SelectedItem.ToString();
            bool mevcutStok = false;
            string sorgu = "SELECT StokMiktari FROM TblStok WHERE MalzemeId = (SELECT MalzemeId FROM TblMalzeme WHERE MalzemeId = @MalzemeId)";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@MalzemeId", SqlDbType.Int).Value = id;
                if (cmd.ExecuteScalar() != null)
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    MessageBox.Show("Ürün Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                object nesne = cmd.ExecuteScalar();
                if (nesne != null && nesne != DBNull.Value)
                {
                    int stokMiktari = Convert.ToInt32(nesne);
                    if (stokMiktari >= siparisMiktari)
                    {
                        mevcutStok = true;
                    }
                }
            }
            return mevcutStok;
        }
        private void Form0_Load(object sender, EventArgs e)
        {
            odemeYontemi.DataSource = Enum.GetValues(typeof(OdemeTipleri))
             .Cast<Enum>()
             .Select
             (
                value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }
             )
        .OrderBy(item => item.value)
        .ToList();
            odemeYontemi.DisplayMember = "Description";
            odemeYontemi.ValueMember = "value";
            //odemeYontemi.Items.Add("Kapıda Nakit Ödeme");
            //odemeYontemi.Items.Add("Kapıda Kredi/Banka Kartı ile Ödeme");
            //odemeYontemi.Items.Add("Online Kredi/Banka Kartı ile Ödeme");
            string sorgu = "SELECT m.MalzemeAd FROM TblMalzeme m INNER JOIN TblStok s ON m.MalzemeId = s.MalzemeId WHERE s.StokMiktari > 0";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    urunSecimi.Items.Add(dr["MalzemeAd"]);
                }
            }
        }
        private void HesaplaVeYazdir()
        {
            string secilenMalzeme = urunSecimi.SelectedItem.ToString();
            decimal malzemeFiyati = MalzemeFiyatiGetir(secilenMalzeme);
            decimal adet = Miktar.Value;
            decimal toplamFiyat = malzemeFiyati * adet;
            araToplam.Text = toplamFiyat.ToString();
        }
        private decimal MalzemeFiyatiGetir(string MalzemeAdi)
        {
            decimal fiyat = 0.0m;
            string sorgu = "SELECT MalzemeFiyat FROM TblMalzeme WHERE MalzemeAd=@MalzemeAd";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@MalzemeAd", SqlDbType.VarChar).Value = MalzemeAdi;
                object sonuc = cmd.ExecuteScalar();
                if (sonuc != null && sonuc != DBNull.Value)
                {
                    fiyat = Convert.ToDecimal(sonuc);
                }
            }
            return fiyat;
        }
        public int siparis_ID;
        public int siparisId;
        private void StokMiktariAzalt(int azalacakMiktar, int malzemeId)
        {
            string sorgu = "UPDATE TblStok SET StokMiktari = StokMiktari - @Miktar WHERE MalzemeId = @MalzemeId";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@Miktar", SqlDbType.Int).Value = azalacakMiktar;
                cmd.Parameters.Add("@MalzemeId", SqlDbType.Int).Value = malzemeId;
                cmd.ExecuteNonQuery();
            }
        }
        private void Miktar_ValueChanged(object sender, EventArgs e)
        {
            HesaplaVeYazdir();
        }
        private void siparisOlustur_Click(object sender, EventArgs e)
        {
            int FisNo = Oturum.OturumIdCagir();
            int secilenUrunId = id;
            int siparisMiktari = Convert.ToInt32(Miktar.Value);
            if (StokKontrol(secilenUrunId, siparisMiktari))
            {
                string adSoyad = musteriAdSoyad.Text;
                string urunAdi = urunSecimi.SelectedItem.ToString();
                decimal malzemeFiyati = MalzemeFiyatiGetir(urunAdi);
                decimal adet = Miktar.Value;
                decimal toplamFiyat = malzemeFiyati * adet;
                araToplam.Text = toplamFiyat.ToString();
                decimal tutar = toplamFiyat;
                DataGridViewRow yeni = new DataGridViewRow();
                yeni.CreateCells(dataGridView1, adSoyad, urunAdi, adet, malzemeFiyati, tutar);
                dataGridView1.Rows.Add(yeni);
                sepetTutari += tutar;
                toplamTutar.Text = sepetTutari.ToString();
                MessageBox.Show("Sepete Eklendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Stok Yetersiz, Lütfen Miktarı Azaltın veya Başka Bir Ürün Seçin !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void siparisSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int satirIndex = dataGridView1.SelectedRows[0].Index;
                decimal silinecekTutar = (decimal)dataGridView1.Rows[satirIndex].Cells["colTutar"].Value;
                sepetTutari -= silinecekTutar;
                toplamTutar.Text = sepetTutari.ToString();
                dataGridView1.Rows.RemoveAt(satirIndex);
            }
            else
            {
                MessageBox.Show("Sepet Boş !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siparisOnayla_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Sepet boş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int siparisID = SiparisKaydet();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string urunAdi = row.Cells["colUrunAdi"].Value.ToString();
                int miktar = Convert.ToInt32(row.Cells["colMiktar"].Value);
                decimal birimFiyat = Convert.ToDecimal(row.Cells["colBirimFiyat"].Value);
                string aciklama = Aciklama.Text;
                int MalzemeId = MalzemeIdGetir(urunAdi);
                string sorgu = "INSERT INTO TblSiparisSatiri(SiparisAdedi, BirimFiyat, SiparisID, MalzemeID, Aciklama) VALUES (@SiparisAdedi, @BirimFiyat, @SiparisID, @MalzemeID, @Aciklama)";
                using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
                {
                    cmd.Parameters.Add("@SiparisAdedi", SqlDbType.Int).Value = miktar;
                    cmd.Parameters.Add("@BirimFiyat", SqlDbType.Float).Value = birimFiyat;
                    cmd.Parameters.Add("@SiparisID", SqlDbType.Int).Value = siparisID;
                    cmd.Parameters.Add("@MalzemeID", SqlDbType.Int).Value = MalzemeId;
                    cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = aciklama;
                    cmd.ExecuteNonQuery();
                    StokMiktariAzalt(miktar, MalzemeId);
                }
            }
            MessageBox.Show("Sipariş Oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.Rows.Clear();
            sepetTutari = 0;
            toplamTutar.Text = sepetTutari.ToString();

        }
        private int SiparisKaydet()
        {
            int siparisId = -1;
            int FisNo = Oturum.OturumIdCagir();
            decimal toplamTutar2 = 0;
            string AdSoyad = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                AdSoyad = row.Cells["colAdSoyad"].Value.ToString();
                toplamTutar2 += Convert.ToDecimal(row.Cells["colTutar"].Value);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string urunAdi = row.Cells["colUrunAdi"].Value.ToString();
                int miktar = Convert.ToInt32(row.Cells["colMiktar"].Value);
                int azaltilacakMiktar = miktar;
                int malzemeId = MalzemeIdGetir(urunAdi);
                StokMiktariAzalt(azaltilacakMiktar, malzemeId);
            }
            string sorgu = "INSERT INTO TblSiparis (SiparisAdSoyad, SiparisTutari, FisNo, KullaniciID,Adres,OdemeYontemi,SiparisDurumu) VALUES (@SiparisAdSoyad, @SiparisTutari, @FisNo,@KullaniciID,@Adres,@OdemeYontemi,@SiparisDurumu); SELECT SCOPE_IDENTITY();";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                int kullaniciId = kullaniciID;
                cmd.Parameters.Add("@SiparisAdSoyad", SqlDbType.VarChar).Value = AdSoyad;
                cmd.Parameters.Add("@SiparisTutari", SqlDbType.Float).Value = toplamTutar2;
                cmd.Parameters.Add("@FisNo", SqlDbType.Int).Value = FisNo;
                cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = kullaniciID;
                cmd.Parameters.Add("@Adres", SqlDbType.VarChar).Value = musteriAdres.Text;
                cmd.Parameters.Add("@OdemeYontemi", SqlDbType.VarChar).Value = odemeYontemi.SelectedValue.ToString();
                cmd.Parameters.Add("@SiparisDurumu", SqlDbType.VarChar).Value = "Sipariş Alındı";
                siparisId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return siparisId;
        }
        private int MalzemeIdGetir(string urunAdi)
        {
            {
                int malzemeId = -1;
                string sorgu = "SELECT MalzemeId FROM TblMalzeme WHERE MalzemeAd = @MalzemeAd";
                using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
                {
                    cmd.Parameters.Add("@MalzemeAd", SqlDbType.VarChar).Value = urunAdi;
                    object nesne = cmd.ExecuteScalar();
                    if (nesne != null && nesne != DBNull.Value)
                    {
                        malzemeId = Convert.ToInt32(nesne);
                    }
                }
                return malzemeId;
            }
        }
        private void urunSecimi_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index;
            if (index < 0 || index >= urunSecimi.Items.Count)
                return;
            e.DrawBackground();
            Brush firca = Brushes.Blue;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.Turquoise, e.Bounds);
                firca = Brushes.Blue;
            }
            string itemText = urunSecimi.GetItemText(urunSecimi.Items[index]);
            string malzemeFiyat = MalzemeFiyatiGetir(itemText).ToString("C2");
            string itemDisplayText = $"{itemText} - {malzemeFiyat}";
            e.Graphics.DrawString(itemDisplayText, e.Font, firca, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
        private void menuyeDon_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(kullaniciIsmi, kullaniciId);
            frm3.Show();
            this.Close();
        }


    }
}


