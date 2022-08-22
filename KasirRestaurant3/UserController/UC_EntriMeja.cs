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
    public partial class UC_EntriMeja : UserControl
    {
        //KONEKSI
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OGQRBL1\RPL_123; Initial Catalog=db_restaurant_3; Integrated Security=True");

        //MEMANGGIL QUERY, FUNCTION, DAN ID
        String query;
        Function fn = new Function();
        int id;
        public UC_EntriMeja()
        {
            InitializeComponent();
        }

        //MENAMPILKAN DATA KE DATAGRIDVIEW
        public void LoadDataGrid()
        {
            query = "SELECT * FROM meja order by Idmeja";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        //INSERT
        private void button1_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO meja (Namameja) VALUES ('" + textBox1.Text + "')";
            fn.SetData(query);
            LoadDataGrid();
        }

        private void UC_EntriMeja_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        //UPDATE
        private void button2_Click(object sender, EventArgs e)
        {
            query = "UPDATE meja SET Namameja='" + textBox1.Text + "' WHERE Idmeja='" + id + "'";
            fn.UpdateData(query);
            LoadDataGrid();
        }

        //DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM meja WHERE Idmeja='" + id + "'";
            fn.DeleteData(query);
            LoadDataGrid();
        }

        //MENGAMBIL DATA DARI DATAGRIDVIEW
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Namameja = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            textBox1.Text = Namameja;
        }
    }
}
