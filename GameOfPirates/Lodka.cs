using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfPirates
{
    internal class Lodka
    {
        public ArrayList Piraci { get; set; }

        public int Identyfikator_Globalny { get;set;}

        public int[] Profil {  get;set;}

        public void IdnetyfikatoryGlobalne(int n)
        {
            Piraci = new ArrayList();
            for (int i = n; i < n+9; i++) 
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
            this.Profil=new int[3];
            for (int i = 0; i < 3; i++)
            {
                int wylosowanaLiczba = RandomOrFromFile.Instance.Next(0,2);
                this.Profil[i] = wylosowanaLiczba;
            }
        }
    }
}
