using static AiSD_IO2_cw5.Drzewo;
using static AiSD_IO2_cw5.DrzewoBinarneKlasa;
using static AiSD_IO2_cw5.Graf;
using static AiSD_IO2_cw5.Przeszukiwanie;

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

        // Wyœwietlanie drzewa

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
            napis = WyswietlDrzewo(w1);
            MessageBox.Show(napis);
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

            napis = "";
            napis = PrzechodzenieWglab(g7);
            MessageBox.Show(napis);
        }


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
            napis = PrzechodzenieWszerz(d1);
            MessageBox.Show($"BFS: {napis}");

        }

        // Drzewo Binarne
        private void addToBinaryTree_Click(object sender, EventArgs e)
        {
            DrzewoBinarne drzewoBinarne = new(5);

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

            var wynikZnajdz = drzewoBinarne.Znajdz(50);
            if (wynikZnajdz is not null)
                MessageBox.Show($"Wartoœæ: {wynikZnajdz?.wartosc}, Rodzic: {wynikZnajdz.rodzic?.wartosc}, Prawe dziecko: {wynikZnajdz.praweDziecko?.wartosc}, Lewe Dziecko: {wynikZnajdz.leweDziecko?.wartosc}");
            else
                MessageBox.Show($"Wartoœæ to null");

            drzewoBinarne.Wypisz();
            MessageBox.Show(napis);
        }

        private void findMinAndMaxValue_Click(object sender, EventArgs e)
        {
            DrzewoBinarne drzewoBinarne = new(5);

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

            MessageBox.Show($"Minimalna w wêŸle {drzewoBinarne.ZnajdzMin(drzewoBinarne.Znajdz(8)).wartosc}");
            MessageBox.Show($"Maksymalna w wêŸle {drzewoBinarne.ZnajdzMax(drzewoBinarne.Znajdz(8)).wartosc}");
        }

        private void findNextAndPreviousValue_Click(object sender, EventArgs e)
        {
            DrzewoBinarne nastepnik = new(5);
            nastepnik.Add(4);
            nastepnik.Add(2);
            nastepnik.Add(1);
            nastepnik.Add(3);
            nastepnik.Add(6);
            nastepnik.Add(7);
            nastepnik.Add(10);
            nastepnik.Add(9);

            MessageBox.Show($"Nastêpnik: {nastepnik.Nastepnik(nastepnik.Znajdz(7)).wartosc}");
            MessageBox.Show($"Poprzednik: {nastepnik.Poprzednik(nastepnik.Znajdz(4)).wartosc}");
        }

        private void deleteValueFromTree_Click(object sender, EventArgs e)
        {
            DrzewoBinarne nastepnik = new(6);
            nastepnik.Add(5);
            nastepnik.Add(3);
            nastepnik.Add(2);
            nastepnik.Add(4);
            nastepnik.Add(1);
            nastepnik.Add(5);


            List<Wezel4> lista = nastepnik.WypiszSzczegoloweDane();
            string napis = "Przed: \n";

            foreach (var el in lista)
            {
                napis += $"wartoœæ {el.wartosc} - rodzic: {el.rodzic?.wartosc} - lewe dziecko: {el.leweDziecko?.wartosc} - prawe dziecko: {el.praweDziecko?.wartosc} \n";
            }

            MessageBox.Show(napis);

            nastepnik.Remove(nastepnik.Znajdz(3));

            napis = "Po: \n";
            lista = nastepnik.WypiszSzczegoloweDane();

            foreach (var el in lista)
            {
                napis += $"wartoœæ {el.wartosc} - rodzic: {el.rodzic?.wartosc} - lewe dziecko: {el.leweDziecko?.wartosc} - prawe dziecko: {el.praweDziecko?.wartosc} \n";
            }

            MessageBox.Show(napis);
        }

        private void DijsktraAlgorytm_Click(object sender, EventArgs e)
        {
            AlgorytmDijkstry.StartFunction();
        }
    }
    // Algorytm Dijkstry

    // KLASY WÊZÊ£
    public class WezelGlowny
    {
        public int wartosc;
        public WezelGlowny(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}