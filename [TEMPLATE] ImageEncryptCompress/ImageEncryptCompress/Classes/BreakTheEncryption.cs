using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageEncryptCompress
{
    class BreakTheEncryption
    {
        public int NumberOfBits { get; set; }
        public byte[] Seeds { get; set; }
        double PossibleSeeds { get; set; }

        //TOTAL : O(1)
        public BreakTheEncryption(int numberOfBits)
        {
            NumberOfBits = numberOfBits; //O(1)
            PossibleSeeds = Math.Pow(2, numberOfBits); //O(1)
            Seeds = new byte[numberOfBits]; //O(1)
        }

        //TOTAL : O(N^3)
        public void GetSeedsAndTaps(byte[] Seeds, int NmberOfBits, double PossibleSeeds)
        {
            for (int i = 0; i < PossibleSeeds; i++)
            {
                string binary = Convert.ToString(i, 2).PadLeft(NumberOfBits, '0'); //O(L)
                for (int j = 0; j < binary.Length; j++) //O(N)
                {
                    if (binary[j] == '0') //O(1)
                    {
                        Seeds[j] = 0; //O(1)
                    }
                    else
                    {
                        Seeds[j] = 1; //O(1)
                    }
                }
                ////-----------------------------"XOR All Taps With Seeds"
                for (int k = NumberOfBits - 1; k >= 0; k--) //O(N^2)
                {
                    byte[] Seed = new byte[NumberOfBits]; //O(1)
                    for (int s = 0; s < NumberOfBits; s++) //O(N)
                    {
                        Seed[s] = Seeds[s]; //O(N)
                    }
                    int res = 0; //O(1)
                    int TapVal; //O(1)
                    int FinalVal; //O(1)
                    int Res;      //O(1)
                    for (int z = 0; z < 8; z++)  //O(N)
                    {
                        TapVal = Seed[k]; //O(1)
                        FinalVal = Seed[0]; //O(1)
                        Res = TapVal ^ FinalVal; //O(1)
                        Array.Copy(Seed, 1, Seed, 0, NumberOfBits - 1); //O(1)
                        Seed[NumberOfBits - 1] = 0; //O(1)
                        res = (res * 2) + Res; //O(1)
                    }
                }
            }
        }
    }
}
