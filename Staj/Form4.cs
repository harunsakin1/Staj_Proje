using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj
{

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }
        public int kullaniciId;
        private void kullaniciGirisi_Click(object sender, EventArgs e)
        {
            string kullaniciAd = kullaniciAdi.Text;
            string sifre = girisSifre.Text;
            int kullaniciId = KullaniciIdAl(kullaniciAd, sifre);
            if (kullaniciId != -1)
            {
                string sorgu = "SELECT * FROM TblKullanici WHERE KullaniciAdi=@p1 AND KullaniciSifre=@p2";

                using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
                {

                    cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = kullaniciAd;
                    cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = sifre;

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        string kullaniciIsmi = kullaniciAd;
                        Form3 form3 = new Form3(kullaniciIsmi, kullaniciId);
                        form3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public int KullaniciIdAl(string kullaniciAd, string kullaniciSifresi)
        {
            int kullaniciId = 0;
            string sorgu = "SELECT KullaniciId FROM TblKullanici WHERE KullaniciAdi=@KullaniciAdi AND KullaniciSifre=@KullaniciSifre ";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = kullaniciAdi.Text;
                cmd.Parameters.Add("@KullaniciSifre", SqlDbType.VarChar).Value = girisSifre.Text;
                object nesne = cmd.ExecuteScalar();
                if (nesne != null && nesne != DBNull.Value)
                {
                    kullaniciId = Convert.ToInt32(nesne);
                }
            }
            return kullaniciId;
        }

    }
}
