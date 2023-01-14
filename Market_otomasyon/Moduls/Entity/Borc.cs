using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Market_otomasyon.Moduls.Entity
{
    public class Borc
    {
        public int BorcID { get; set; }
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public double Tutar { get; set; }
        public DateTime SatinAlmaTarihi { get; set; } = DateTime.Now;
        public double MusteriOdeme { get; set; }
        //public double ToplamBorc{ get; set; }
        public double KalanBorc { get; set; }

        public double KalanBorcOlustur()
        {
            KalanBorc = Tutar - MusteriOdeme;
            return KalanBorc;
        }
    }
}
