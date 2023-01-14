using Market_otomasyon.Context;
using Market_otomasyon.Moduls.Entity;
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
    public partial class Kullanıcı_oluştur : Form
    {
        public Kullanıcı_oluştur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris_ekrani giris = new Giris_ekrani();
            giris.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new MarketDbContext();
            context.Satıcıs.Add(new Satici
            {
                KullaniciAdi = txtkullaniciadi.Text,
                SaticiAd = txtisim.Text,
                SaticiSoyad = txtsoyisim.Text,
                Sifre = txtsifre.Text
            });
            var cevap= context.SaveChanges();
            if (cevap>0)
            {
                MessageBox.Show("Kullanıcı başarıyla oluşturulmuştur.");
                var satici = context.Satıcıs.Where(i => i.KullaniciAdi == txtkullaniciadi.Text).FirstOrDefault();
                lblno.Text = satici.SaticiID.ToString();
            }
            else
            {
                MessageBox.Show("Kullanıcı oluştururken hata oldu.");

            }
            
        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
