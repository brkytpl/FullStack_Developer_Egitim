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

namespace CRUD_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=Kutuphane;integrated security=true;");
        //("Server=BERKAY\\SQLEXPRESS;Database=Kutuphane;uid=kullanıcıadı;pwd=şifre;"); 
        //Kaydetme işlemi
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Kitaplar (kitapad,yazarad,basimtarihi,sayfasayisi,baskisayisi) values (@kitapad,@yazarad,@basimtarihi,@sayfasayisi,@baskisayisi)", baglanti);

            command.Parameters.AddWithValue("@kitapad", textBox1.Text);
            command.Parameters.AddWithValue("@yazarad", textBox2.Text);
            command.Parameters.AddWithValue("@basimtarihi", Convert.ToDateTime(dateTimePicker1.Text));
            command.Parameters.AddWithValue("@sayfasayisi", Convert.ToInt32(textBox3.Text));
            command.Parameters.AddWithValue("@baskisayisi", Convert.ToInt32(numericUpDown1.Value));

            command.ExecuteNonQuery();
            listeleme();
            temizleme();

            baglanti.Close();
        }
        //Listeleme işlemi
        public void listeleme()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Kitaplar", baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }
        //temizleme metodu
        public void temizleme()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listeleme();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listeleme();
        }
        //Datagridwievden seçme işlemi
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["id"].Value.ToString();
            textBox1.Text = satir.Cells["kitapad"].Value.ToString();
            textBox2.Text = satir.Cells["yazarad"].Value.ToString();
            dateTimePicker1.Text = satir.Cells["basimtarihi"].Value.ToString();
            textBox3.Text = satir.Cells["sayfasayisi"].Value.ToString();
            //numericUpDown1.Value = satir.Cells["baskisayisi"].Value.ToString();
        }
        //Silme işlemi
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("delete from Kitaplar where id=@id", baglanti);
            command.Parameters.AddWithValue("@id", textBox1.Tag);
            command.ExecuteNonQuery();
            baglanti.Close();
            listeleme();
            temizleme();
        }
        //Güncelleme işlemi
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("update Kitaplar set kitapad=@kitapad,yazarad=@yazarad,basimtarihi=@basimtarihi,sayfasayisi=@sayfasayisi,baskisayisi=@baskisayisi where id=@id ",baglanti);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Tag));
            command.Parameters.AddWithValue("@kitapad", textBox1.Text);
            command.Parameters.AddWithValue("@yazarad", textBox2.Text);
            command.Parameters.AddWithValue("@basimtarihi", Convert.ToDateTime(dateTimePicker1.Text));
            command.Parameters.AddWithValue("@sayfasayisi", Convert.ToInt32(textBox3.Text));
            command.Parameters.AddWithValue("@baskisayisi", Convert.ToInt32(numericUpDown1.Value));

            command.ExecuteNonQuery();

            baglanti.Close();
            listeleme();
            temizleme();
        }

    }
}
