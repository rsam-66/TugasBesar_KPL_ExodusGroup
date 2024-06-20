namespace GUI_Jo
{
    public partial class PaymentMethod : Form
    {
        public PaymentMethod()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Tutup halaman PaymentMethod
            this.Close();

            // Buka halaman Home
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string detailPembayaran = "Detil Pembayaran";
            DetailPayment detailPayment = new DetailPayment(detailPembayaran);
            detailPayment.Show();
        }
    }
}
