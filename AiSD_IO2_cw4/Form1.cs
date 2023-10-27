using System.Collections.Generic;

namespace AiSD_IO2_cw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateNumber.Enabled = false;
            generateButton.Enabled = false;
            checkBox1.Checked = true;
            separatorSelected.SelectedText = ";";
            separatorSelected.Text = ";";
        }

        public void Swap(List<int> arr, int index1, int index2)
        {
            int element1 = arr[index1];

            arr[index1] = arr[index2];
            arr[index2] = element1;
        }

        public List<int> GetList(string separator)
        {
            string numbers = textBox1.Text;
            numbers = separatorSelected.Text == "spacja" ? numbers : numbers.Replace(" ", string.Empty);
            string[] numbersArr = numbers.Split(separator);
            List<int> list = new List<int>();

            foreach (string number in numbersArr)
            {
                list.Add(int.Parse(number));
            }

            return list;
        }

        public string ResultAsString(List<int> list)
        {
            string res = "";
            for (int i = 0; i < list.Count; i++)
            {

                string actualValue = i < list.Count - 1 ? "" + list.ElementAt(i) + ", " : "" + list.ElementAt(i);
                res += actualValue;
            }

            return res;
        }

        public void GenerateRandom()
        {
            if (!checkBox1.Checked && generateNumber.Value != 0)
            {
                string separator = separatorSelected.Text == "spacja" ? " " : separatorSelected.Text;
                string res = "";
                for (int i = 0; i < generateNumber.Value; i++)
                {
                    Random rdm = new Random();
                    int num = rdm.Next(1, 200);
                    string optional = i == generateNumber.Value - 1 ? " " : separator + " ";
                    res += num + optional;
                    
                }
                MessageBox.Show("Twoje liczby zostały wylosowane!");
                textBox1.Text = res.Trim();
            }
        }

        // Bubbling sort
        public double SortFun(List<int> arr)
        {
            DateTime timeStart = DateTime.Now;
            bool cbz = false;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = 0; j < arr.Count - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        cbz = true;
                    }
                }
                if (!cbz)
                    break;
                else
                    cbz = false;

            }
            DateTime timeEnd = DateTime.Now;
            TimeSpan time = timeEnd - timeStart;
            var seconds = time.TotalMilliseconds;
            return seconds;
        }

        public double SelectionSort(List<int> arr)
        {
            DateTime timeStart = DateTime.Now;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                Swap(arr, min, i);
            }
            DateTime timeEnd = DateTime.Now;
            TimeSpan time = timeEnd - timeStart;
            var seconds = time.TotalMilliseconds;
            return seconds;
        }

        public double InsertionSort(List<int> arr)
        {
            DateTime timeStart = DateTime.Now;
            for (int i = 0; i < arr.Count; i++)
            {
                int actualValue = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > actualValue)
                {
                    Swap(arr, j + 1, j);
                    j--;
                }
                arr[j + 1] = actualValue;
            }
            DateTime timeEnd = DateTime.Now;
            TimeSpan time = timeEnd - timeStart;
            var seconds = time.TotalMilliseconds;
            return seconds;
        }

        public void Merge(List<int> arr, List<int> arr1, List<int> result)
        {
            result.Clear();
            int a = 0, b = 0;
            while(a < arr.Count && b < arr1.Count)
            {
                if(arr.ElementAt(a) > arr1.ElementAt(b))
                {
                    result.Add(arr1.ElementAt(b));
                    b++;
                } else
                {
                    result.Add(arr.ElementAt(a));
                    a++;
                }
            }

            while(a < arr.Count)
            {
                result.Add(arr.ElementAt(a));
                a++;
            }

            while (b < arr1.Count)
            {
                result.Add(arr1.ElementAt(b));
                b++;
            }
        } 

        public double MergeSort(List<int> arr)
        {
            DateTime timeStart = DateTime.Now;
            
            int half = arr.Count / 2;

            List<int> left = arr.GetRange(0, half);
            List<int> right = arr.GetRange(half, arr.Count - half);

            SortFun(left);
            SortFun(right);

            Merge(left, right, arr);

            DateTime timeEnd = DateTime.Now;
            TimeSpan time = timeEnd - timeStart;
            var seconds = time.TotalMilliseconds;
            return seconds;
        }

        public int SortQuick(List<int> arr, int low, int hight)
        {
            int pivot = arr.ElementAt(hight);

            int i = low - 1;

            for(int j = low; j <= hight - 1; j++)
            {
                if(arr.ElementAt(j) < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, hight);
            return i + 1;
        }

        public double QuickSort(List<int> arr, int low, int hight)
        {
            DateTime timeStart = DateTime.Now;
            
            if(low < hight)
            {
                int pozycja = SortQuick(arr, low, hight);

                QuickSort(arr, low, pozycja - 1);
                QuickSort(arr, pozycja + 1, hight);
            }

            DateTime timeEnd = DateTime.Now;
            TimeSpan time = timeEnd - timeStart;
            var seconds = time.TotalMilliseconds;
            return seconds;
        }

        // Bubbling sort Button
        private void button1_Click(object sender, EventArgs e)
        {
            string separator = separatorSelected.Text == "spacja" ? " " : separatorSelected.Text;
            if (textBox1.Text.Contains(separator))
            {
                List<int> list = GetList(separator);

                double time = SortFun(list);

                string res = ResultAsString(list);

                wynik.Text = res;
                timeLabel.Text = time + "ms";
            }
            else
            {
                MessageBox.Show("Wybierz poprawny separator");
            }

        }

        // SS button
        private void button2_Click(object sender, EventArgs e)
        {
            string separator = separatorSelected.Text == "spacja" ? " " : separatorSelected.Text;
            if (textBox1.Text.Contains(separator))
            {

                List<int> list = GetList(separator);

                double time = SelectionSort(list);

                string res = ResultAsString(list);

                timeLabel.Text = time + "ms";
                wynik.Text = res;
            }
            else
            {
                MessageBox.Show("Wybierz poprawny separator");
            }

        }

        // Active left or right
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                generateNumber.Enabled = false;
                generateButton.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
                generateNumber.Enabled = true;
                generateButton.Enabled = true;
            }
        }

        private void sortInsert_Click(object sender, EventArgs e)
        {
            string separator = separatorSelected.Text == "spacja" ? " " : separatorSelected.Text;
            if (textBox1.Text.Contains(separator))
            {
                List<int> list = GetList(separator);

                double time = InsertionSort(list);

                string res = ResultAsString(list);


                timeLabel.Text = time + "ms";
                wynik.Text = res;
            }
            else
            {
                MessageBox.Show("Wybierz poprawny separator");
            }
        }

        // Merge Sort Button
        private void button5_Click(object sender, EventArgs e)
        {
            string separator = separatorSelected.Text == "spacja" ? " " : separatorSelected.Text;
            if (textBox1.Text.Contains(separator))
            {
                List<int> list = GetList(separator);

                double time = MergeSort(list);

                string res = ResultAsString(list);

                timeLabel.Text = time + "ms";
                wynik.Text = res;
            }
            else
            {
                MessageBox.Show("Wybierz poprawny separator");
            }
        }

        private void quickSortButton_Click(object sender, EventArgs e)
        {
            string separator = separatorSelected.Text == "spacja" ? " " : separatorSelected.Text;
            if (textBox1.Text.Contains(separator))
            {

                List<int> list = GetList(separator);
                int size = list.Count - 1;
                double time = QuickSort(list, 0 , size);

                string res = ResultAsString(list);

                timeLabel.Text = time + "ms";
                wynik.Text = res;
            }
            else
            {
                MessageBox.Show("Wybierz poprawny separator");
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            GenerateRandom();
        }
    }
}