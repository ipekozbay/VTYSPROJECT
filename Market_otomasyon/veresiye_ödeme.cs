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
    public partial class veresiye_ödeme : Form
    {
        public veresiye_ödeme()
        {
            InitializeComponent();
        }

        private void veresiye_ödeme_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Ana_menu menü = new Ana_menu();
            menü.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Yeni_Müsteri yenimüsteri = new Yeni_Müsteri();
            yenimüsteri.Show();
            //this.Hide();
        }
    }
}
