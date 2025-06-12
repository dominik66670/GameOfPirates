using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfPirates
{
    public static class Print
    {
        public static void print1(Gra gra)
        {
            Console.WriteLine("Single_boat");

            string sciezkaDoPliku = "debug.txt";

            try
            {
                File.AppendAllText(sciezkaDoPliku, "Single_boat" + Environment.NewLine);
                int licznik = 0;
                foreach (Lodka lodka in gra.Lodki)
                {
                    string hierarchia = "";
                    foreach (Pirat pirat in lodka.Piraci)
                    {
                        hierarchia = hierarchia + pirat.Identyfikator_globalny + " ";
                        licznik++;
                        if (licznik % 3 == 0)
                        {
                            hierarchia = hierarchia + Environment.NewLine;
                        }
                    }
                    hierarchia = hierarchia + Environment.NewLine;
                    File.AppendAllText(sciezkaDoPliku, hierarchia);
                    //break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisu do pliku: {ex.Message}");
            }


        }

        public static void print2(Gra gra)
        {
            Console.WriteLine("Boats_and_H");

            string sciezkaDoPliku = "debug.txt";

            try
            {
                File.AppendAllText(sciezkaDoPliku, "Boats_and_H" + Environment.NewLine);
                int licznik = 0;
                foreach (Lodka lodka in gra.Lodki)
                {
                    string hierarchia = "";
                    foreach (Pirat pirat in lodka.Piraci)
                    {
                        hierarchia = hierarchia + pirat.Hierarchia_w_lodce + " ";
                        licznik++;
                        if (licznik % 3 == 0)
                        {
                            hierarchia = hierarchia + Environment.NewLine;
                        }
                    }
                    hierarchia = hierarchia + Environment.NewLine;
                    File.AppendAllText(sciezkaDoPliku, hierarchia);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisu do pliku: {ex.Message}");
            }

        }

        public static void print3(Gra gra)
        {
            string sciezkaDoPliku = "debug.txt";

            try
            {
                File.AppendAllText(sciezkaDoPliku, "Boats_glob_ID" + Environment.NewLine);

                foreach (Lodka lodka in gra.Lodki)
                {
                    File.AppendAllText(sciezkaDoPliku, lodka.Identyfikator_Globalny.ToString() + Environment.NewLine);
                }

                Console.WriteLine($"Profile łódek zostały dopisane do pliku: {sciezkaDoPliku}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisu do pliku: {ex.Message}");
            }

        }

        /*public static void print4(Gra gra)
        {
            Console.WriteLine("Boats_weights");
            string sciezkaDoPliku = "debug.txt";

            try
            {
                File.AppendAllText(sciezkaDoPliku, "Boats_weights" + Environment.NewLine);

                for(int i=0;i<gra.Lodki.Count;i++) 
                {
                if(i>0) { }
                }

                foreach (Lodka lodka in gra.Lodki)
                {
                    File.AppendAllText(sciezkaDoPliku, lodka.Identyfikator_Globalny.ToString() + Environment.NewLine);
                }

                Console.WriteLine($"Profile łódek zostały dopisane do pliku: {sciezkaDoPliku}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisu do pliku: {ex.Message}");
            }
        }*/

        public static void print11(Gra gra)
        {
            string sciezkaDoPliku = "debug.txt";

            try
            {
                File.AppendAllText(sciezkaDoPliku, "All_players_glob_ID" + Environment.NewLine);

                foreach (Lodka lodka in gra.Lodki)
                {
                    string hierarchia = "";
                    foreach (Pirat pirat in lodka.Piraci)
                    {
                        hierarchia = hierarchia + pirat.Identyfikator_globalny + ",";
                    }
                    File.AppendAllText(sciezkaDoPliku, hierarchia + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisu do pliku: {ex.Message}");
            }
        }

        public static void print12(Gra gra)
        {
            string sciezkaDoPliku = "debug.txt";

            try
            {
                File.AppendAllText(sciezkaDoPliku, "Hier_in_boats" + Environment.NewLine);

                foreach (Lodka lodka in gra.Lodki)
                {
                    string hierarchia = "";
                    foreach (Pirat pirat in lodka.Piraci)
                    {
                        hierarchia = hierarchia + pirat.Hierarchia_w_lodce + ",";
                    }
                    File.AppendAllText(sciezkaDoPliku, hierarchia + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisu do pliku: {ex.Message}");
            }
        }

        public static void print13(Gra gra)
        {
            Console.WriteLine(gra.Lodki.Count);
            string sciezkaDoPliku = "debug.txt";

            try
            {
                File.AppendAllText(sciezkaDoPliku, "Boats_profiles" + Environment.NewLine);

                foreach (Lodka lodka in gra.Lodki)
                {
                    string profilString = string.Join(", ", lodka.Profil);
                    File.AppendAllText(sciezkaDoPliku, profilString + Environment.NewLine);
                }

                Console.WriteLine($"Profile łódek zostały dopisane do pliku: {sciezkaDoPliku}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisu do pliku: {ex.Message}");
            }
        }

        public static void czyscPlik()
        {

            string sciezkaDoPliku = "debug.txt";

            try
            {
                File.WriteAllText(sciezkaDoPliku, string.Empty);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisu do pliku: {ex.Message}");
            }

        }

    }
}
