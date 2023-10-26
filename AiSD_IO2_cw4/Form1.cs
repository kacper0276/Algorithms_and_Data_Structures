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
                while(j >= 0 && arr[j] > actualValue)
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

        public void MergeSort(List<int> arr)
        {

        }

        public void QuickSort(List<int> arr)
        {
            DateTime timeStart = DateTime.Now;
        }

        // Bubbling sort Button
        private void button1_Click(object sender, EventArgs e)
        {
            string separator = separatorSelected.Text == "spacja" ? " " : separatorSelected.Text;
            if (textBox1.Text.Contains(separator))
            {
                string numbers = textBox1.Text;
                numbers = numbers.Replace(" ", string.Empty);
                string[] numbersArr = numbers.Split(separator);
                List<int> list = new List<int>();

                foreach (string number in numbersArr)
                {
                    list.Add(int.Parse(number));
                }

                double time = SortFun(list);

                string res = "";
                for (int i = 0; i < list.Count; i++)
                {

                    string actualValue = i < list.Count - 1 ? "" + list.ElementAt(i) + ", " : "" + list.ElementAt(i);
                    res += actualValue;
                }

                wynik.Text = res;
                timeLabel.Text = time + "ms";
            } else
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
                string numbers = textBox1.Text;
                numbers = separatorSelected.Text == "spacja" ? numbers : numbers.Replace(" ", string.Empty);
                string[] numbersArr = numbers.Split(separator);
                List<int> list = new List<int>();

                foreach (string number in numbersArr)
                {
                    list.Add(int.Parse(number));
                }

                double time = SelectionSort(list);

                string res = "";
                for (int i = 0; i < list.Count; i++)
                {

                    string actualValue = i < list.Count - 1 ? "" + list.ElementAt(i) + ", " : "" + list.ElementAt(i);
                    res += actualValue;
                }

                timeLabel.Text = time + "ms";
                wynik.Text = res;
            } else
            {
                MessageBox.Show("Wybierz poprawny separator");
            }
            
        }

        // Active left or right
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox1.Enabled = true;
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
                string numbers = textBox1.Text;
                numbers = separatorSelected.Text == "spacja" ? numbers : numbers.Replace(" ", string.Empty);
                string[] numbersArr = numbers.Split(separator);
                List<int> list = new List<int>();

                foreach (string number in numbersArr)
                {
                    list.Add(int.Parse(number));
                }

                double time = InsertionSort(list);

                string res = "";
                for (int i = 0; i < list.Count; i++)
                {

                    string actualValue = i < list.Count - 1 ? "" + list.ElementAt(i) + ", " : "" + list.ElementAt(i);
                    res += actualValue;
                }

                timeLabel.Text = time + "ms";
                wynik.Text = res;
            }
            else
            {
                MessageBox.Show("Wybierz poprawny separator");
            }
        }
    }
}