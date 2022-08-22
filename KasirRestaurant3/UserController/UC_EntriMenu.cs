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
    public partial class UC_EntriMenu : UserControl
    {
        //KONEKSI
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OGQRBL1\RPL_123; Initial Catalog=db_restaurant_3; Integrated Security=True");

        //MEMANGGIL QUERY, FUNCTION, DAN ID
        String query;
        Function fn = new Function();
        int id;

        public UC_EntriMenu()
        {
            InitializeComponent();
        }

        //MENAMPILKAN DATA KE DALAM DATAGIRDVIEW
        public void LoadDataGrid()
        {
            query = "SELECT * FROM menu order by Namamenu asc";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_EntriMenu_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        //INSERT
        private void button1_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO menu (Namamenu, Harga) VALUES ('" + textBox1.Text + "', '"+textBox2.Text+"')";
            fn.SetData(query);
            LoadDataGrid();
        }

        //UPDATE
        private void button2_Click(object sender, EventArgs e)
        {
            query = "UPDATE menu SET Namamenu='" + textBox1.Text + "', Harga='"+textBox2.Text+"' WHERE Idmenu='" + id + "'";
            fn.UpdateData(query);
            LoadDataGrid();
        }

        //DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM menu WHERE Idmenu='" + id + "'";
            fn.DeleteData(query);
            LoadDataGrid();
        }

        //MENGAMBIL DATA DARI DATAGRIDVIEW
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Namamenu = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int harga = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

            textBox1.Text = Namamenu;
            textBox2.Text = harga.ToString();
        }
    }
}
