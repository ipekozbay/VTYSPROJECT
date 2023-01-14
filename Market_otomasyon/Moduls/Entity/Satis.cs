using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Moduls.Entity
{
    public class Satis
    {
        public int SatisID { get; set; }
        public int FaturaID { get; set; }
        public int MusteriID { get; set; }
        public int UrunID { get; set; }
        public string SatisTipi { get; set; }
        public int Miktar { get; set; }
        public double Tutar { get; set; }
        public DateTime SatinAlmaTarihi { get; set; }
        public int Barkod { get; set; }
    }
    }
