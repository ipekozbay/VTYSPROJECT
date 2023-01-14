using Market_otomasyon.Context;
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
    public partial class Giris_ekrani : Form
    {
        public Giris_ekrani()
        {
            InitializeComponent();
        }

        private void Giris_ekrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new MarketDbContext();
            var cevap = context.Satıcıs.Where(i => i.KullaniciAdi == txtKullaniciAdi.Text && i.Sifre == txtSifre.Text).FirstOrDefault();
            if (cevap != null)
            {
                Ana_menu ANA = new Ana_menu();
                ANA.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifrenizi yanlış girdiniz.");
                txtKullaniciAdi.Text = String.Empty;
                txtSifre.Text = String.Empty;
            }
            
            /*Ana_menu ANA = new Ana_menu();
            ANA.Show();
            this.Hide();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanıcı_oluştur kln = new Kullanıcı_oluştur();
            kln.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Şifre_sıfırlama şifre = new Şifre_sıfırlama();
            şifre.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
