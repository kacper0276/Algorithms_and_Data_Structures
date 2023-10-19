using System.Numerics;

namespace AiSD_IO2_cw1
{
    class dodawanie
    {
        // http://kurs.aspnetmvc.pl/Csharp/Przeciazanie_operatorow
    }

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

        BigInteger Fib2(int n)
        {
            List<BigInteger> l = new List<BigInteger>();
            l.Add(0);
            l.Add(1);

            //int[] w = new int[n + 1];
            //for(int i = 2; i <= n; i++)
            //{
            //  w[i] = w[i - 1] + w[i - 2];
            //}

            for(int i = 0; i <= n; i++)
            {
                l.Add(l[i] + l[i + 1]);
            }

            return l[n];
        }

        int[] Dodawanie(int[] arr1, int[] arr2)
        {
            int length = arr1.Length > arr2.Length ? arr1.Length + 1 : arr2.Length + 1;
            int[] result = new int[length];
            int r = 0;
            for (int i = 0; i < length - 1; i++)
            {
                int w = arr1[i] + arr2[i] + r;
                
                if(w >= 10)
                {
                    r = (w - w % 10)/10;
                    result[i] = w % 10;
                } 
                else
                {
                    result[i] = w;
                }

                if(i == length && r != 0)
                {
                    result[length] = r;
                }

            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int liczbaN = (int)nudLiczbaN.Value;
            BigInteger result = Fib2(liczbaN);

            MessageBox.Show("" + result);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int liczbaN = (int)nudLiczbaN.Value;
            BigInteger result = Fib(liczbaN);

            MessageBox.Show("" + result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] arr1 = { 4, 5, 1 };
            int[] arr2 = { 6, 8, 7 };

            int[] res = Dodawanie(arr1, arr2);
            string result = "";
            for(int i = 0; i < res.Length; i++)
            {
                if (i == res.Length - 1 && res[i] == 0) continue;
                else
                {
                    result += res[i];
                }
            }

            MessageBox.Show("" + result);
        }
    }
}