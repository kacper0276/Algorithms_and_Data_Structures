using System.Collections.Generic;

namespace AiSD_IO2_cw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SortFun(List<int> arr) 
        {
            bool cbz = false;
            for(int i = 0; i < arr.Count - 1; i++)
            {
                for(int j = 0; j < arr.Count - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int a = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = a;
                        cbz = true;
                    }
                }
                if (!cbz)
                    break;
                else
                    cbz = false;

            }
            // Zbêdne - ju¿ przekazujemy referencjê
            // return arr;
        }

        public void SortZLekcji(int[] arr)
        {
            bool cbz = false;
            do
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    cbz = false;
                    if (arr[j] > arr[j + 1])
                    {
                        int a = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = a;
                        cbz = true;
                    }
                }
            } while (cbz);
        }

        public void SelectionSort(List<int> arr)
        {
            for(int i = 0; i < arr.Count - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numbers = textBox1.Text;
            numbers = numbers.Replace(" ", string.Empty);
            string[] numbersArr = numbers.Split(",");
            List<int> list = new List<int>();

            foreach(string number in numbersArr)
            {
                list.Add(int.Parse(number));
            }

            // Zbêdne - ju¿ przekazujemy referencjê
            //List<int> result = SortFun(list);

            SortFun(list);

            string res = "";
            for(int i = 0; i < list.Count; i++)
            {

                string actualValue = i < list.Count - 1 ? "" + list.ElementAt(i) + ", " : "" + list.ElementAt(i);
                res += actualValue;
            }



            wynik.Text = res;
            // MessageBox.Show(res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numbers = textBox1.Text;
            numbers = numbers.Replace(" ", string.Empty);
            string[] numbersArr = numbers.Split(",");
            List<int> list = new List<int>();

            foreach (string number in numbersArr)
            {
                list.Add(int.Parse(number));
            }

            SelectionSort(list);

            string res = "";
            for (int i = 0; i < list.Count; i++)
            {

                string actualValue = i < list.Count - 1 ? "" + list.ElementAt(i) + ", " : "" + list.ElementAt(i);
                res += actualValue;
            }



            wynik.Text = res;
        }
    }
}