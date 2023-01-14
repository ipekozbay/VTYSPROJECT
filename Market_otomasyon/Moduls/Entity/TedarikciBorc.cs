using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Moduls.Entity
{
    public class TedarikciBorc
    {
        public int TedarikciBorcID { get; set; }
        public int TedarikciID { get; set; }
        public string Tedarikcisim { get; set; }
        public int IrsaliyeNo { get; set; }
        public double TedarikBorc { get; set; }
        public double TedarikOdeme { get; set; }

    }
}
