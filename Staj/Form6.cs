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
    public partial class Form6 : Form
    {
        private int kullaniciId;
        private string kullaniciIsmi;
        public Form6(int kullaniciId)
        {
            this.kullaniciId = kullaniciId;
            InitializeComponent();
        }
        public int kullaniciID
        {
            get { return kullaniciId; }
        }
        private void yetkiEkle_Click(object sender, EventArgs e)
        {

            string sorgu = "INSERT INTO TblRol(KullaniciRolu,StokGor,MalzemeGor,KullaniciEkle,RolEkle,SiparisVer,SiparisDurumu,Mutfak,Kurye) VALUES (@KullaniciRolu,@StokGor,@MalzemeGor,@KullaniciEkle,@RolEkle,@SiparisVer,@SiparisDurumu,@Mutfak,@Kurye)";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@KullaniciRolu", SqlDbType.VarChar).Value = yetkiAdi.Text;
                cmd.Parameters.Add("@StokGor", SqlDbType.Bit).Value = stokGor.Checked;
                cmd.Parameters.Add("@MalzemeGor", SqlDbType.Bit).Value = malzemeGor.Checked;
                cmd.Parameters.Add("@KullaniciEkle", SqlDbType.Bit).Value = yeniKullaniciEkle.Checked;
                cmd.Parameters.Add("@RolEkle", SqlDbType.Bit).Value = rolEkle.Checked;
                cmd.Parameters.Add("@SiparisVer", SqlDbType.Bit).Value = siparisVer.Checked;
                cmd.Parameters.Add("@SiparisDurumu", SqlDbType.Bit).Value = siparisDurumu.Checked;
                cmd.Parameters.Add("@Mutfak", SqlDbType.Bit).Value = Mutfak.Checked;
                cmd.Parameters.Add("@Kurye", SqlDbType.Bit).Value = Kurye.Checked;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yetki Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
