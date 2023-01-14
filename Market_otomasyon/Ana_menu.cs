using Market_otomasyon.Context;
//using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public partial class Ana_menu : Form
    {
        DataTable tablo = new DataTable();
        double tutar = 0;
        public Ana_menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris_ekrani giris = new Giris_ekrani();
            giris.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var cntxt = new MarketDbContext();
            cntxt.PesinSatis.Add(new PesinSatis
            {
                Tutar = Convert.ToDouble(textBox2.Text)

            });

              var cevap = cntxt.SaveChanges();
              if (cevap <= 0)
              {
                  MessageBox.Show("Satın Alma İşlemi Tamamlanamamıştır");
              }
              else
              {
                  MessageBox.Show("Satın Alma İşlemi Tamamlanmıştır");
              } 


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)
        {
            groupBox8.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            müşteriler müşteri = new müşteriler();
            müşteri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜrünStok ürün = new ÜrünStok();
            ürün.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TedarikçiBilgi tedarikci = new TedarikçiBilgi();
            tedarikci.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string barkodNo = textBox1.Text;
            using (var bb = new MarketDbContext())
            {
                var urun = bb.Stoks.FirstOrDefault(a => a.Barkod.ToString() == barkodNo);
                if (urun != null)
                {
                    tablo.Rows.Add(urun.Barkod, urun.UrunKodu, urun.UrunAdi, urun.Cesit, urun.SatisFiyati);
                    dataGridView1.DataSource = tablo;
                    tutar += urun.SatisFiyati;
                    textBox2.Text = tutar.ToString();
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Ürün Bulunamadı");
                }
                // tutar += urun.SatisFiyati;
                // textBox2.Text = tutar.ToString();
            }
            //textBox1.Clear();
        }

        private void Ana_menu_Load(object sender, EventArgs e)
        {
            groupBox3.Hide();
            groupBox8.Hide();
            tablo.Columns.Add("Ürün Kodu", typeof(int));
            tablo.Columns.Add("Barkod No", typeof(int));
            tablo.Columns.Add("Ürün Adı", typeof(string));
            tablo.Columns.Add("Çeşidi", typeof(string));
            tablo.Columns.Add("Fiyatı", typeof(double));


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            double para;
            para = double.Parse(textBox5.Text) - double.Parse(textBox2.Text);
            textBox4.Text = para.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Yeni_Müsteri yenimüsteri = new Yeni_Müsteri();
            yenimüsteri.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox3.Show();


            /* if (dataGridView1.SelectedRows.Count > 0)
             {
                 dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
             }
             else
             {
                 MessageBox.Show("Lüffen silinecek satırı seçin.");
             } */



        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(textBox6.Text) == 123)
            {
                MessageBox.Show("Seçilen Satır Listeden Silindi");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                textBox6.Clear();
                groupBox3.Hide();
            }

            else
            {
                MessageBox.Show("Yanlış Şifre Girdiniz");
                textBox6.Clear();
            }
        }



        private void button13_Click_1(object sender, EventArgs e)
        {
            string musteriadi = " ";
            string soyadi = " ";
            MarketDbContext db = new MarketDbContext();
            foreach (var deger in db.Musteris)
            {
                if (deger.MusteriID == Convert.ToInt32(textBox3.Text))
                {
                    musteriadi = deger.MusteriAd;
                    soyadi = deger.MusteriSoyad;
                }
            }

            var context = new MarketDbContext();
            context.Borcs.Add(new Borc
            {
                MusteriAd = musteriadi,
                MusteriSoyad = soyadi,
                MusteriID = Convert.ToInt32(textBox3.Text),
                Tutar = Convert.ToDouble(textBox2.Text)
            });

            var cevap = context.SaveChanges();
            if (cevap <= 0)
            {
                MessageBox.Show("Satın Alma İşlemi Tamamlanamamıştır");
            }
            else
            {
                MessageBox.Show("Satın Alma İşlemi Tamamlanmıştır");
            }



        }

        private void button15_Click(object sender, EventArgs e)
        {
            Borc bilgi = new Borc();
        
            MarketDbContext cntxt = new MarketDbContext();
            int Id = Convert.ToInt32(textBox3.Text);
            var guncelle = cntxt.Borcs.Where(w => w.BorcID == Id).FirstOrDefault();
            guncelle.Tutar  += Convert.ToDouble(textBox2.Text);
                         
            cntxt.SaveChanges();
            
            MessageBox.Show("ödeme gerçekleştirldi");
        }
    }
}

