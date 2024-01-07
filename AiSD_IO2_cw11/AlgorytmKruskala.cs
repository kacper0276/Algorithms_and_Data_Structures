namespace AiSD_IO2_cw5
{
    public class AlgorytmKruskala
    {
        public class Krawedz
        {
            public int waga, poczatek, koniec;

            public Krawedz(int waga, int poczatek, int koniec)
            {
                this.waga = waga;
                this.poczatek = poczatek;
                this.koniec = koniec;
            }
        }

        public class Wezel6
        {
            public int wartosc;
            public List<Krawedz> list = new();

            public void AddToKrawdzList(Krawedz krawedz) { list.Add(krawedz); }

            public Wezel6(int wartosc, Krawedz krawedz)
            {
                this.wartosc = wartosc;
                list.Add(krawedz);
            }
        }

        public class Graf
        {
            public List<int> listaWezlow;
            public List<Krawedz> listaKrawedzi;

            public Graf() {}

            public Graf(List<Krawedz> listaKrawedzi)
            {
                this.listaKrawedzi = listaKrawedzi;
            }

            public Graf(Krawedz krawedz)
            {
                this.listaKrawedzi!.Add(krawedz);
            }

            public int Sprawdz(Krawedz k)
            {
                int r = 0;
                if (this.listaWezlow.Contains(k.poczatek))
                {
                    r++;
                }
                if (this.listaWezlow.Contains(k.koniec))
                {
                    r++;
                }

                return r;
            }

            public void Add(Krawedz k)
            {   
                int wynik = this.Sprawdz(k);

                switch(wynik)
                {
                    case 0:
                        break;
                    case 1:

                        break;
                    case 2:
                        break;
                    default:
                        MessageBox.Show("Błąd Aplikacji!");
                        break;
                }
            }

            public void Join(Graf g)
            {
                foreach(var k in g.listaKrawedzi)
                {
                    this.Add(k);
                }
            }

            public Graf AlgKruskala(List<Krawedz> listaKrawedzi)
            {
                this.listaKrawedzi.Add(listaKrawedzi[0]);
                listaWezlow.Add(listaKrawedzi[0].poczatek);
                listaWezlow.Add(listaKrawedzi[0].koniec);
                List<Graf> listaGrafow = new()
                {
                    this
                };

                for (int i = 1; i < listaKrawedzi.Count; i++)
                {

                }

                return this;
            }
        }

        public static List<Krawedz> StworzKrawedzie()
        {
            List<Krawedz> listaKrawedzi = new();
            Krawedz k1 = new(5, 0, 1);
            Krawedz k2 = new(9, 0, 3);
            Krawedz k3 = new(3, 0, 6);
            Krawedz k4 = new(6, 1, 5);
            Krawedz k5 = new(8, 1, 4);
            Krawedz k6 = new(9, 1, 2);
            Krawedz k7 = new(7, 1, 7);
            Krawedz k8 = new(9, 2, 3);
            Krawedz k9 = new(4, 2, 4);
            Krawedz k10 = new(5, 2, 6);
            Krawedz k11 = new(3, 2, 7);
            Krawedz k12 = new(8, 3, 6);
            Krawedz k13 = new(2, 4, 5);
            Krawedz k14 = new(1, 4, 6);
            Krawedz k15 = new(6, 5, 6);
            Krawedz k16 = new(9, 6, 7);

            listaKrawedzi.Add(k1);
            listaKrawedzi.Add(k2);
            listaKrawedzi.Add(k3);
            listaKrawedzi.Add(k4);
            listaKrawedzi.Add(k5);
            listaKrawedzi.Add(k6);
            listaKrawedzi.Add(k7);
            listaKrawedzi.Add(k8);
            listaKrawedzi.Add(k9);
            listaKrawedzi.Add(k10);
            listaKrawedzi.Add(k11);
            listaKrawedzi.Add(k12);
            listaKrawedzi.Add(k13);
            listaKrawedzi.Add(k14);
            listaKrawedzi.Add(k15);
            listaKrawedzi.Add(k16);

            var wynik = listaKrawedzi.OrderBy(k => k.waga);

            return wynik.ToList();
        }
        
        public static void StartFunction()
        {
            List<Krawedz> listaKrawedzi = StworzKrawedzie();
            Graf g0 = new Graf().AlgKruskala(listaKrawedzi);

            
        }
    }
}
