namespace AiSD_IO2_cw5
{
    internal class Drzewo
    {
        public static string napis = "";

        public class Wezel : WezelGlowny
        {
            public List<Wezel> dzieci = new List<Wezel>();

            public Wezel(int liczba) : base(liczba)
            { }

        }

        public static string WyswietlDrzewo(Wezel w)
        {
            napis += w.wartosc.ToString() + ",";
            foreach (var w1 in w.dzieci)
            {
                WyswietlDrzewo(w1);
            }

            return napis;
        }
    }
}
