using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_otomasyon
{
    public partial class TedarikçiBilgi : Form
    {
        public TedarikçiBilgi()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ana_menu ANA = new Ana_menu();
            ANA.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ÜrünStok ürün = new ÜrünStok();
            ürün.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            müşteriler müşteri = new müşteriler();
            müşteri.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Giris_ekrani giris = new Giris_ekrani();
            giris.Show();
            this.Hide();
        }
    }
}
