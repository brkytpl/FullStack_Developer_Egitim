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
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=Kutuphane;integrated security=true;");

        //Giriş işlemi
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand command= new SqlCommand("select * from Kullanicilar where kullaniciad =@kadi and sifre=@sifre",baglanti);
            command.Parameters.AddWithValue("@kadi",textBox1.Text);
            command.Parameters.AddWithValue("sifre",textBox2.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            
            baglanti.Close();
        }
    }
}
