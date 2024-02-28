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
namespace Staj
{
    public partial class Form2 : Form
    {
        private string kullaniciIsmi;
        private int kullaniciId;
        public Form2(string kullaniciIsmi, int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciIsmi = kullaniciIsmi;
            this.kullaniciId = kullaniciId;
        }
        public int kullaniciID
        {
            get { return kullaniciId; }
        }
        private int id;
        private void Form3_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM TblMalzeme";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    urunAdi.Items.Add(dr["MalzemeAd"]);
                }
            }
        }
        private void urunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'tan Seçilen Item'ın adına göre ID'sini bulup secilenDeger isimli değişkene atıyor.
            // Daha sonra secilenDeger isimli değişken ile işlem yapılıyor.
            string secilenDeger = urunAdi.SelectedItem.ToString();
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
        }
        private void stokEkleme_Click(object sender, EventArgs e)
        {
            string sorgu2 = "SELECT COUNT(*) FROM TblStok WHERE MalzemeId=@MalzemeId";
            using (SqlCommand cmd = new SqlCommand(sorgu2, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@MalzemeId", SqlDbType.Int).Value = id;
                if (cmd.ExecuteScalar() != null)
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Malzeme Zaten Var. Stok Arttır Butonuna Basınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string sorgu = @"INSERT INTO TblStok (StokMiktari,MalzemeId)VALUES (@StokMiktari,@MalzemeId) EXECUTE BirimFiyatGuncelle";
                        using (SqlCommand cmd2 = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
                        {
                            cmd2.Parameters.Add("@StokMiktari", SqlDbType.Float).Value = stokAdedi.Text;
                            cmd2.Parameters.Add("@MalzemeId", SqlDbType.Int).Value = id;
                            Convert.ToInt32(cmd2.ExecuteNonQuery());
                            MessageBox.Show("Stok Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
            }
        }
        private void stokGuncelleme_Click(object sender, EventArgs e)
        {
            double miktar;
            if (!double.TryParse(stokAdedi.Text, out miktar))
            {
                MessageBox.Show("Geçersiz Miktar", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sorgu = "SELECT COUNT(*) FROM TblStok WHERE MalzemeId=@MalzemeId";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@MalzemeId", SqlDbType.Int).Value = id;
                if (cmd.ExecuteScalar() != null)
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                    {
                        MessageBox.Show("Malzeme Bulunamadı. Stok Ekle Butonunu Kullanmalısınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
            string stokGuncellemeSorgu = "UPDATE TblStok SET StokMiktari=StokMiktari+@Miktar WHERE MalzemeId=@MalzemeId";
            using (SqlCommand cmd = new SqlCommand(stokGuncellemeSorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@Miktar", SqlDbType.Float).Value = stokAdedi.Text;
                cmd.Parameters.Add("@MalzemeId", SqlDbType.Int).Value = id;
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("Stok Arttırılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Stok Arttırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        private void stokAzalt_Click(object sender, EventArgs e)
        {
            double miktar;
            if (!double.TryParse(stokAdedi.Text, out miktar))
            {
                MessageBox.Show("Geçersiz Miktar", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sorgu = "SELECT COUNT(*) FROM TblStok WHERE MalzemeId=@MalzemeId";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@MalzemeId", SqlDbType.Int).Value = id;
                if (cmd.ExecuteScalar() != null)
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                    {
                        MessageBox.Show("Malzeme Bulunamadı. Stok Ekle Butonunu Kullanmalısınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
            string stokAzaltmaSorgu = "UPDATE TblStok SET StokMiktari=StokMiktari-@Miktar WHERE MalzemeId=@MalzemeId";
            using (SqlCommand cmd = new SqlCommand(stokAzaltmaSorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@Miktar", SqlDbType.Float).Value = stokAdedi.Text;
                cmd.Parameters.Add("@MalzemeId", SqlDbType.Float).Value = id;
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("Stok Azaltılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Stok Azaltıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void menuyeDon_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(kullaniciIsmi, kullaniciID);
            frm3.Show();
            this.Close();

        }
    }
}