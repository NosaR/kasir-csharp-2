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

namespace KasirRestaurant3.UserController
{
    public partial class UC_Transaksi : UserControl
    {
        //KONEKSI
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OGQRBL1\RPL_123; Initial Catalog=db_restaurant_3; Integrated Security=True");

        //MEMANGGIL QUERY, FUNCTION, DAN ID
        String query;
        Function fn = new Function();

        public UC_Transaksi()
        {
            InitializeComponent();
        }

        //UNTUK MENGOSONGKAN DATA
        public void ClearData()
        {
            dataGridView1.DataSource = null;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        //UNTUK MENAMPILKAN DATA KE DATAGRID
        public void LoadDataGrid()
        {
            query = "SELECT Namamenu,Harga,Jumlah FROM pesanan,menu WHERE pesanan.Idmenu = menu.Idmenu AND Idpesanan='" + textBox1.Text + "'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_Transaksi_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        double total1;
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGrid();

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                total1 += double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            Int64 total = Int64.Parse(textBox4.Text);
            Int64 bayar = Int64.Parse(textBox4.Text);
        }
    }
}
