using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Moduls.Entity
{
    public class VeresiyeSatis
    {
        public int VeresiyeSatisID { get; set; }
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public DateTime SatinAlmaTarihi { get; set; } = DateTime.Now;
        public double Tutar { get; set; }
    }

}
