using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_ADO_PROC
{
    public partial class Resim: Form
    {
        public Resim()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=magaza;integrated security=true");
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox1.Text=openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update Musteriler set resim =@resim",connection);
            cmd.Parameters.AddWithValue("@resim",textBox1.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        //Dosyaya yaz
        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("veri.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(textBox2.Text);
            streamWriter.Close();
        }
        //Dosyadan oku
        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fileStream= new FileStream("veri.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fileStream);
            //listBox1.Items.Add(sr.ReadLine());
            string line = sr.ReadLine();
            while (line != null)
            {
                listBox1.Items.Add(line);
                line = sr.ReadLine();

            }
            sr.Close();
            fileStream.Close();
        }
    }
}
