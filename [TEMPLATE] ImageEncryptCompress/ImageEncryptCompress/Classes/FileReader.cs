using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEncryptCompress.Classes
{
    class FileReader
    {
        public BinaryReader Stream { get; set; }
        public byte CurrentByte { get; set; }
        public int Index { get; set; }

        //TOTAL :O(1)
        public FileReader(BinaryReader br)
        {
            Stream = br; //O(1)
            CurrentByte = br.ReadByte(); //O(1)
            Index = 7;  //O(1)
        }

        //TOTAL :O(1)
        public bool ReadBit()
        {
            if(Index==-1) //O(1)
            {
                CurrentByte = Stream.ReadByte(); //O(1)
                Index = 7; //O(1)
            }
            var res = (CurrentByte >> Index) & 1; //O(1)
            Index--; //O(1)

            return(res == 1) ? true : false;//O(1)
        }

        //TOTAL: O(1)
        public char ReadBitChar()
        {
            if (Index == -1) //O(1)
            {
                CurrentByte = Stream.ReadByte(); //O(1)
                Index = 7; //O(1)
            }
            var res = (CurrentByte >> Index) & 1; //O(1)
            Index--; //O(1)

            return (res == 1) ? '1' : '0'; //O(1)
        }
    }
}
