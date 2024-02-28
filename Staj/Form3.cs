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
    public partial class Form3 : Form
    {
        private int kullaniciId;
        private string kullaniciIsmi;
        public Form3(string kullaniciIsmi, int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciIsmi = kullaniciIsmi;
            this.kullaniciId = kullaniciId;
        }
        public int kullaniciID
        {
            get { return kullaniciId; }
        }
        private void menuKullaniciEkle_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5(kullaniciID);
            frm.Show();
            this.Close();
        }
        private void menuMalzeme_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(kullaniciIsmi, kullaniciID);
            frm1.Show();
            this.Close();
        }
        private void menuStok_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(kullaniciIsmi, kullaniciID);
            frm2.Show();
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            List<Rol> rol = new List<Rol>();
            string sorgu = "SELECT * FROM TblRol WHERE RolId=(SELECT KullaniciRolId FROM TblKullanici WHERE KullaniciId=@KullaniciId)";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                int kullaniciID = this.kullaniciID;
                cmd.Parameters.Add("@KullaniciId", SqlDbType.Int).Value = kullaniciID;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        bool StokGor = dr["StokGor"] == DBNull.Value ? false : Convert.ToBoolean(dr["StokGor"]);
                        bool MalzemeGor = dr["MalzemeGor"] == DBNull.Value ? false : Convert.ToBoolean(dr["MalzemeGor"]);
                        bool KullaniciEkle = dr["KullaniciEkle"] == DBNull.Value ? false : Convert.ToBoolean(dr["KullaniciEkle"]);
                        bool RolEkle = dr["RolEkle"] == DBNull.Value ? false : Convert.ToBoolean(dr["RolEkle"]);
                        bool SiparisVer = dr["SiparisVer"] == DBNull.Value ? false : Convert.ToBoolean(dr["SiparisVer"]);
                        bool SiparisDurumu = dr["SiparisDurumu"] == DBNull.Value ? false : Convert.ToBoolean(dr["SiparisDurumu"]);
                        bool mutfak = dr["Mutfak"] == DBNull.Value ? false : Convert.ToBoolean(dr["Mutfak"]);
                        bool kurye = dr["Kurye"] == DBNull.Value ? false : Convert.ToBoolean(dr["Kurye"]);
                        KullaniciYetkileri yetkiler = new KullaniciYetkileri(StokGor, MalzemeGor, KullaniciEkle, RolEkle, SiparisVer, SiparisDurumu, mutfak, kurye);
                        menuStok.Visible = yetkiler.StokGor;
                        menuMalzeme.Visible = yetkiler.MalzemeGor;
                        menuKullaniciEkle.Visible = yetkiler.KullaniciEkle;
                        menuRolEkle.Visible = yetkiler.RolEkle;
                        menuSiparisVer.Visible = yetkiler.SiparisVer;
                        menuSiparisDurumu.Visible = yetkiler.SiparisDurumu;
                        menuMutfak.Visible = yetkiler.Mutfak;
                        menuKurye.Visible = yetkiler.Kurye;
                    }
                }
            }
        }
        private void menuRolEkle_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6(kullaniciID);
            frm6.Show();
            this.Close();
        }
        private void siparisVer_Click(object sender, EventArgs e)
        {
            Form0 frm0 = new Form0(kullaniciID);
            frm0.Show();
            this.Close();
        }
        private void menuSiparisDurumu_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7(kullaniciID);
            frm7.Show();
            this.Close();
        }
        private void menuMutfak_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8(kullaniciID);
            frm8.Show();
            this.Close();
        }
        private void menuKurye_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9(kullaniciID);
            frm9.Show();
            this.Close();
        }
        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
