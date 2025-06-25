using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace GameOfPirates
{
    public static class Narzedziowa
    {
        public static int[] GenerujCyfryLosowe(int n)
        {
            if (n < 1)
                throw new ArgumentException("n musi być większe lub równe 1.");

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
                numbers[i] = i + 1;


            for (int i = n - 1; i > 0; i--)
            {
                int j = RandomOrFromFile.Instance.Next(0, i + 1);
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            return numbers;
        }





        public static int[,] ZaladujIntyZPlikuDoTablicy2D(string sciezkaDoPliku)
        {
            int[,] tablica2D = null;

            try
            {
                if (File.Exists(sciezkaDoPliku))
                {
                    string[] linie = File.ReadAllLines(sciezkaDoPliku)
                                         .Where(linia => !string.IsNullOrWhiteSpace(linia)) // Ignoruj puste lub zawierające tylko białe znaki
                                         .ToArray();

                    if (linie.Length > 0)
                    {
                        int liczbaWierszy = linie.Length;
                        int liczbaKolumn = 0;

                        foreach (string linia in linie)
                        {
                            int kolumnyWiersza = linia.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                            liczbaKolumn = Math.Max(liczbaKolumn, kolumnyWiersza);
                        }

                        tablica2D = new int[liczbaWierszy, liczbaKolumn];

                        for (int i = 0; i < liczbaWierszy; i++)
                        {
                            string[] elementyWiersza = linie[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int j = 0; j < liczbaKolumn; j++)
                            {
                                if (j < elementyWiersza.Length && int.TryParse(elementyWiersza[j].Trim(), out int liczba))
                                {
                                    tablica2D[i, j] = liczba;
                                }
                                else
                                {
                                    tablica2D[i, j] = 0;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            return tablica2D;
        }
        public static float[,] ZaladujIntyZPlikuDoTablicy2DFloat(string sciezkaDoPliku)
        {
            float[,] tablica2D = null;

            try
            {
                if (File.Exists(sciezkaDoPliku))
                {
                    var wczytane_linie = File.ReadAllLines(sciezkaDoPliku)
                                         .Where(linia => !string.IsNullOrWhiteSpace(linia));
                    List<string> list = new List<string>();
                    foreach(string l in wczytane_linie)
                    {
                        if (!l.StartsWith("#"))
                        {
                            list.Add(l);
                        }
                    }
                    string[] linie = list.ToArray();
                    if (linie.Length > 0)
                    {
                        int liczbaWierszy = linie.Length;
                        int liczbaKolumn = 0;

                        foreach (string linia in linie)
                        {
                            int kolumnyWiersza = linia.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                            liczbaKolumn = Math.Max(liczbaKolumn, kolumnyWiersza);
                        }

                        tablica2D = new float[liczbaWierszy, liczbaKolumn];

                        for (int i = 0; i < liczbaWierszy; i++)
                        {
                            string[] elementyWiersza = linie[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int j = 0; j < liczbaKolumn; j++)
                            {
                                if (j < elementyWiersza.Length && float.TryParse(elementyWiersza[j].Trim(), out float liczba))
                                {
                                    tablica2D[i, j] = liczba;
                                }
                                else
                                {
                                    tablica2D[i, j] = 0;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            return tablica2D;
        }

        public static List<int> ZnajdzSasiadowLodki(Gra g, int m, int n, int id, int[,] h_template)
        {
            List<int> sasiedzi = new List<int>();

            int index = -1;
            int idx = -1;

            foreach (Lodka lodka in g.Lodki)
            {
                idx++;
                if (lodka.Identyfikator_Globalny == id)
                {
                    index = idx;
                    break;
                }
            }

            if (index == -1)
                return sasiedzi;

            int row = index / n;
            int col = index % n;

            // Przesunięcia w kolejności: LGR, G, PGR, L, P, LDR, D, PDR
            int[] dRow = { -1, -1, -1, 0, 0, 0, 1, 1, 1 };
            int[] dCol = { -1, 0, 1, -1,0, 1, -1, 0, 1 };

            for (int i = 0; i < 9; i++)
            {
                int newRow = Mod(row + dRow[i], m);
                int newCol = Mod(col + dCol[i], n);

                int neighborIndex = newRow * n + newCol;

                idx = -1;
                foreach (Lodka l in g.Lodki)
                {
                    idx++;
                    if (idx == neighborIndex)
                    {
                        sasiedzi.Add(l.Identyfikator_Globalny);
                        break;
                    }
                }
            }

            /////////////////////////////////
            int rows = h_template.GetLength(0);
            int cols = h_template.GetLength(1);
            int[] h_template_plaska = new int[rows * cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    h_template_plaska[i * cols + j] = h_template[i, j];
                }
            }


            var kolejnosc = new List<(int val, int x)>();

 
            for (int x = 0; x < 9; x++)
            {
                   kolejnosc.Add((h_template_plaska[x], x));
            }

            kolejnosc.Sort((a, b) => a.val.CompareTo(b.val));
            List<int> sasiedzi_Posortowani = new List<int>();

            foreach((int val,int x) ktory_sasiad in kolejnosc)
            {
                if (sasiedzi[ktory_sasiad.x] != id)
                {
                    sasiedzi_Posortowani.Add(sasiedzi[ktory_sasiad.x]);
                }                
            }
            ////////////////////////////////


            return sasiedzi_Posortowani;
        }

        private static int Mod(int x, int m)
        {
            return (x % m + m) % m;
        }


        /*public static List<int> ZnajdzSasiadowLodki(Gra g, int m, int n, int id)
        {
            List<int> sasiedzi=new List<int>();
            int index = -1;
            int idx = -1;
            foreach (Lodka lodka in g.Lodki)
            {
                idx++;
                if (lodka.Identyfikator_Globalny == id)
                {
                    index = idx;
                    break;
                }
            }



            if (index == -1)
                return sasiedzi; // nie znaleziono


            idx = -1;
            foreach (Lodka l in g.Lodki)
            {
                idx++;
                if (
                    (index%n>0&&idx == index - n - 1) //LGR
                    || idx==index-n //G
                    || (index % n <n-1 && idx == index - n + 1) //PGR

                    || (index % n > 0 && idx == index - 1) //L
                    || (index % n < n - 1 && idx == index + 1) //P

                    || idx == index + n //D
                    || (index % n > 0 && idx == index + n - 1) //LDR
                    || (index % n < n - 1 && idx == index + n + 1) //PDR

                    )
                { 
                sasiedzi.Add(l.Identyfikator_Globalny);
                }
            }

            return sasiedzi;
        }*/
        public static void debug_save_generated_random_numbers_to_file(IEnumerable doZapisu)
        {
            List<int> list = new List<int>();
            foreach (List<int> i in doZapisu)
            {
                list.AddRange(i);
            }
            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter("Testy.txt"))
            {
                foreach (int line in list)
                    outputFile.WriteLine(line);
            }
        }
        public static int[] generuj_zestaw_liczb_losowych(int licznosc)
        {
            int[] liczbyLosowe = new int[licznosc];
            List<double> liczbyLosoweZPliku = new List<double>();
            for (int j = 0; j < licznosc; j++)
            {
                liczbyLosoweZPliku.Add(RandomOrFromFile.Instance.NextDouble());
            }
            for (int j = 1; j <= licznosc; j++)
            {
                int min_index = liczbyLosoweZPliku.IndexOf(liczbyLosoweZPliku.Min());
                liczbyLosoweZPliku[min_index] = 10.0;
                liczbyLosowe[min_index] = j;
            }
            return liczbyLosowe;
        }

    }
}
