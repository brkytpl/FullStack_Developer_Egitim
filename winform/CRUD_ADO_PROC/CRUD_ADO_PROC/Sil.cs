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
    public partial class Sil: Form
    {
        public Sil()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=magaza;integrated security=true");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Evet butonu
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd= new SqlCommand("sSil",connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", label2.Text);
            cmd.ExecuteNonQuery();
            this.Close();

            connection.Close();
        }
    }
}
