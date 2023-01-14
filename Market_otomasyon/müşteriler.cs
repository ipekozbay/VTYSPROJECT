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
using System.Data.SqlClient;

namespace Market_otomasyon
{
    public partial class müşteriler : Form
    {
        public object MarketProjeModel { get; private set; }

        public müşteriler()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Yeni_Müsteri yenimüsteri = new Yeni_Müsteri();
            yenimüsteri.Show();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Musteri_Sil musteri_Sil = new Musteri_Sil();
            musteri_Sil.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana_menu ANA = new Ana_menu();
            ANA.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris_ekrani giris = new Giris_ekrani();
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜrünStok ürün = new ÜrünStok();
            ürün.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MarketDbContext db = new MarketDbContext();
            var müsteri = db.Musteris.ToList();
            dataGridView1.DataSource = müsteri;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MarketDbContext aa = new MarketDbContext();
            var borc = aa.Borcs.ToList();
            dataGridView1.DataSource = borc;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TedarikçiBilgi tedarikci = new TedarikçiBilgi();
            tedarikci.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            //double borc = Convert.ToDouble(textBox1.Text);
           // double odeme = Convert.ToDouble(textBox2.Text);
           // double kalanborc = borc - odeme;
            // textBox3.Text = Convert.ToString(kalanborc);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Borc bilgi = new Borc();
           // bilgi.KalanBorc = bilgi.KalanBorcOlustur();
            MarketDbContext cntxt = new MarketDbContext();
            int Id = Convert.ToInt32(textBox3.Text);
            var guncelle = cntxt.Borcs.Where(w => w.BorcID == Id).FirstOrDefault();
            guncelle.MusteriOdeme += Convert.ToDouble(textBox2.Text);
            guncelle.KalanBorc = Convert.ToDouble(textBox1.Text);
               // bilgi.KalanBorc = bilgi.KalanBorcOlustur();               
                cntxt.SaveChanges();
            bilgi.KalanBorc = bilgi.KalanBorcOlustur();
            MessageBox.Show("ödeme gerçekleştirldi");


            /* MarketDbContext cntx = new MarketDbContext();
             Borc borcMus = new Borc
             {
                 MusteriID = Convert.ToInt32(comboBox1.SelectedItem),
                 MusteriOdeme = Convert.ToInt32(textBox2.Text)
             };
             cntx.Borcs.Add(borcMus);
             cntx.SaveChanges();
             MessageBox.Show("ödeme gerçekleştirldi"); */
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void müşteriler_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
       // static readonly string conString = "Data Source=DESKTOP-S41BM0N;Initial Catalog=MarketProje;Integrated Security=True";
        //private readonly SqlConnection baglanti = new SqlConnection(conString);
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            /* baglanti.Open();
             var ad = comboBox1.SelectedItem;
             string kayit = "SELECT * from Borcs where BorcMusteriID=@BorcMusteriID";
             SqlCommand komut = new SqlCommand(kayit, baglanti);
             komut.Parameters.AddWithValue("@BorcMusteriID", comboBox1.SelectedItem);

             SqlDataAdapter da = new SqlDataAdapter(komut);
             DataTable dt = new DataTable();
             da.Fill(dt);
             dataGridView1.DataSource = dt;
             baglanti.Close();
             //
             SqlConnection baglanti3 = new SqlConnection
             {
                 ConnectionString = @"Data Source=DESKTOP-S41BM0N;Initial Catalog=MarketProje;Integrated Security=True"
             };
             baglanti3.Open();
             string kayit2 = "SELECT KalanBorc from Borcs where BorcMusteriID=@BorcMusteriID";
             SqlCommand komut3 = new SqlCommand(kayit2, baglanti3);
             komut3.Parameters.AddWithValue("@BorcMusteriID", comboBox1.SelectedItem);

             DataTable dt2 = new DataTable();
             SqlDataAdapter da2 = new SqlDataAdapter(komut3);
             da2.Fill(dt2);
             int total = 0;
             textBox1.Clear();

             foreach (DataRow dre in dt2.Rows)
             {
                 total = total + Convert.ToInt32(dre["KalanBorc"].ToString());


                 textBox1.Text = Convert.ToString(total);
             }
             baglanti3.Close();
         } */
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var context = new MarketDbContext();
            var cevap = context.Borcs.Where(i => i.KalanBorc == 0).FirstOrDefault();
            if (cevap != null)
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }

            //textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


        }

        private void button7_Click_1(object sender, EventArgs e)
        {
         

            double para;
            para = double.Parse(textBox4.Text) - double.Parse(textBox2.Text);
            textBox1.Text = para.ToString();
        }
    }

}