using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet_rapor
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection("server=BERKAY\\SQLEXPRESS;Database=Northwind;integrated security=true");

        public void Listeleme(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listeleme("select UrunAdi,KategoriAdi,SirketAdi as TedarikciFirma from Tedarikciler as t inner join Urunler u on t.TedarikciID=u.TedarikciID inner join Kategoriler k on u.KategoriID=k.KategoriID");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listeleme("select UrunAdi KategoriAdi,BirimFiyati,HedefStokDuzeyi from Urunler u inner join Kategoriler k on u.KategoriID=k.KategoriID order by KategoriAdi asc");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listeleme("select KategoriAdi, sum(HedefStokDuzeyi) from Urunler u inner join Kategoriler k on u.KategoriID=k.KategoriID group by KategoriAdi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Grafik grafik = new Grafik();
            grafik.Show();
            //grafik.chart1.Series["Urunler"].Points.AddXY("masa", 1500);
            //grafik.chart1.Series["Urunler"].Points.AddXY("tv", 20000);
            //grafik.chart1.Series["Urunler"].Points.AddXY("koltuk", 45000);

            con.Open();
            //SqlCommand cmd = new SqlCommand("select top 5* from Urunler",con);
            SqlCommand cmd = new SqlCommand("select top 5 UrunAdi,BirimFiyati from Urunler", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) 
            {
                //grafik.chart1.Series["Urunler"].Points.AddXY(rdr[1],rdr[5]);
                grafik.chart1.Series["Urunler"].Points.AddXY(rdr[0], rdr[1]);
            }

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter adapter = new SqlDataAdapter("select * from Personeller p inner join Satislar s on p.PersonelID=s.PersonelID where Adi Like '%"+textBox1.Text+"%'",con);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //dataGridView1.DataSource = dt;
            SqlCommand cmd = new SqlCommand("select * from Personeller p inner join Satislar s on p.PersonelID=s.PersonelID where Adi Like '%'+@personelad+'%' and SevkUlkesi=@ulke",con);
            cmd.Parameters.AddWithValue("@personelad",textBox1.Text);
            cmd.Parameters.AddWithValue("@ulke", textBox2.Text);


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
