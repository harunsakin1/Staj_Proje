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
    public partial class Form8 : Form
    {
        private int satirSayisi;
        private int eskiSatirSayisi;
        private bool yeniSiparis=false;
        private int secilenSiparisId = -1;
        private int siparisId;
        private int kullaniciId;
        private string kullaniciIsmi;
        public Form8(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
        }
        public int kullaniciID
        {
            get { return kullaniciId; }
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            SiparisListele();
            Timer timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += timer1_Tick;
            timer.Start();
            eskiSatirSayisi = dataGridView1.Rows.Count;
        }
        public void SiparisListele()
        {  
            string sorgu = @"SELECT ss.SiparisID as 'Sipariş ID', m.MalzemeAd as 'Ürün İsmi', ss.Aciklama FROM TblSiparisSatiri ss  
               INNER JOIN TblMalzeme m ON ss.MalzemeID = m.MalzemeID  
               WHERE ss.SiparisID IN (SELECT SiparisID FROM TblSiparis WHERE SiparisDurumu = 'Sipariş Alındı' OR SiparisDurumu = 'Sipariş Hazırlanıyor')";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo);               
                dataGridView1.DataSource = tablo;               
            }  
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = e.RowIndex;
            int sutun = e.ColumnIndex;
            if (satir < 0 || sutun < 0)
            {
                return;
            }
            siparisId = Convert.ToInt32(dataGridView1.Rows[satir].Cells["Sipariş ID"].Value);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int suankiSiparisId = Convert.ToInt32(row.Cells["Sipariş ID"].Value);
                if (suankiSiparisId == siparisId)
                {
                    row.Selected = true;
                }
            }
        }
        private void siparisDurumuGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE TblSiparis SET SiparisDurumu = @SiparisDurumu WHERE SiparisId = @SiparisId";
            using (SqlCommand cmd = new SqlCommand(sorgu, DbYonetimi.BaglantiTestEt()))
            {
                cmd.Parameters.Add("@SiparisDurumu", SqlDbType.VarChar).Value = siparisDurumu.SelectedItem.ToString();
                cmd.Parameters.Add("@SiparisId", SqlDbType.Int).Value = siparisId;
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Sipariş Durumu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void menuyeDon_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(kullaniciIsmi, kullaniciID);
            frm3.Show();
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SiparisListele();
            satirSayisi = dataGridView1.Rows.Count;
            if (satirSayisi>eskiSatirSayisi)
            {
                label2.Text = "Sipariş Var";
            }
        }
        private void siparisDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            yeniSiparis = false;
        }
    }
}
