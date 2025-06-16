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
using System.Xml.Linq;

namespace çalışma_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=Customers;integrated security=true");
        private void Listele()
        {
            
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Customers",conn );
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

       //Ekle butonu
        private void button1_Click(object sender, EventArgs e)

        {
            
            {
                conn.Open();
                string query = "INSERT INTO Customers (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name",textBox1.Text);
                cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri Eklendi");
                Listele();

            }
        }
        //Lİstele butonu
        private void button2_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
            textBox1.Tag = dataGridView1.CurrentRow.Cells["Id"].Value.ToString(); // gizli bir textbox
        }
        //Güncelle Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            
            {
                conn.Open();
                string query = "UPDATE Customers SET Name=@Name, Email=@Email, Phone=@Phone WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
                cmd.Parameters.AddWithValue("@Id", textBox1.Tag);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri güncellendi.");
                Listele();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            {
                conn.Open();
                string query = "DELETE FROM Customers WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", textBox1.Tag);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri silindi.");
                Listele();
            }
        }
    }
}
