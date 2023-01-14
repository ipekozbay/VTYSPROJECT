using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Moduls.Entity
{
    public class PesinSatis
    {
        public int ID { get; set; }
        public int FaturaID { get; set; }     
        public double Tutar { get; set; }
    }
}
