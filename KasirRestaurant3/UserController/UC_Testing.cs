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

namespace KasirRestaurant3.UserController
{
    public partial class UC_Testing : UserControl
    {
        //KONEKSI
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OGQRBL1\RPL_123; Initial Catalog=db_restaurant_3; Integrated Security=True");

        //MEMANGGIL QUERY, FUNCTION, DAN ID
        String query;
        Function fn = new Function();
        public UC_Testing()
        {
            InitializeComponent();
        }

        //UNTUK MENAMPILKAN DATA KE DATAGRID
        public void LoadDataGrid()
        {
            query = "SELECT Namamenu,Harga,Jumlah FROM pesanan3,menu WHERE pesanan3.Idmenu = menu.Idmenu";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_Testing_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                bool column1 = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0]);
                SqlCommand cmd = new SqlCommand(@"INSERT INTO testing (Bayar,Namamenu,Harga,Jumlah) VALUES ('" + column1 + "', '" + dataGridView1.Rows[i].Cells[1] + "', '" + dataGridView1.Rows[i].Cells[2] + "', '" + dataGridView1.Rows[i].Cells[3] + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Berhasil Disimpan");
            }

            //dataGridView1.Rows.Clear();
        }
    }
}
