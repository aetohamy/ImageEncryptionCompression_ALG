using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace ImageEncryptCompress
{
    class Register
    {
        public long InitialSeed { get; set; }
        public byte TapPosition { get; set; }
        public byte NumberOfBits { get; set; }

        //TOTAL:O(1)
        public Register(long initialSeed, byte tapPosition, byte numberOfBits)
        {
            InitialSeed = initialSeed; //O(1)
            TapPosition = tapPosition; //O(1)
            NumberOfBits = numberOfBits; //O(1)
        }

        /*public int Step()
        {
            int tapVal = (int)(InitialSeed >> TapPosition) & 1;
            int finalVal = (int)(InitialSeed >> NumberOfBits - 1) & 1;
            int Res = finalVal ^ tapVal;
            InitialSeed = InitialSeed << 1;
            InitialSeed = InitialSeed | Res;
            return Res;
        }*/

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //TOTAL:O(1)
        public int StepK(int k)
        {
            int res = 0; //O(1)
            for (int i = 0; i < k; i++) //O(K)
            {
                
                // ========================= 1 Step of LFSH =============================
                int tapVal = (int)(InitialSeed >> TapPosition) & 1; //O(1)
                int finalVal = (int)(InitialSeed >> NumberOfBits - 1) & 1; //O(1)
                int Res = finalVal ^ tapVal; //O(1)
                InitialSeed = InitialSeed << 1; //O(1)
                InitialSeed = InitialSeed | Res; //O(1)
                //=======================================================================
                res = (res * 2) + Res; //O(1)
            }
            return res; //O(1)
        }
    }
}
