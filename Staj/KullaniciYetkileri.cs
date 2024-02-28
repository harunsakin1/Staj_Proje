using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staj
{
    public class KullaniciYetkileri
    {
        public bool StokGor { get; set; }
        public bool MalzemeGor { get; set; }
        public bool KullaniciEkle { get; set; }
        public bool RolEkle { get; set; }
        public bool SiparisVer { get; set; }
        public bool SiparisDurumu { get; set; }
        public bool Mutfak { get; set; }
        public bool Kurye { get; set; }
        public KullaniciYetkileri(bool stokGor, bool malzemeGor, bool kullaniciEkle, bool rolEkle ,bool siparisVer, bool siparisDurumu, bool mutfak, bool kurye)
        {
            StokGor = stokGor;
            MalzemeGor = malzemeGor;
            KullaniciEkle = kullaniciEkle;
            RolEkle = rolEkle;
            SiparisVer = siparisVer;
            SiparisDurumu = siparisDurumu;
            Mutfak = mutfak;
            Kurye = kurye;
        }

    }
}