using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market_otomasyon.Moduls.Entity;
using Market_otomasyon.Context;
using System.Data.SqlClient;

namespace Market_otomasyon
{
    public partial class ÜrünStok : Form
    {

        public ÜrünStok()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TedarikçiBilgi tedarikci = new TedarikçiBilgi();
            tedarikci.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ana_menu ANA = new Ana_menu();
            ANA.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

      
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            label2.Hide();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();


                while (satir != null)
                {
                    string[] itemler = satir.Split(' ');
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();

                    Stok ürünn = new Stok();
                    MarketDbContext context = new MarketDbContext();

                    int count = 0;

                    if (count == 0)
                    {
                        ürünn.UrunKodu = Convert.ToInt32(itemler[0]);
                        ürünn.Barkod = ürünn.BarkodOlustur();
                        count = count + 1;
                    }

                    if (count == 1)
                    {
                        ürünn.Cesit = itemler[1];
                        count = count + 1;
                    }

                    if (count == 2)
                    {
                        ürünn.StokMiktari = Convert.ToInt32(itemler[2]);
                        count = count + 1;
                    }

                    if (count == 3)
                    {
                        ürünn.UrunAdi = itemler[3];
                        count = count + 1;
                    }

                    if (count == 4)
                    {
                        ürünn.BirimGirdiFiyat = Convert.ToDouble(itemler[4]);
                        ürünn.SatisFiyati = ürünn.SatisFiyatiOlustur();
                        //context.Stoks.Add(ürünn);
                        //context.SaveChanges();
                        count = count + 1;
                    }

                    if (count == 5)
                    {
                        ürünn.IrsaliyeNo = Convert.ToInt32(itemler[5]);
                        context.Stoks.Add(ürünn);
                        context.SaveChanges();
                        count = count + 1; ;
                    }



                    count = count + 1;

                }
                }

            }

        private void ÜrünStok_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            label2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            label2.Show();
            MarketDbContext db = new MarketDbContext();
            var stokbilgi = db.Stoks.ToList();
            dataGridView1.DataSource = stokbilgi;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

