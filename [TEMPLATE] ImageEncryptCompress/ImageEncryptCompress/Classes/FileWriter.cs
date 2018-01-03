using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageEncryptCompress.Classes
{
    class FileWriter
    {
        public BinaryWriter Stream { get; set; }
        public byte CurrentByte { get; set; }
        public int Index { get; set; }
        public long BytesWritten { get; set; }
        public List<byte> Bytes { get; set; }

        //TOTAL :O(1)
        public FileWriter(BinaryWriter bw)
        {
            Stream = bw; //O(1)
            CurrentByte = 0; //O(1)
            Index = 7; //O(1)
            BytesWritten = 0; //O(1)
            Bytes = new List<byte>(); //O(1)
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //TOTAL :O(1)
        public void WriteBit(bool bit)
        {

            if (Index == -1) //O(1)
            {
                Bytes.Add(CurrentByte); //O(1)
                //Stream.Write(CurrentByte);
                Index = 7; //O(1)
                CurrentByte = 0;//O(1)
                BytesWritten++; //O(1)
            }

            if (bit == true) //O(1)
            {
                CurrentByte |= (byte)(1 << (int)Index); //O(1)
                Index--; //O(1)
            }
            else
            {
                //CurrentByte &=(byte) ~((1 << (int)Index));
                Index--; //O(1)
            }

        }
            //TOTAL:O(L)
        public void WriteBits(List<bool> bits)
        {
            foreach (bool bit in bits)//O(L): L represents number of bits
            {
                if (Index == -1) //O(1)
                {
                    Bytes.Add(CurrentByte); //O(1)
                    //Stream.Write(CurrentByte);
                    Index = 7; //O(1)
                    CurrentByte = 0; //O(1)
                    BytesWritten++; //O(1)
                }

                if (bit == true) //O(1)
                {
                    CurrentByte |= (byte)(1 << (int)Index);//O(1)
                    Index--; //O(1)
                }

                else
                    Index--; //O(1)
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //TOTAL :O(1)
        public void WriteBytesToStream()
        {
            Stream.Write(Bytes.ToArray()); //O(1)
            Bytes = new List<byte>(); //O(1)
        }
    }
}
