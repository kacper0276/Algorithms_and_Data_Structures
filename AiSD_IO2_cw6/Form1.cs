namespace AiSD_IO2_cw5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string napis = "";
        public List<Wezel2> odwiedzone = new();

        private void stworzwezel_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel(5);
            var d1 = new Wezel(2);
            var d2 = new Wezel(1);
            var d3 = new Wezel(3);
            var d11 = new Wezel(4);
            var d12 = new Wezel(6);
            d1.dzieci.Add(d11);
            d1.dzieci.Add(d12);
            w1.dzieci.Add(d1);
            w1.dzieci.Add(d2);
            w1.dzieci.Add(d3);
            napis = "";
            A(w1);
            MessageBox.Show(napis);
        }


        void A(Wezel w)
        {
            napis += w.wartosc.ToString() + ",";
            foreach (var w1 in w.dzieci)
            {
                A(w1);
            }
        }

        // Przechodzenie wg³¹b
        void B(Wezel2 w)
        {
            odwiedzone.Add(w);
            napis += w.wartosc.ToString() + ",";
            foreach (var w1 in w.sasiedzi)
            {
                if (!odwiedzone.Contains(w1))
                {
                    B(w1);
                }
            }
        }

        private void grafPokaz_Click(object sender, EventArgs e)
        {
            var g1 = new Wezel2(5);
            var g2 = new Wezel2(3);
            var g3 = new Wezel2(2);
            var g4 = new Wezel2(4);
            var g5 = new Wezel2(1);
            var g6 = new Wezel2(8);
            var g7 = new Wezel2(2);

            g1.sasiedzi.Add(g2);
            g2.sasiedzi.Add(g1);
            g3.sasiedzi.Add(g1);
            g1.sasiedzi.Add(g3);
            g3.sasiedzi.Add(g5);
            g5.sasiedzi.Add(g3);
            g6.sasiedzi.Add(g2);
            g2.sasiedzi.Add(g6);
            g6.sasiedzi.Add(g7);
            g7.sasiedzi.Add(g6);
            g5.sasiedzi.Add(g4);
            g4.sasiedzi.Add(g5);

            odwiedzone.Clear();
            napis = "";
            B(g7);
            MessageBox.Show(napis);
        }

        // Stworz BFS - przechodzenie wszerz
        /*
         5
        3 1
       2  4  8
        Wynik: 5, 3, 1, 2, 4, 8
         */

        private void przeszukanieWszerz_Click(object sender, EventArgs e)
        {

        }
    }

    public class WezelGlowny 
    {
        public int wartosc;
        public WezelGlowny(int liczba)
        {
            this.wartosc = liczba;
        }
    }

    public class Wezel : WezelGlowny
    {
        public List<Wezel> dzieci = new List<Wezel>();

        public Wezel(int liczba) : base(liczba)
        { }
        
    }

    public class Wezel2 : WezelGlowny
    {
        public List<Wezel2> sasiedzi = new();

        public Wezel2(int wartosc) : base(wartosc)
        { }
    }

    public class Wezel3 : WezelGlowny
    {
        public List<Wezel> dzieci = new List<Wezel>();

        public Wezel3(int liczba) : base(liczba)
        { }
    }
}