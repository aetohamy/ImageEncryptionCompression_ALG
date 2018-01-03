using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageEncryptCompress
{
    class PasswordRegister
    {
        public string Password { get; set; }
        public int TapPosition { get; set; }

        public byte[] Letters { get; set; }
        int NumberOfBits { get; set; }
        int index { get; set; }


        //TOTAL:O(1)
        public PasswordRegister(string password, int tapPosition)
        {
            Password = password; //O(1)
            TapPosition = tapPosition; //O(1)
            Letters = Encoding.ASCII.GetBytes(Password); //O(1)
            NumberOfBits = Letters.Length * 8; //O(1)
            index = TapPosition / 8; //O(1)
            index = (Letters.Length - 1) - index; //O(1)
            TapPosition = TapPosition % 8; //O(1)
        }

        //TOTAL:O(1)
        public int AlphanumericPassword(byte[] Letters, int NumberOfBits, int index)
        {
            int TapVal = (Letters[index] >> TapPosition) & 1; //O(1)
            int FinalVal = (Letters[0] >> NumberOfBits - 1) & 1; //O(1)
            int Res = FinalVal ^ TapVal; //O(1)
            ShiftLeft(Letters); //O(1)
            if (Res == 1) //O(1)
            {
                Letters[Letters.Length - 1] = (byte)(Letters[Letters.Length - 1] | 0x01); //O(1)
            }
            else
            {
                Letters[Letters.Length - 1] = (byte)(Letters[Letters.Length - 1] | 0x00); //O(1)
            }

            return Res; //O(1)

        }

        //TOTAL: O(1)
        public int StepK(int k)
        {
            int res = 0; //O(1)
            for (int i = 0; i < k; i++) //O(k)
            {
                int stepRet = AlphanumericPassword(Letters, NumberOfBits, index); //O(1)
                res = (res * 2) + stepRet;  //O(1)
            }
            return res; //O(1)
        }

        //TOTAL : O(L)
        public static bool ShiftLeft(byte[] bytes)
        {
            bool leftMostCarryFlag = false; //O(1)

            // Iterate through the elements of the array from left to right.
            for (int index = 0; index < bytes.Length; index++) //O(L) : L represents length of bytes
            {
                // If the leftmost bit of the current byte is 1 then we have a carry.
                bool carryFlag = (bytes[index] & 0x80) > 0; //O(1)

                if (index > 0)  //O(1)
                {
                    if (carryFlag == true) //O(1)
                    {
                        // Apply the carry to the rightmost bit of the current bytes neighbor to the left.
                        bytes[index - 1] = (byte)(bytes[index - 1] | 0x01); //O(1)
                    }
                }
                else
                {
                    leftMostCarryFlag = carryFlag; //O(1)
                }

                bytes[index] = (byte)(bytes[index] << 1); //O(1)
            }

            return leftMostCarryFlag; //O(1)
        }
    }
}
