using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GameOfPirates
{
    public class Gra
    {

        public ArrayList Lodki { get; set; } =new ArrayList();
        public float[,]? All_boat_game_profiles { get; set; }
        public int[,]? H_template { get; set; }
        public int[,]? Selected_Boat_profile { get; set; }


    


        public void InicjujDane(int ilelodek)
        {
            int igp = 0;
            Lodki = new ArrayList();
            for (int i = 0; i < ilelodek; i++)
            {
                Lodka lodka = new Lodka();
                lodka.Identyfikator_Globalny = i;
                lodka.IdnetyfikatoryGlobalne(igp);
                lodka.LosujHierarchie();
                lodka.LosujProfil();
                igp = igp + 9;
                Lodki.Add(lodka);
            }
        }

        /*  public void LadujDaneTest1(int ilelodek)
          {
              int[,] All_players_glob_ID = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 1\\All_players_glob_ID-1boat.txt");
              int[,] Boats_profiles = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 1\\Boats_profiles-1boat.txt");
              int[,] Hier_in_boats = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 1\\Hier_in_boats-1boat.txt");
              Lodki = new ArrayList();
              for (int i = 0; i < Boats_profiles.GetLength(0); i++)
              {
                  if (i == ilelodek)
                  {
                      break;
                  }
                  Lodka lodka = new Lodka();
                  int liczbaKolumn = Boats_profiles.GetLength(1);
                  int[] wiersz1D = new int[liczbaKolumn];

                  for (int j = 0; j < liczbaKolumn; j++)
                  {
                      wiersz1D[j] = Boats_profiles[i, j];
                  }

                  lodka.Profil = wiersz1D;

                  liczbaKolumn = All_players_glob_ID.GetLength(1);

                  lodka.Piraci = new ArrayList();
                  for (int j = 0; j < liczbaKolumn; j++)
                  {
                      Pirat pirat = new Pirat();
                      pirat.Identyfikator_globalny = All_players_glob_ID[i, j];
                      pirat.Hierarchia_w_lodce = Hier_in_boats[i, j];
                      lodka.Piraci.Add(pirat);
                  }

                  lodka.Identyfikator_Globalny = i;
                  Lodki.Add(lodka);
              }
          }*/


        //////////////////////////////////////////////////////////////////////////////////////////////////////
        public void LadujDaneTest1(int m, int n)
        {
            int[,] All_players_glob_ID = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 1\\All_players_glob_ID-1boat.txt");
            int[,] Boats_profiles = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 1\\Boats_profiles-1boat.txt");
            int[,] Hier_in_boats = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 1\\Hier_in_boats-1boat.txt");

            Lodki = new ArrayList();
            int licznikLodek = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Lodka lodka = new Lodka();
                    lodka.Identyfikator_Globalny = licznikLodek++;
                    lodka.Piraci = new ArrayList();

                    int[] profil = new int[Boats_profiles.GetLength(1)];
                    for (int k = 0; k < profil.Length; k++)
                    {
                        profil[k] = Boats_profiles[lodka.Identyfikator_Globalny, k];
                    }
                    lodka.Profil = profil;

                    for (int w = 0; w < 3; w++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            int r = 3 * i + w;
                            int c = 3 * j + k;

                            Pirat pirat = new Pirat();
                            pirat.Identyfikator_globalny = All_players_glob_ID[r, c];
                            pirat.Hierarchia_w_lodce = Hier_in_boats[r, c];

                            lodka.Piraci.Add(pirat);
                        }
                    }

                    Lodki.Add(lodka);
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////

        /*public void LadujDaneTest2(int ilelodek)
        {
            int[,] All_players_glob_ID = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 2\\All_players_glob_ID-12boat.txt");
            int[,] Boats_profiles = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 2\\Boats_profiles-12boat.txt");
            int[,] Hier_in_boats = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 2\\Hier_in_boats-12boat.txt");
            Lodki = new ArrayList();
            for (int i = 0; i < Boats_profiles.GetLength(0); i++)
            {
                if (i == ilelodek)
                {
                    break;
                }
                Lodka lodka = new Lodka();
                int liczbaKolumn = Boats_profiles.GetLength(1);
                int[] wiersz1D = new int[liczbaKolumn];

                for (int j = 0; j < liczbaKolumn; j++)
                {
                    wiersz1D[j] = Boats_profiles[i, j];
                }

                lodka.Profil = wiersz1D;

                liczbaKolumn = All_players_glob_ID.GetLength(1);

                lodka.Piraci = new ArrayList();
                for (int j = 0; j < liczbaKolumn; j++)
                {
                    Pirat pirat = new Pirat();
                    pirat.Identyfikator_globalny = All_players_glob_ID[i, j];
                    pirat.Hierarchia_w_lodce = Hier_in_boats[i, j];
                    lodka.Piraci.Add(pirat);
                }

                lodka.Identyfikator_Globalny = i;
                Lodki.Add(lodka);
            }
        }*/

        public void LadujDaneTest2(int m, int n)
        {
            int[,] All_players_glob_ID = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 2\\All_players_glob_ID-12boat.txt");
            int[,] Boats_profiles = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 2\\Boats_profiles-12boat.txt");
            int[,] Hier_in_boats = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("Debug data\\Data set 2\\Hier_in_boats-12boat.txt");


            Lodki = new ArrayList();
            int licznikLodek = 0;

            for (int i = 0; i < m; i++)          
            {
                for (int j = 0; j < n; j++)       
                {
                    Lodka lodka = new Lodka();
                    lodka.Identyfikator_Globalny = licznikLodek;

                    int[] profil = new int[Boats_profiles.GetLength(1)];
                    for (int k = 0; k < profil.Length; k++)
                    {
                        profil[k] = Boats_profiles[licznikLodek, k];
                    }
                    lodka.Profil = profil;

                    lodka.Piraci = new ArrayList();
                    for (int w = 0; w < 3; w++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            int r = 3 * i + w;
                            int c = 3 * j + k;

                            Pirat pirat = new Pirat();
                            pirat.Identyfikator_globalny = All_players_glob_ID[r, c];
                            pirat.Hierarchia_w_lodce = Hier_in_boats[r, c];

                            lodka.Piraci.Add(pirat);
                        }
                    }

                    Lodki.Add(lodka);
                    licznikLodek++;
                }
            }
        }


        public void DataInitialization1(int[,] selected_Boat_profiles, CheckBox debug, CheckBox test1, int K, int N, int M, CheckBox test2)
        {
            All_boat_game_profiles = Narzedziowa.ZaladujIntyZPlikuDoTablicy2DFloat("DATA\\All_boat_game_profiles.txt");
            H_template = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("DATA\\H_template.txt");
            Selected_Boat_profile = selected_Boat_profiles;
            
            if (debug.Checked && test1.Checked)
            {
                if (K==1 && M==1 && N==1) 
                {
                    LadujDaneTest1(M,N);
                    Print.print1(this);
                    return;
                }
                if (K==12 && M==4 && N == 3)
                {
                    LadujDaneTest2(M,N);
                    // use RANDOM_NUM[] to calculate Boats_and_H[1..M.N,1..9]
                    // CALCULATE Boats_and_H;
                    Print.printText("L=12,M=4,N=3");
                    Print.print2(this);
                }
                if (K==9 && M==3 && N == 3)
                {
                    Print.print11(this);
                    Print.print12(this);
                    Print.print2(this);
                }
            }
            else
            {
                RandomOrFromFile.Instance.CzyZSeeda(0, false);
                RandomOrFromFile.Instance.CzyZpliku(true);
                List<List<int>> wartosci = RandomOrFromFile.Instance.losoweWartosciLudek(K);
                //Narzedziowa.debug_save_generated_random_numbers_to_file(wartosci);
                int igp = 0;
                Lodki = new ArrayList();
                for (int i = 0; i < K; i++)
                {
                    Lodka lodka = new Lodka();
                    lodka.IdnetyfikatoryGlobalne(igp); // CALCULATE All_players_glob_ID 
                    lodka.LosujHierarchie(); // CALCULATE Hier_in_boats
                    lodka.LosujProfil();
                    igp = igp + 9;
                    Lodki.Add(lodka);
                }

                // CALCULATE Boats_and_H - Nie mam pojęcia co to jest
            }
            if (test2.Checked) 
            {
                Print.print11(this);
                Print.print12(this);
                Print.print2(this);
            }

            int j = 0;
            foreach (Lodka l in this.Lodki)
            {
            l.Identyfikator_Globalny= j; // CALCULATE Boats_glob_ID
            j++;
            }

            foreach (Lodka l in this.Lodki)
            {
                l.Sasiedzi = Narzedziowa.ZnajdzSasiadowLodki(this,M,N,l.Identyfikator_Globalny);
            }
            // CALCULATE Boats_neigb 

            
            if (test2.Checked)
            {
                
                Print.print3(this);
                Print.print4(this);
            }
        }
    }
}
