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
    public partial class UC_Transaksi2 : UserControl
    {
        //KONEKSI
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OGQRBL1\RPL_123; Initial Catalog=db_restaurant_3; Integrated Security=True");

        //MEMANGGIL QUERY, FUNCTION, DAN ID
        String query, query2, query3;
        Function fn = new Function();
        public UC_Transaksi2()
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
            query = "SELECT Namamenu,Harga,Jumlah FROM pesanan3,menu WHERE pesanan3.Idmenu = menu.Idmenu AND Idpesanan='" + textBox1.Text + "'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void LoadDataGrid2()
        {
            query = "SELECT * FROM pesanan3";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_Transaksi2_Load(object sender, EventArgs e)
        {
            //LoadDataGrid2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Int64 total = Int64.Parse(textBox4.Text);
            //Int64 bayar = Int64.Parse(textBox3.Text);
            //label5.Text = "Rp. " + (bayar - total).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO transaksi2 (Idpesanan,Total) VALUES ('" + textBox1.Text + "', '" + textBox4.Text + "')";
            fn.SetData(query);
            ClearData();
        }

        double total1;
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
            query = "SELECT SUM (TotalHarga) AS Total FROM pesanan3 WHERE Idpesanan='" + textBox1.Text + "'";
            DataSet ds = fn.GetData(query);

            textBox4.Text = ds.Tables[0].Rows[0][0].ToString();

            query2 = "SELECT DISTINCT (Namapelanggan) from pesanan3,pelanggan WHERE pesanan3.Idpelanggan = pelanggan.Idpelanggan AND Idpesanan='" + textBox1.Text + "'";
            DataSet ds2 = fn.GetData(query2);

            textBox2.Text = ds2.Tables[0].Rows[0][0].ToString();

            query3 = "SELECT COUNT (Idtransaksi) FROM transaksi2 WHERE Idtransaksi='" + textBox1.Text + "'";
            DataSet ds3 = fn.GetData(query3);
            int checkData = int.Parse(ds3.Tables[0].Rows[0][0].ToString());

            if (checkData > 0)
            {
                MessageBox.Show("Transaksi Sudah Ada");
                ClearData();
                textBox4.Clear();
            } else
            {
                MessageBox.Show("Data Berhasil Ditemukan");
            }
        }
    }
}
