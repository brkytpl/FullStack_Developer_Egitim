using System.Linq;
using System.Windows.Forms;

namespace kütüphane_modelFirst
{
    public partial class Sec : Form
    {
        public Sec()
        {
            InitializeComponent();
        }
        Model1Container1 db = new Model1Container1();
        private void Sec_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = db.UyelerSet.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            IslemEkle islemEkle = new IslemEkle();
            islemEkle.textBox1.Text = satir.Cells["Tc"].Value.ToString();
            islemEkle.Show();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            //like '%metin%'
            //like '%metin'
            //like 'metin%
            string aranan = textBox1.Text;
            var liste=db.UyelerSet.Where(x=>x.AdSoyad.Contains(aranan)).ToList();
            dataGridView1.DataSource=liste;
        }
    }
}
