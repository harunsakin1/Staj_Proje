using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj
{
    public partial class Form5 : Form
    {
        private int kullaniciId;
        private string kullaniciIsmi;
        public Form5(int kullaniciId)
        {
            this.kullaniciId = kullaniciId;
            InitializeComponent();
        }
        public int kullaniciID
        {
            get { return kullaniciId; }
        }
        private void kullaniciRolu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDeger = kullaniciRolu.SelectedItem.ToString();
            string sorgu = "SELECT RolId FROM TblRol WHERE KullaniciRolu=@KullaniciRolu";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@KullaniciRolu", SqlDbType.Char).Value = secilenDeger;
                if (cmd.ExecuteScalar() != null)
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                    return;
                }
                else
                {
                    MessageBox.Show("Id Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int id;
        private void kullaniciEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "SELECT COUNT(*) FROM TblKullanici WHERE KullaniciAdi=@KullaniciAdi";
            using (SqlCommand cmd = new SqlCommand(sorgu2, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = yeniKullaniciAdi.Text;
                if (cmd.ExecuteScalar() != null)
                {
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Bu isimde bir kullanıcı var, lütfen farklı bir kullanıcı adı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            string sorgu = "INSERT INTO TblKullanici(KullaniciAdi, KullaniciSifre, KullaniciRolId) VALUES (@p1,@p2,@p3)";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = yeniKullaniciAdi.Text;
                cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = yeniKullaniciSifre.Text;
                cmd.Parameters.Add("@p3", SqlDbType.Int).Value = id;
                Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Kullanıcı Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM TblRol";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kullaniciRolu.Items.Add(dr["KullaniciRolu"]);
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
