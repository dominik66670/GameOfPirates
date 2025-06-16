using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfPirates
{
    public class Gra
    {

        public ArrayList Lodki { get; set; }


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

        public void LadujDaneTest1(int ilelodek)
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
        }

        public void LadujDaneTest2(int ilelodek)
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
        }
        public void DataInitialization1(int[,] Selected_Boat_profiles)
        {
            float[,] All_boat_game_profiles = Narzedziowa.ZaladujIntyZPlikuDoTablicy2DFloat("DATA\\All_boat_game_profiles.txt");
            int[,] H_template = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("DATA\\H_template.txt");
            Console.WriteLine("Test");
        }
    }
}
