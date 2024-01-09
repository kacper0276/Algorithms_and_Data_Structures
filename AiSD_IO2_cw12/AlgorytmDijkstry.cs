using System.Collections;
using System.Collections.Generic;

namespace AiSD_IO2_cw5
{
    internal class AlgorytmDijkstry
    {
        public class Krawedz
        {
            public int? waga, poczatek, koniec;

            public Krawedz(int? waga, int? poczatek, int? koniec)
            {
                this.waga = waga;
                this.poczatek = poczatek;
                this.koniec = koniec;
            }
        }

        public class Wezel5
        {
            public int wartosc;
            public List<Krawedz>? list = new();

            public void AddToKrawdzList(Krawedz krawedz) { list!.Add(krawedz); }

            public Wezel5(int wartosc, Krawedz krawedz)
            {
                this.wartosc = wartosc;
                list.Add(krawedz);
            }
        }

        public class Graf
        {
            public List<Wezel5> listaWezlow;
            public List<Krawedz> listaKrawedzi;

            public Graf(List<Wezel5> listaWezlow, List<Krawedz> listaKrawedzi)
            {
                this.listaKrawedzi = listaKrawedzi;
                this.listaWezlow = listaWezlow;
            }
        }

        public static bool FindValueInListWezel(List<Wezel5> list, int value)
        {
            foreach(var elList in list)
            {
                if(elList.wartosc == value)
                    return true;
            }
            return false;
        }

        public static int ReturnIndexOfElementInListWezel(List<Wezel5> list, int value)
        {
            foreach(var listEl in list.Select((value, i) => (value, i)))
            {
                if(listEl.value.wartosc == value)
                {
                    return listEl.i;
                }
            }
            return -1;
        }

        public static int[,] StworzMacierzSasiedztwa(Graf graf)
        {
            int rozmiar = graf.listaWezlow.Count;
            int dlugoscKrawedzi = graf.listaKrawedzi.Count;

            int[,] macierz = new int[rozmiar, rozmiar];

            for(int i = 0; i < rozmiar; i++)
            {
                for(int j = 0; j < rozmiar; j++)
                {
                    macierz[i, j] = 0;
                }
            }

            for(int i = 0; i < dlugoscKrawedzi; i++)
            {
                macierz[(int)graf.listaKrawedzi[i].poczatek!, (int)graf.listaKrawedzi[i].koniec!] = (int)graf.listaKrawedzi[i].waga!;
            }

            return macierz;
        }

        static int minDistance(int[] dist, bool[] sptSet, int size)
        {

            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < size; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }
                    
            return min_index;
        }

        public static void Dijkstra(Graf graf)
        {
            int[,] macierz = StworzMacierzSasiedztwa(graf);
            int size = graf.listaWezlow.Count;

            int[] result = new int[size];
            bool[] visited = new bool[size];
            string[] resultVisited = new string[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = int.MaxValue;
                visited[i] = false;
            }

            result[0] = 0;

            for (int i = 0; i < size - 1; i++)
            {
                int u = minDistance(result, visited, size);
                visited[u] = true;

                for(int j = 0; j < size; j++)
                {
                    if (!visited[j] && macierz[u, j] != 0 && result[u] != int.MaxValue && result[u] + macierz[u, j] < result[j])
                    {
                        result[j] = result[u] + macierz[u, j];
                        resultVisited[j] += $"{u}, ";
                    }
                }
            }

            string message = "";

            for(int i = 0; i < size; i++) 
            {
                message += $"[{i}] - {result[i]} ; ";
                message += $"Ostatni: {resultVisited[i]} \n";
            }

            MessageBox.Show(message);
        }

        public static void StartFunction()
        {
            var resutlTable = new Hashtable();

            Krawedz krawedz1 = new(-1, 0, 0);
            Krawedz krawedz2 = new(3, 0, 1);
            Krawedz krawedz5 = new(6, 0, 5);
            Krawedz krawedz4 = new(3, 0 ,4);
            Krawedz krawedz3 = new(1, 1, 2);
            Krawedz krawedz6 = new(3, 1, 3);
            Krawedz krawedz7 = new(1, 5, 3);
            Krawedz krawedz8 = new(3, 2, 3);
            Krawedz krawedz9 = new(2, 4, 5);
            Krawedz krawedz10 = new(1, 2, 5);

            // Do nieskierowanego grafu
            /*
            Krawedz krawedz11 = new(3, 1, 0);
            Krawedz krawedz12 = new(6, 5, 0);
            Krawedz krawedz13 = new(3, 4, 0);
            Krawedz krawedz14 = new(1, 2, 1);
            Krawedz krawedz15 = new(3, 3, 1);
            Krawedz krawedz16 = new(1, 3, 5);
            Krawedz krawedz17 = new(3, 3, 2);
            Krawedz krawedz18 = new(2, 5, 4);
            Krawedz krawedz19 = new(1, 5, 2);
             */

            List<Krawedz> listaKrawedzi = new List<Krawedz> {krawedz1, krawedz2, krawedz3, krawedz4, krawedz5, krawedz6, krawedz7, krawedz8, krawedz9, krawedz10 };
            List<Wezel5> listaWezlow = new();

            foreach (var krawedz in listaKrawedzi)
            {
               if(!FindValueInListWezel(listaWezlow, krawedz.koniec!.Value))
                {
                    var wezel = new Wezel5(krawedz.koniec.Value, krawedz);
                    listaWezlow.Add(wezel);
                }
               else
                {
                    int index = ReturnIndexOfElementInListWezel(listaWezlow, krawedz.koniec.Value);
                    listaWezlow[index].AddToKrawdzList(krawedz);
                }
            }

            Graf graf = new(listaWezlow, listaKrawedzi);

            Dijkstra(graf);
        }
    }
}
