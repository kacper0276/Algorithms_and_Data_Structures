using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_IO2_cw5
{
    // Metody do napisania
    //done - Wezel4 Znajdz(int liczba) - zwraca węzeł która ma tą wartość, jak dwie te same to zwraca pierwszą
    //done - Wezel4 ZnajdzMin(Wezel4 w) - zaczyna od węzła w, znajduje najmniejszą wartość w tym drzewie (Cały czas w lewo)
    //done - Wezel4 ZnajdzMax(Wezel4 w) - zaczyna od węzła w, znajduje największą wartość w tym drzewie (Cały czas w prawo)
    //done - Wezel4 Nastepnik(Wezel4 w) - Następna wartość rosnąca, ma wskazywać kolejne wartości (Wskazujesz 1 ma zwrócić 2), (Wskazujesz 2 ma zwrócić 3), Maks to null
    // a) jeżeli jest prawe dziecko, ZnajdźMin(w prawedziecko) -> następnik
    // b) nie ma prawego dziecka - powrót do rodzica
    // c) jeżeli nie ma prawego dziecka i nie zachodzi punkt b, ale nie ma już rodzica, bo jestem w korzeniu, nie ma następnika
    //done - Wezel4 Poprzednik(Wezel4 w) - 

    // b) 3 -> 2(lewe dziecko 4) -> 4 <- następnik
    /*      5
     *     4 8
     *    2
     *   1 3
     *   
     * 
     * 
     */
    internal class DrzewoBinarneKlasa
    {
        public class Wezel4 : WezelGlowny
        {
            public Wezel4 rodzic = null;
            public Wezel4 praweDziecko = null;
            public Wezel4 leweDziecko = null;

            public Wezel4(int wartosc) : base(wartosc)
            { }
        }

        public class DrzewoBinarne
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

                Form1.napis = "";
                toVisit.Add(korzen);

                for (int i = 0; i < toVisit.Count; i++)
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

            public List<Wezel4> WypiszSzczegoloweDane()
            {
                List<Wezel4> toVisit = new();

                toVisit.Add(korzen);

                for (int i = 0; i < toVisit.Count; i++)
                {
                    if (toVisit[i].leweDziecko != null)
                    {
                        toVisit.Add(toVisit[i].leweDziecko);
                    }
                    if (toVisit[i].praweDziecko != null)
                    {
                        toVisit.Add(toVisit[i].praweDziecko);
                    }
                }

                return toVisit;
            }

            public Wezel4 ZnajdzWezel(int liczba)
            {
                var w = this.korzen;
                while (true)
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

            // Binarne drzewo poszukiwań
            public void Add(int liczba)
            {
                Wezel4 w = ZnajdzWezel(liczba);
                var dziecko = new Wezel4(liczba);
                dziecko.rodzic = w;
                this.liczbaWezlow++;
                if (w.wartosc > liczba)
                {
                    w.leweDziecko = dziecko;
                }
                else
                {
                    w.praweDziecko = dziecko;
                }
            }

            // Znajdź wartość
            public Wezel4 Znajdz(int liczba)
            {
                List<Wezel4> toVisit = new();

                toVisit.Add(korzen);

                for (int i = 0; i < toVisit.Count; i++)
                {
                    if (toVisit[i].wartosc == liczba)
                    {
                        return toVisit[i];
                    }

                    if (toVisit[i].leweDziecko != null)
                    {
                        toVisit.Add(toVisit[i].leweDziecko);
                    }
                    if (toVisit[i].praweDziecko != null)
                    {
                        toVisit.Add(toVisit[i].praweDziecko);
                    }
                }

                return null;
            }

            // Znajdź minimalną wartość
            public Wezel4 ZnajdzMin(Wezel4 w)
            {
                List<Wezel4> toVisit = new();
                Wezel4 min = w;

                toVisit.Add(w);
                for (int i = 0; i < toVisit.Count; i++)
                {
                    if (toVisit[i].wartosc < min.wartosc)
                    {
                        min = toVisit[i];
                    }

                    if (toVisit[i].leweDziecko != null)
                    {
                        toVisit.Add(toVisit[i].leweDziecko);
                    }
                }

                //while (w.leweDziecko is not null)
                //{
                //  w = w.leweDziecko;
                //}

                return min;
            }

            // Szukanie największej wartości
            public Wezel4 ZnajdzMax(Wezel4 w)
            {
                List<Wezel4> toVisit = new();
                Wezel4 max = w;

                toVisit.Add(w);
                for (int i = 0; i < toVisit.Count; i++)
                {
                    if (toVisit[i].wartosc > max.wartosc)
                    {
                        max = toVisit[i];
                    }

                    if (toVisit[i].praweDziecko != null)
                    {
                        toVisit.Add(toVisit[i].praweDziecko);
                    }
                }

                //while(w.praweDziecko is not null)
                //{
                //    w = w.praweDziecko;
                //}

                //return w;

                return max;
            }

            // Następnik
            public Wezel4 Nastepnik(Wezel4 w)
            {
                if (w.praweDziecko is not null)
                {
                    return this.ZnajdzMin(w.praweDziecko);
                }
                else
                {
                    Wezel4 act = w.rodzic;
                    while (act.wartosc < w.wartosc)
                    {
                        if (act.rodzic is null)
                            break;
                        act = act.rodzic;
                    }
                    return act.wartosc > w.wartosc ? act : null;
                }
            }

            public Wezel4 NastepnikZajecia(Wezel4 w)
            {
                if (w.praweDziecko is not null)
                {
                    return this.ZnajdzMin(w.praweDziecko);
                }

                while (w.rodzic is not null)
                {
                    if (w.rodzic.leweDziecko == w)
                    {
                        return w.rodzic;
                    }

                    w = w.rodzic;
                }

                return null;
            }

            // Poprzednik
            public Wezel4 Poprzednik(Wezel4 w)
            {
                if (w.leweDziecko is not null)
                {
                    return w.leweDziecko;
                }
                else
                {
                    Wezel4 act = w.rodzic;
                    while (act.wartosc > w.wartosc)
                    {
                        if (act.rodzic is null)
                            break;
                        act = act.rodzic;
                    }
                    return act.wartosc < w.wartosc ? act : null;
                }
            }

            public Wezel4 PoprzednikZajecia(Wezel4 w)
            {
                if (w.leweDziecko is not null)
                {
                    return this.ZnajdzMax(w.leweDziecko);
                }

                while (w.rodzic is not null)
                {
                    if (w.rodzic.praweDziecko == w)
                    {
                        return w.rodzic;
                    }

                    w = w.rodzic;
                }

                return null;
            }

            // Usuwanie
            // a) Gdy nie ma dzieci
            // b) Gdy jest jedno dziecko - to dziecko wchodzi w miejsce rodzica
            // c) Gdy jest dwójka dzieci - to bierzemy następnik
            // Następnik może mieć jedno lub 0 dzieci
            // Zamieniamy nastepnik wg a) lub b) i wstawaiamy w miejsce usuniętego węzła

            public int CheckChildren(Wezel4 w)
            {
                if (w.leweDziecko is null && w.praweDziecko is null) { return 0; }
                if (w.rodzic is not null && w.praweDziecko is not null) { return 2; }
                return 1;
            }

            public bool CheckIfLeftChildrenExist(Wezel4 w)
            {
                return w.leweDziecko is not null ? true : false;
            }

            public Wezel4 RemoveWithoutChildren(Wezel4 w)
            {
                if (w.rodzic is null)
                {
                    this.korzen = null;
                    return w;
                }

                Wezel4 rodzic = w.rodzic;
                if (rodzic.leweDziecko.wartosc == w.wartosc)
                {
                    rodzic.leweDziecko = null;
                }
                else
                {
                    rodzic.praweDziecko = null;
                }

                w.rodzic = null;

                return w;
            }

            public Wezel4 RemoveOneChildren(Wezel4 w)
            {
                // w.GetType().GetFields().Where(f => f.Name.EndsWith("Dziecko") && f.GetValue(w) != null);
                Wezel4 rodzic = w.rodzic;
                bool leftExist = CheckIfLeftChildrenExist(w);
                Wezel4 dziecko = leftExist ? w.leweDziecko : w.praweDziecko;

                if (rodzic?.leweDziecko?.wartosc == w.wartosc)
                {
                    rodzic.leweDziecko = dziecko;
                    dziecko.rodzic = rodzic;
                    w.rodzic = null;
                }
                else
                {
                    rodzic.praweDziecko = dziecko;
                    dziecko.rodzic = rodzic;
                    w.rodzic = null;
                }

                if (leftExist)
                    w.leweDziecko = null;
                else
                    w.praweDziecko = null;

                return w;
            }

            Wezel4 RemoveOneChildrenZajecia(Wezel4 w)
            {
                Wezel4 dziecko = null;
                if (w.leweDziecko is not null)
                {
                    dziecko = w.leweDziecko;
                    w.leweDziecko = null;
                }
                else
                {
                    dziecko = w.praweDziecko;
                    w.praweDziecko = null;
                }

                if (w.rodzic == null)
                {
                    this.korzen = dziecko;
                }
                else
                {
                    if (w.rodzic.leweDziecko == w)
                    {
                        w.rodzic.leweDziecko = dziecko;
                    }
                    else
                    {
                        w.rodzic.praweDziecko = dziecko;
                    }
                    dziecko.rodzic = w.rodzic;
                    w.rodzic = null;
                }

                return default;
            }

            public Wezel4 RemoveTwoChildren(Wezel4 w)
            {
                Wezel4 nastepne = NastepnikZajecia(w);
                Wezel4 rodzic = w.rodzic;

                if (w.wartosc == rodzic.leweDziecko.wartosc)
                {
                    rodzic.leweDziecko = nastepne;
                }
                else
                {
                    rodzic.praweDziecko = nastepne;
                }
                nastepne.leweDziecko = w.leweDziecko;
                nastepne.rodzic = rodzic;
                w.leweDziecko.rodzic = nastepne;
                w.leweDziecko = null;
                w.praweDziecko = null;
                w.rodzic = null;

                return w;
            }

            public Wezel4 RemoveTwoChildrenZajecia(Wezel4 w)
            {
                var zamiennik = this.NastepnikZajecia(w);
                zamiennik = this.Remove(zamiennik);

                if (w.rodzic is null)
                {
                    this.korzen = zamiennik;
                    zamiennik.leweDziecko = w.leweDziecko;
                }
                else
                {
                    Wezel4 rodzic = w.rodzic;

                    zamiennik.leweDziecko = w.leweDziecko;
                    zamiennik.praweDziecko = w.praweDziecko;
                    w.leweDziecko = null;
                    w.praweDziecko = null;
                    w.rodzic = null;
                    zamiennik.rodzic = rodzic;
                    if (rodzic.leweDziecko == w)
                    {
                        rodzic.leweDziecko = zamiennik;
                    }
                    else
                    {
                        rodzic.praweDziecko = zamiennik;
                    }
                }

                return w;
            }

            public Wezel4 Remove(Wezel4 w)
            {
                Wezel4 returnValue = w;
                int typeOperation = CheckChildren(w);

                switch (typeOperation)
                {
                    case 0:
                        returnValue = RemoveWithoutChildren(w);
                        break;
                    case 1:
                        returnValue = RemoveOneChildren(w);
                        break;
                    case 2:
                        returnValue = RemoveTwoChildren(w);
                        break;
                    default:
                        MessageBox.Show("Błedne dane");
                        break;
                }

                return returnValue;
            }

        }
    }
}
