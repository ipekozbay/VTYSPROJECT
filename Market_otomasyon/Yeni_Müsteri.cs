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
    public partial class Yeni_Müsteri : Form
    {
        public Yeni_Müsteri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new MarketDbContext();
            context.Musteris.Add(new Musteri
            {
                
                MusteriAd = madı.Text,
                MusteriSoyad = msoyadı.Text,
                TelefonNo = mtel.Text
            });
            var cevap = context.SaveChanges();
            if (cevap <= 0)
            {
                MessageBox.Show("Müşteri sisteme kaydedilememiştir.");
            }
            else
            {
                MessageBox.Show("Müşteri sisteme başarıyla kaydedilmiştir.");
            }
        }
    }
}
