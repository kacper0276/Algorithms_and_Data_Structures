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
        public static string napis = "";

        // Wy�wietlanie drzewa
        public class Wezel : WezelGlowny
        {
            public List<Wezel> dzieci = new List<Wezel>();

            public Wezel(int liczba) : base(liczba)
            { }

        }

        void WyswietlDrzewo(Wezel w)
        {
            napis += w.wartosc.ToString() + ",";
            foreach (var w1 in w.dzieci)
            {
                WyswietlDrzewo(w1);
            }
        }
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
            WyswietlDrzewo(w1);
            MessageBox.Show(napis);
        }



        // Przechodzenie wg��b - Graf(nie tylko drzewo)
        public class Wezel2 : WezelGlowny
        {
            public List<Wezel2> sasiedzi = new();

            public Wezel2(int wartosc) : base(wartosc)
            { }
        }

        public List<Wezel2> odwiedzone = new();
        void PrzechodzenieWglab(Wezel2 w)
        {
            odwiedzone.Add(w);
            napis += w.wartosc.ToString() + ",";
            foreach (var w1 in w.sasiedzi)
            {
                if (!odwiedzone.Contains(w1))
                {
                    PrzechodzenieWglab(w1);
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
            PrzechodzenieWglab(g7);
            MessageBox.Show(napis);
        }

        // BFS
        public class Wezel3 : WezelGlowny
        {
            public List<Wezel3> dzieci = new();

            public Wezel3(int liczba) : base(liczba)
            { }
        }

        public void PrzechodzenieWszerz(Wezel3 w)
        {
            List<Wezel3> toVisit = new();

            toVisit.Add(w);

            for (int i = 0; i < toVisit.Count; i++)
            {
                var w1 = toVisit[i];
                napis += w1.wartosc + ", ";
                toVisit.RemoveAt(i--);
                foreach(var w2 in w1.dzieci)
                {
                    toVisit.Add(w2);
                }
            }
        }

        // BFS - bez cykli
        // Przeszukiwanie wszesz
        public void PrzeszukanieWszerz(Wezel2 w)
        {
            List<Wezel2> toVisit = new();

            toVisit.Add(w);

            for(int i = 0; i < toVisit.Count; i++)
            {
                var w1 = toVisit[i];
                napis += w1.wartosc + ", ";
                foreach (var w2 in w1.sasiedzi)
                {
                    toVisit.Add(w2);
                }
            }
        }

        /*
         5
        3 1
       2  4  8
        Wynik: 5, 3, 1, 2, 4, 8
         */
        private void przeszukanieWszerz_Click(object sender, EventArgs e)
        {
            Wezel3 d1 = new(5);
            Wezel3 d2 = new(3);
            Wezel3 d3 = new(1);
            Wezel3 d4 = new(2);
            Wezel3 d5 = new(4);
            Wezel3 d6 = new(8);
            d2.dzieci.Add(d4);
            d2.dzieci.Add(d5);
            d3.dzieci.Add(d6);
            d1.dzieci.Add(d2);
            d1.dzieci.Add(d3);

            napis = "";
            PrzechodzenieWszerz(d1);
            MessageBox.Show($"BFS: {napis}");

        }

        // Drzewo Binarne
        public static string napisBinarka = "";
        private void addToBinaryTree_Click(object sender, EventArgs e)
        {
            DrzewoBinarne drzewoBinarne = new(5);
            Wezel4 rodzic = new(5);

            drzewoBinarne.Add(4);
            drzewoBinarne.Add(7);
            drzewoBinarne.Add(2);
            drzewoBinarne.Add(3);
            drzewoBinarne.Add(6);
            drzewoBinarne.Add(6);
            drzewoBinarne.Add(5);
            drzewoBinarne.Add(5);
            drzewoBinarne.Add(8);
            drzewoBinarne.Add(11);

            drzewoBinarne.Wypisz();
            MessageBox.Show(napis);

        }
    }
    
    // Drzewo binarne
    public class Wezel4 : WezelGlowny
    {
        public Wezel4 rodzic;
        public Wezel4 praweDziecko;
        public Wezel4 leweDziecko;

        public Wezel4(int wartosc) : base(wartosc)
        {   }
    }

    class DrzewoBinarne
    {
        public Wezel4 korzen;
        public int liczbaWezlow;

        public DrzewoBinarne(int liczba)
        {
            this.korzen = new(liczba);
            this.liczbaWezlow = 1;
        }

        public void Wypisz()
        {
            List<Wezel4> toVisit = new();

            toVisit.Add(korzen);

            for(int i = 0; i < toVisit.Count; i++)
            {
                Form1.napis += toVisit[i].wartosc + ", ";
                if (toVisit[i].leweDziecko != null)
                {
                    toVisit.Add(toVisit[i].leweDziecko);
                }
                if (toVisit[i].praweDziecko != null)
                {
                    toVisit.Add(toVisit[i].praweDziecko);
                }
            }
        }

        public Wezel4 ZnajdzWezel(int liczba)
        {
            var w = this.korzen;
            while(true)
            {
                if (w.wartosc > liczba && w.leweDziecko is null)
                {
                    return w;
                }
                else if (w.wartosc <= liczba && w.praweDziecko is null)
                {
                    return w;
                }
                else if (w.wartosc > liczba)
                {
                    w = w.leweDziecko;
                }
                else
                {
                    w = w.praweDziecko;
                }
            }
        }

        /* Input: -3
         * 5 
          1  6
        -1
       -2
      -3
         */

        // Binarne drzewo poszukiwa�
        public void Add(int liczba)
        {
            Wezel4 w = ZnajdzWezel(liczba);
            if(w.wartosc > liczba)
            {
                w.leweDziecko = new Wezel4(liczba);
            }
            else
            {
                w.praweDziecko = new Wezel4(liczba);
            }
        }
    }

    // KLASY W�Zʣ
    public class WezelGlowny
    {
        public int wartosc;
        public WezelGlowny(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}