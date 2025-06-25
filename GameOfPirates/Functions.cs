using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfPirates
{
    public static class Functions
    {
        public static void SelectBootGameProfiles(int[,] guiSelectedBoatProfiles, ref int[,] boatGameProfiles)
        {
            boatGameProfiles = new int[6, 30];
            int l = 0;

            for (int k = 0; k <= 5; k++)
            {
                int boatProfile = guiSelectedBoatProfiles[1, k];
                if (boatProfile == 0)
                    return;
                for (int i = 0; i < 20; i++)
                {
                    if (boatGameProfiles[i, 1] == 0)
                    {
                        MessageBox.Show("SELECT from All boot game profiles: some problem");
                        return;
                    }

                    if (boatGameProfiles[i, 1] == boatProfile)
                    {
                        l++;
                        for (int j = 0; j < 25; j++)
                        {
                            boatGameProfiles[l, j] = boatGameProfiles[i, j];
                        }
                    }
                }
            }
        }

        public static void CheckDetRand(int[,] boatGameProfiles, ref int[] profileGenerDetRond, ref int crRandProf)
        {
            for (int i = 0; i < boatGameProfiles.GetLength(0); i++)
            {
                if (boatGameProfiles[i, 30] == 1)
                {
                    profileGenerDetRond[i] = 1;
                    crRandProf++;
                    return;
                }
            }
        }

        public static void CheckNumDetRandProfiles(ref int[,] boatGameProfiles)
        {
            int[] profileGenerDetRond = new int[6];
            int crRandProf = 0;
            for (int i = 0; i < 6; i++)
            {
                int boatProfile = boatGameProfiles[1, 6];
                if (boatProfile == 0) return;
                if (boatProfile == 11) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 12) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 13) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 14) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 20) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 21) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 22) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 23) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 24) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 30) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 31) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 32) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 33) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 34) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 40) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 41) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 42) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 43) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 44) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 50) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 51) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 52) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 53) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                if (boatProfile == 54) CheckDetRand(boatGameProfiles, ref profileGenerDetRond, ref crRandProf);
                continue;
            }
        }

        public static void AssignProfiles(int[,] guiSelectedBoatProfiles, int K)
        {
            int[] assignedProfToBoats = new int[K];
            int[,] cSelectedBoatProfile = new int[2, 6];
            for (int i = 0; i < 6; i++)
            {
                cSelectedBoatProfile[1, i] = guiSelectedBoatProfiles[1, i];
                cSelectedBoatProfile[2, i] = guiSelectedBoatProfiles[2, i];
            }

            int maxNum = cSelectedBoatProfile[2, 1];
            for (int i = 1; i < K; i++)
            {
                if (cSelectedBoatProfile[2, i] > maxNum)
                {
                    maxNum = cSelectedBoatProfile[2, i];
                }
            }

            int currPosition = 1;

            if (maxNum == 1)
            {
                for (int i = 0; i < K; i++)
                {
                    if (cSelectedBoatProfile[2, i] == 1)
                    {
                        assignedProfToBoats[currPosition] = cSelectedBoatProfile[1, i];
                        currPosition++;
                        cSelectedBoatProfile[2, i] = cSelectedBoatProfile[2, i] - 1;
                    }
                }
            }

            int remainingNumToAssign = K - currPosition - 1;

            do
            {
                for (int i = 0; i < 6; i++)
                {
                    if (cSelectedBoatProfile[2, i] > 0)
                    {
                        assignedProfToBoats[currPosition] = cSelectedBoatProfile[2, i];
                        currPosition++;
                        cSelectedBoatProfile[2, i] = cSelectedBoatProfile[2, i] - 1;
                        remainingNumToAssign--;
                    }
                }
            } while (remainingNumToAssign > 0);

        }

    }
    
    
}
