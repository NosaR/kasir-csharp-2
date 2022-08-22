using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirRestaurant3
{
    public partial class KasirForm : Form
    {
        public KasirForm()
        {
            InitializeComponent();
        }

        private void KasirForm_Load(object sender, EventArgs e)
        {
            this.Text = "Restaurant";
            uC_Laporan1.Visible = false;
            uC_Transaksi21.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_Transaksi21.Visible = true;
            uC_Laporan1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uC_Laporan1.Visible = true;
            uC_Transaksi21.Visible = false;
        }

        private void uC_Laporan1_Load(object sender, EventArgs e)
        {

        }
    }
}
