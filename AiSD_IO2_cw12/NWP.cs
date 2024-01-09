namespace AiSD_IO2_cw5
{
    public class NWP
    {
        public static int MaxValue(int[,] tab)
        {
            int max = tab[1, 1];
            for(int i = 1; i < tab.GetLength(0); i++) 
            {
                for(int j = 1; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] > max)
                        max = tab[i, j];
                }
            }

            return max;
        }

        public static void StartFunction()
        {
            string w1 = "babab", w2 = "abaabbaaa"; 
            int n = w1.Length, m = w2.Length;

            int[,] tab = new int[n + 1, m + 1];


            // Wypełnienie tablicy
            for (int i = 1; i < tab.GetLength(0); i++)
            {
                for (int j = 1; j < tab.GetLength(1); j++)
                {
                    if (w1[i - 1] == w2[j - 1])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        tab[i, j] = MaxValue(tab);
                    }
                }
            }

            // Algorytm
            string result = "";
            bool left = true, up = true;
            int x = tab.GetLength(0) - 1, y = tab.GetLength(1) - 1;

            while (x != 0 && y != 0)
            {
                if(up && tab[x - 1, y] == tab[x, y])
                {
                    x -= 1;
                } 
                else if(up && tab[x - 1, y] != tab[x, y])
                {
                    up = false;
                }
                else if(left && tab[x, y - 1] == tab[x, y])
                {
                    y -= 1;
                } 
                else if(left && tab[x, y - 1] != tab[x, y])
                {
                    left = false;
                }
                else if(!up && !left)
                {
                    result = w1[x - 1] + result;
                    x -= 1;
                    y -= 1;
                    up = true;
                    left = true;
                }
            }


            MessageBox.Show(result);
        }
    }
}
