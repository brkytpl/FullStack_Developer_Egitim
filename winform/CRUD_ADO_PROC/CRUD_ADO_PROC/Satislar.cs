using System;
using System.Collections;
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
    public partial class Satislar: Form
    {
        public Satislar()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=magaza;integrated security=true");
        //Listeleme metodu parametreli
        public void Listeleme(string proc_adi)
        {
            SqlCommand cmd = new SqlCommand(proc_adi, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        //Lİsteleme butonu
        private void button2_Click(object sender, EventArgs e)
        {
            Listeleme("sListele");
        }

        //Kaydet butonu
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sKaydet", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("musteri",textBox1.Text);
            cmd.Parameters.AddWithValue("urun", textBox2.Text);
            cmd.Parameters.AddWithValue("fiyat", textBox3.Text);
            cmd.Parameters.AddWithValue("adet",Convert.ToInt32( textBox4.Text));
            cmd.Parameters.AddWithValue("odeme", textBox5.Text);
            cmd.ExecuteNonQuery();

            connection.Close();
            Listeleme("sListele");
        }
        // Adet textbox
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0 && textBox4.Text.Length>0)
            {
                textBox6.Text=Convert.ToString(Convert.ToDecimal(textBox3.Text)*Convert.ToInt32(textBox4.Text));
            }
            if (textBox4.Text.Length ==0)
            {
                textBox6.Text=string.Empty;
            }
        }
        ArrayList secilen = new ArrayList();//TOplu silme için ıd leri
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            if (e.ColumnIndex == 1)
            {
                Guncelle guncelle = new Guncelle();
                guncelle.Show();
                guncelle.textBox1.Tag = satir.Cells["id"].Value.ToString();
                guncelle.textBox1.Text = satir.Cells["musteri"].Value.ToString();
                guncelle.textBox2.Text = satir.Cells["urun"].Value.ToString();
                guncelle.textBox3.Text = satir.Cells["fiyat"].Value.ToString();
                guncelle.textBox4.Text = satir.Cells["adet"].Value.ToString();
                guncelle.textBox5.Text = satir.Cells["odeme"].Value.ToString();

            }
            if (e.ColumnIndex == 2)
            {
                //Sil sil = new Sil();
                //sil.Show();
                //sil.label2.Text= satir.Cells["id"].Value.ToString();
                //MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Silmek istediğinize eminmisiniz", "Dikkat!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sSil", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", satir.Cells["id"].Value.ToString());
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            //if (e.ColumnIndex == 0)
            //{
            //    secilen.Add(satir.Cells["id"].Value.ToString());

            //}
            if (e.ColumnIndex == 0)
            {
                button3.Visible = true;
            }
        }
        //Çoklu sil butonu
        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            for (int i = 0;i<dataGridView1.RowCount;i++)
            {
                row= dataGridView1.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value)==true)
                {
                    secilen.Add(row.Cells["id"].Value.ToString());
                }
            }
            foreach(var x in secilen)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sSil", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", x);
                cmd.ExecuteNonQuery();
                connection.Close();
               
            }
            Listeleme("sListele");
        }

        private void Satislar_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //    if(comboBox1.SelectedIndex == 0)
            //    {
            //        SqlCommand cmd = new SqlCommand("sAra_musteri",connection);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("musteri",textBox7.Text);
            //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //        DataTable dataTable = new DataTable();
            //        adapter.Fill(dataTable);
            //        dataGridView1.DataSource = dataTable;
            //    }
            //    else if(comboBox1.SelectedIndex==1)
            //    {
            //        SqlCommand cmd = new SqlCommand("sAra_urun", connection);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("urun", textBox7.Text);
            //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //        DataTable dataTable = new DataTable();
            //        adapter.Fill(dataTable);
            //        dataGridView1.DataSource = dataTable;
            //    }
            SqlCommand cmd = new SqlCommand("sAra", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("secim",comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("aranan", textBox7.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
