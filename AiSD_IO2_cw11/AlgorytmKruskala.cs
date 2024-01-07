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
            public List<int> listaWezlow = new();
            public List<Krawedz> listaKrawedzi = new();
            public List<Graf> listaGrafow = new();

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
                if (!this.listaWezlow.Contains(k.poczatek))
                {
                    r++;
                }
                if (!this.listaWezlow.Contains(k.koniec))
                {
                    r++;
                }

                return r;
            }

            public void Add(Krawedz k)
            {
                int wynik = this.Sprawdz(k);

                switch (wynik)
                {
                    case 0:
                        break;
                    case 1:
                        List<Graf> list = new();

                        foreach (var g in this.listaGrafow)
                        {
                            int res = g.Sprawdz(k);
                            if (res == 1)
                            {
                                list.Add(g);
                            }
                        }

                        if(list.Count == 0)
                        {
                            this.listaKrawedzi.Add(k);
                            if (!this.listaWezlow.Contains(k.poczatek))
                            {
                                this.listaWezlow.Add(k.poczatek);
                            }
                            else
                            {
                                this.listaWezlow.Add(k.koniec);
                            }
                        } 
                        else
                        {
                            this.Join(list[0]);
                            this.listaGrafow.Remove(list[0]);
                        }
                        break;
                    case 2:
                        Graf graf = new Graf(k);
                        graf.listaWezlow.Add(k.poczatek);
                        graf.listaWezlow.Add(k.koniec);
                        listaGrafow.Add(graf);
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



            public Graf AlgKruskala(List<Krawedz> listKrawedzi)
            {
                this.listaKrawedzi.Add(listKrawedzi[0]);
                listaWezlow.Add(listKrawedzi[0].poczatek);
                listaWezlow.Add(listKrawedzi[0].koniec);
                listaGrafow.Add(this);
                
                for (int i = 1; i < listKrawedzi.Count; i++)
                {
                    this.Add(listKrawedzi[i]);
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

            string result = "";
            foreach(var g in g0.listaKrawedzi)
            {
                result += $"Start: {g.poczatek} - Koniec: {g.koniec} \n";
            }

            MessageBox.Show(result);
        }
    }
}
