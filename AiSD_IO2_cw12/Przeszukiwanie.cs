using static AiSD_IO2_cw5.Graf;

namespace AiSD_IO2_cw5
{
    internal class Przeszukiwanie
    {
        public class Wezel3 : WezelGlowny
        {
            public List<Wezel3> dzieci = new();

            public Wezel3(int liczba) : base(liczba)
            { }
        }

        // BFS
        public static string PrzechodzenieWszerz(Wezel3 w)
        {
            List<Wezel3> toVisit = new();
            string napis = "";
            toVisit.Add(w);

            for (int i = 0; i < toVisit.Count; i++)
            {
                var w1 = toVisit[i];
                napis += w1.wartosc + ", ";
                toVisit.RemoveAt(i--);
                foreach (var w2 in w1.dzieci)
                {
                    toVisit.Add(w2);
                }
            }

            return napis;
        }

        // BFS - bez cykli
        // Przeszukiwanie wszesz
        /*
         5
        3 1
       2  4  8
        Wynik: 5, 3, 1, 2, 4, 8
         */
        public static string PrzeszukanieWszerz(Wezel2 w)
        {
            List<Wezel2> toVisit = new();
            string napis = "";
            toVisit.Add(w);

            for (int i = 0; i < toVisit.Count; i++)
            {
                var w1 = toVisit[i];
                napis += w1.wartosc + ", ";
                foreach (var w2 in w1.sasiedzi)
                {
                    toVisit.Add(w2);
                }
            }
            return napis;
        }
    }
}
