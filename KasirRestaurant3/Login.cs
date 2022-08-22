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

namespace KasirRestaurant3
{
    public partial class Login : Form
    {
        //KONEKSI
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OGQRBL1\RPL_123; Initial Catalog=db_restaurant_3; Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VALIDASI LOGIN
            conn.Open();
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong");
            }

            else
            {
                //USER DI DATABASE EROR (HARUS MAKE USER5)
                SqlDataAdapter sda = new SqlDataAdapter("Select * from user5 where Username = '"+textBox1.Text+"' and Password = '"+textBox2.Text+"'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Username"].ToString() == "admin")
                        {
                            this.Hide();
                            AdminForm af = new AdminForm();
                            af.Show();
                        }

                        else if (dr["Password"].ToString() == "kasir")
                        {
                            this.Hide();
                            KasirForm kf = new KasirForm();
                            kf.Show();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Username atau Password Tidak Tersedia. Mohon Hubungi Admin");
                }
            }
            conn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "Restaurant";
        }
    }
}
