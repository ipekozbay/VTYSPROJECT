using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Moduls.Entity
{
    public class Stok

    {

        public int StokID { get; set; }
        public int UrunKodu { get; set; }
        public int Barkod { get; set; }
        public string Cesit { get; set; }
        public int StokMiktari { get; set; }
        public string UrunAdi { get; set; }
        public double BirimGirdiFiyat { get; set; }
        public double SatisFiyati { get; set; }
        public int IrsaliyeNo { get; set; }
        public int BarkodOlustur()
        {
            Random rnd = new Random();
            Barkod = UrunKodu + rnd.Next(0, 575);
            return Barkod;
        }
        public double SatisFiyatiOlustur()
        {
            SatisFiyati = BirimGirdiFiyat + (BirimGirdiFiyat * 0.2);
            return SatisFiyati;
        }

    }

}

