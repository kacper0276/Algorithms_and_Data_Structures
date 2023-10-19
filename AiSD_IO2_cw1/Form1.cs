namespace AiSD_IO2_cw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int liczbaN = (int)nudLiczbaN.Value;
            int result = Fib(liczbaN);

            MessageBox.Show("" + result);
        }
    }
}