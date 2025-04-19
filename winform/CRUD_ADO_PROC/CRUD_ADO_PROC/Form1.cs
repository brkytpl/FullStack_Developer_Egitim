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

namespace CRUD_ADO_PROC
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection connection=new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=magaza;integrated security=true");

        public void Listeleme()
        {
            SqlCommand cmd = new SqlCommand("mListele",connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        //Listele butonu
        private void button4_Click(object sender, EventArgs e)
        {
            Listeleme();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listeleme();
        }
        //Kaydet butonu
        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "mKaydet";
            //cmd.Connection = connection;

            connection.Open();

            SqlCommand cmd = new SqlCommand("mKaydet", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("adi", textBox1.Text);
            cmd.Parameters.AddWithValue("adres", textBox2.Text);
            cmd.Parameters.AddWithValue("Il", textBox3.Text);
            cmd.Parameters.AddWithValue("Tel", textBox4.Text);
            cmd.ExecuteNonQuery();

            connection.Close();
            Listeleme();
        }
        //datagridview seçme işlemi
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir=dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["id"].Value.ToString();
            textBox1.Text= satir.Cells["mAd"].Value.ToString();
            textBox2.Text = satir.Cells["mAdres"].Value.ToString();
            textBox3.Text = satir.Cells["il"].Value.ToString();
            textBox4.Text = satir.Cells["tel"].Value.ToString();
        }
        //Güncellme butonu
        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("mGuncelle", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", textBox1.Tag);
            cmd.Parameters.AddWithValue("adi", textBox1.Text);
            cmd.Parameters.AddWithValue("adres", textBox2.Text);
            cmd.Parameters.AddWithValue("Il", textBox3.Text);
            cmd.Parameters.AddWithValue("Tel", textBox4.Text);
            cmd.ExecuteNonQuery();

            connection.Close();
            Listeleme();
        }
        //Silme İşlemi
        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("mSil", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", textBox1.Tag);
            cmd.ExecuteNonQuery();

            connection.Close();
            Listeleme();
        }
    }
}
