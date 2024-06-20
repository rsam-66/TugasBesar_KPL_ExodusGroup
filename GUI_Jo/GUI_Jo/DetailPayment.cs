using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Jo
{
    public partial class DetailPayment : Form
    {
        public DetailPayment(string detailPembayaran)
        {
            InitializeComponent();
            label1.Text = detailPembayaran;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Tutup halaman DetailPayment
            this.Close();

            // Buka halaman Home
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
