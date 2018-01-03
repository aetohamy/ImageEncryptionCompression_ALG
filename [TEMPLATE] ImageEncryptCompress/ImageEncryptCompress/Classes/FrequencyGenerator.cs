using ImageQuantization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEncryptCompress
{
    public class FrequencyGenerator
    {
        public int[] RedFrequencies { get; set; }
        public int[] BlueFrequencies { get; set; }
        public int[] GreenFrequencies { get; set; }

        //TOTAL :O(1)
        public FrequencyGenerator()
        {
            RedFrequencies = Enumerable.Repeat(0, 256).ToArray(); // O(1)
            BlueFrequencies = Enumerable.Repeat(0, 256).ToArray(); // O(1)
            GreenFrequencies = Enumerable.Repeat(0, 256).ToArray(); // O(1)
        }
        //TOTAL: O(N^2)
        public void GenerateFromImage(RGBPixel[,] ImageMatrix)
        {
            foreach(var color in ImageMatrix) //O(N^2)
            {
                //===================Fill Red Frequencies=================
                RedFrequencies[color.red]++; // O(1)
                //=========================================================

                //===================Fill Green Frequencies=================
                GreenFrequencies[color.green]++; // O(1)
                //=========================================================

                //===================Fill Blue Frequencies=================
                BlueFrequencies[color.blue]++; // O(1)
                //=========================================================

            }
        }
    }

}
