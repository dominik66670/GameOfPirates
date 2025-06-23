using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameOfPirates
{
    public class Lodka
    {
        public ArrayList Piraci { get; set; }

        public int Identyfikator_Globalny { get; set; }

        public int[] Profil { get; set; }

        public List<int> Sasiedzi { get; set; }

        public void IdnetyfikatoryGlobalne(int n)
        {
            Piraci = new ArrayList();
            for (int i = n; i < n + 9; i++)
            {
                Pirat pirat = new Pirat();
                pirat.Identyfikator_globalny = i;
                Piraci.Add(pirat);
            }
        }
        public void LosujHierarchie()
        {
            int[] Hierarhie = Narzedziowa.GenerujCyfryLosowe(9);
            int i = 0;
            foreach (Pirat pirat in Piraci)
            {
                pirat.Hierarchia_w_lodce = Hierarhie[i];
                i++;
            }
        }


        public void LosujProfil()
        {
            this.Profil = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int wylosowanaLiczba = RandomOrFromFile.Instance.Next(0, 2);
                this.Profil[i] = wylosowanaLiczba;
            }
        }
        public void LiczPozycjeWSingleBoat(int[,] h_template)
        {
            //int[,] H_template = Narzedziowa.ZaladujIntyZPlikuDoTablicy2D("\\DATA\\H_template.txt");

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

            int pozycja = 0;
            foreach (int h in h_template_plaska)
            {
                foreach (Pirat p in Piraci)
                {
                    if (p.Hierarchia_w_lodce == h)
                    {
                        p.Pozycja_w_single_boat = pozycja;
                        pozycja++;
                        break;
                    }
                }
            }
        }


        public int[,] SingleBoat()
        {
            int[] pom1d = new int[9];

            for (int i = 0; i < 9; i++)
            {

                foreach (Pirat p in Piraci)
                { 
                if(p.Pozycja_w_single_boat==i)
                {
                        pom1d[i] = p.Identyfikator_globalny;
                        break;
                }
                
                }
            }


            int[,] singleBoat = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    singleBoat[i, j] = pom1d[i * 3 + j];
                }
            }

            return singleBoat;
        }

       public int[] Boat_And_H(int[,] h_template)
        {
            
            var kolejnosc = new List<(int val, int x, int y)>();

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    kolejnosc.Add((h_template[y, x], x, y));
                }
            }

            kolejnosc.Sort((a, b) => a.val.CompareTo(b.val));

            int[,] single_Boat = SingleBoat();

            int [] Boat_And_H = new int[9];

            int i = 0;
            foreach (var (val, x, y) in kolejnosc)
            {
                Boat_And_H[i] = single_Boat[y, x];
                i++;
            }
            return Boat_And_H;
        }


        }
}
