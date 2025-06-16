using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


      /*  public static List<Lodka> ZnajdzSasiadowLodki(Gra g, int m, int n, int id)
        {
            
            List<Lodka> sasiedzi = new List<Lodka>();

            // Znajdź indeks łódki o danym identyfikatorze
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

            int i = index / n;
            int j = index % n;

            for (int di = -1; di <= 1; di++)
            {
                for (int dj = -1; dj <= 1; dj++)
                {
                    if (di == 0 && dj == 0)
                        continue;

                    int ni = i + di;
                    int nj = j + dj;

                    if (ni >= 0 && ni < m && nj >= 0 && nj < n)
                    {
                        int sasiadIndex = ni * n + nj;
                        Lodka sasiad = (Lodka)lodki[sasiadIndex];
                        sasiedzi.Add(sasiad);
                    }
                }
            }

            return sasiedzi;
        }*/


    }
}
