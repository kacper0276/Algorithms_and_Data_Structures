namespace AiSD_IO2_cw5
{
    internal class Graf
    {
        // Przechodzenie wgłąb - Graf(nie tylko drzewo)
        public class Wezel2 : WezelGlowny
        {
            public List<Wezel2> sasiedzi = new();

            public Wezel2(int wartosc) : base(wartosc)
            { }
        }

        public static string PrzechodzenieWglab(Wezel2 w)
        {
            string napis = "";
            List<Wezel2> odwiedzone = new();
            odwiedzone.Add(w);
            napis += w.wartosc.ToString() + ",";
            for (int i = 0; i < odwiedzone.Count; i++)
            {
                foreach (var w2 in odwiedzone[i].sasiedzi)
                {
                    if (!odwiedzone.Contains(w2))
                    {
                        odwiedzone.Add(w2);
                        napis += w2.wartosc.ToString() + ",";
                    }
                }
            }

            return napis;
        }

        
    }
}
