using ImageQuantization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEncryptCompress.Classes
{

    public class BinaryFile
    {
        public HuffmanTree Tree { get; set; }
        public string FileName { get; set; }
        public long InitialSeed { get; set; }
        public byte TapPosition { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public RGBPixel[,] Image { get; set; }
        public byte CurrentByte { get; set; }
        public int Index { get; set; }
        public byte NumberOfBits { get; set; }


        public BinaryFile()
        {

        }
        //TOTAL : O(1)
        public BinaryFile(RGBPixel[,] imageMatrix, long initialSeed, byte tapPosition, int width, int height, byte bits, HuffmanTree tree)
        {
            Image = imageMatrix;  //O(1)
            InitialSeed = initialSeed; //O(1)
            TapPosition = tapPosition; //O(1)
            ImageWidth = width;       //O(1)
            ImageHeight = height;     //O(1)
            Tree = tree;              //O(1)
            CurrentByte = 7;          //O(1)
            Index = 7;                //O(1)
            NumberOfBits = bits; //O(1)
        }
        //TOTAL : O(N^2)
        public void Create(string fileName)
        {
            try
            {
                FileStream fout = new FileStream(fileName + ".tdas", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None); // O(1)
                BinaryWriter bw = new BinaryWriter(fout); //O(1)
                //===================Writing Image Metadata=======================
                bw.Write(ImageWidth);  //O(1)
                bw.Write(ImageHeight); //O(1)
                bw.Write(InitialSeed); //O(1)
                bw.Write(TapPosition); //O(1)
                bw.Write(NumberOfBits); //O(1)
                //=================================================================

                //=============================Write Frequencies (Tree)===================
                //=============================Red========================================
                bw.Write((short)Tree.Frequencies.RedFrequencies.Count(x => x != 0)); //O(1)
                for (int i = 0; i < 256; i++)   //O(1)
                {
                    var val = Tree.Frequencies.RedFrequencies[i]; //O(1)
                    if (val != 0) //O(1)
                    {
                        bw.Write((byte)i);  //O(1)
                        bw.Write(val);      //O(1)
                    }
                }
                //==============================Green=====================================
                bw.Write((short)Tree.Frequencies.GreenFrequencies.Count(x => x != 0)); //O(1)
                for (int i = 0; i < 256; i++) //O(1)
                {
                    var val = Tree.Frequencies.GreenFrequencies[i]; //O(1)
                    if (val != 0)  //O(1)
                    {
                        bw.Write((byte)i); //O(1)
                        bw.Write(val);  //O(1)
                    }
                }
                //================================Blue====================================
                bw.Write((short)Tree.Frequencies.BlueFrequencies.Count(x => x != 0)); //O(1)
                for (int i = 0; i < 256; i++)  //O(1)
                {
                    var val = Tree.Frequencies.BlueFrequencies[i];  //O(1)
                    if (val != 0)  //O(1)
                    {
                        bw.Write((byte)i);  //O(1)
                        bw.Write(val); //O(1)
                    }
                }
                //================================Image===================================

                //FileWriter bitw = new FileWriter(bw);
                //List<bool> compressedBits = new List<bool>();

                for (int i = 0; i < ImageHeight; i++) //O(N^2)
                {
                    for (int j = 0; j < ImageWidth; j++)
                    {
                        byte redColor = Image[i, j].red; //O(1)
                        byte greenColor = Image[i, j].green; //O(1)
                        byte blueColor = Image[i, j].blue;  //O(1)
                        //-----------------Writing Red Color----------------//
                        //compressedBits.AddRange(Tree.RedEncodings[redColor]);
                        foreach (var bit in Tree.RedEncodings[redColor]) //O(L) : L respresents number of bits in red color
                        {
                            if (Index == -1) //O(1)
                            {
                                bw.Write(CurrentByte); //O(1)
                                //Stream.Write(CurrentByte);
                                Index = 7; //O(1)
                                CurrentByte = 0; //O(1)
                            }

                            if (bit == true) //O(1)
                            {
                                CurrentByte |= (byte)(1 << (int)Index);  //O(1)
                                Index--;  //O(1)
                            }
                            else
                            {
                                //CurrentByte &=(byte) ~((1 << (int)Index));
                                Index--; //O(1)
                            }
                        }
                        //-----------------Writing Green Color--------------//
                        //compressedBits.AddRange(Tree.GreenEncodings[greenColor]);
                        foreach (var bit in Tree.GreenEncodings[greenColor]) //O(L) : L represents number of bits in green color
                        {
                            if (Index == -1) // O(1)
                            {
                                bw.Write(CurrentByte);  //O(1)
                                //Stream.Write(CurrentByte);
                                Index = 7;  //O(1)
                                CurrentByte = 0; //O(1)
                            }

                            if (bit == true) //O(1)
                            {
                                CurrentByte |= (byte)(1 << (int)Index); //O(1)
                                Index--;  //O(1)
                            }
                            else
                            {
                                //CurrentByte &=(byte) ~((1 << (int)Index));
                                Index--; //O(1)
                            }
                        }
                        //-----------------Writing Blue Color--------------//
                        foreach (var bit in Tree.BlueEncodings[blueColor]) //O(L): L represents number of bits in blue color
                        {
                            if (Index == -1) //O(1)
                            {
                                bw.Write(CurrentByte); //O(1)
                                //Stream.Write(CurrentByte);
                                Index = 7; //O(1)
                                CurrentByte = 0; //O(1)
                            }

                            if (bit == true)  //O(1)
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
                        //compressedBits.AddRange(Tree.BlueEncodings[blueColor]);
                    }
                }

                //bitw.WriteBits(compressedBits);
                //bitw.WriteBytesToStream();

                if (Index != 7)
                    bw.Write(CurrentByte);

                bw.Close();
            }

            catch (IOException e)
            {

            }
        }
        //TOTAL :O(N^2)
        public void Read(string fileName)
        {
            try
            {
                FileStream fin = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite); //O(1)
                BinaryReader br = new BinaryReader(fin); //O(1)
                br.BaseStream.Seek(0, SeekOrigin.Begin); //O(1)
                //=========================== Reading Image Metadata =========================

                ImageWidth = br.ReadInt32(); //O(1)
                ImageHeight = br.ReadInt32(); //O(1)
                InitialSeed = br.ReadInt64();  //O(1)
                TapPosition = br.ReadByte();   //O(1)
                NumberOfBits = br.ReadByte(); //O(1)
                //============================================================================

                Image = new RGBPixel[ImageHeight, ImageWidth]; //O(1)
                FrequencyGenerator fg = new FrequencyGenerator(); //O(1)

                //-----------------Reading Red Frequencies----------------//
                int redCount = br.ReadInt16(); //O(1)
                for (int i = 0; i < redCount; i++) //O(L) : L represents redcount
                {
                    byte red = br.ReadByte(); //O(1)
                    int val = br.ReadInt32(); //O(1)
                    fg.RedFrequencies[red] = val; //O(1)
                }

                //----------------Reading Green Frequencies----------------//
                int greenCount = br.ReadInt16(); //O(1)
                for (int i = 0; i < greenCount; i++) //O(L) :L represents greencolor
                {
                    byte green = br.ReadByte(); //O(1)
                    int val = br.ReadInt32();  //O(1)
                    fg.GreenFrequencies[green] = val;  //O(1)
                }

                //-----------------Reading Blue Frequencies----------------//
                int blueCount = br.ReadInt16(); //O(1)
                for (int i = 0; i < blueCount; i++) //O(L) :L represents bluecolor
                {
                    byte blue = br.ReadByte(); //O(1)
                    int val = br.ReadInt32();  //O(1)
                    fg.BlueFrequencies[blue] = val;  //O(1)
                }

                //---------------- Reconstructing the tree -----------------//
                Tree = new HuffmanTree(fg); //O(1)
                Tree.ConstructTree();  
                Tree.GenerateAnotherEncodings(); //O(l log l)
                //------------------------------------------------------------
                FileReader fr = new FileReader(br); //O(1)
                for (int i = 0; i < ImageHeight; i++) //O(N^2)
                {
                    for (int j = 0; j < ImageWidth; j++)
                    {
                        //--------------------------------------- Red ----------------
                        StringBuilder sb = new StringBuilder(); //O(1)
                        while(true)
                        {
                            sb.Append(fr.ReadBitChar()); //O(1) : StringBuilder appends in O(1) time as it uses linked list implementation
                            string val = sb.ToString(); // O(L) : L is the length of the string currently in the builder
                            if(Tree.IntReverseRedEncodings.ContainsKey(val)) // O(1)
                            {
                                Image[i, j].red = Tree.IntReverseRedEncodings[val]; //O(1)
                                break;
                            }
                        }
                        //---------------------------------------- Green --------------
                        sb = new StringBuilder();
                        while (true) //O(1)
                        {
                            sb.Append(fr.ReadBitChar()); ////O(1) : StringBuilder appends in O(1) time as it uses linked list implementation
                            string val = sb.ToString(); //O(L) : L is the length of the string currently in the builder
                            if (Tree.IntReverseGreenEncodings.ContainsKey(val)) //O(1)
                            {
                                Image[i, j].green = Tree.IntReverseGreenEncodings[val]; //O(1);
                                break;
                            }
                        }
                        //------------------------------------------- Blue ---------------
                        sb = new StringBuilder(); //O(1)
                        while (true) //O(1)
                        {
                            sb.Append(fr.ReadBitChar()); //O(1) 
                            string val = sb.ToString(); //O(L) : L is the length of the string currently in the builder
                            if (Tree.IntReverseBlueEncodings.ContainsKey(val)) //O(1)
                            {
                                Image[i, j].blue = Tree.IntReverseBlueEncodings[val]; //O(1)
                                break;
                            }
                        }
                    }
                }

            }

            catch (IOException e)
            {
                Console.WriteLine("An IO Exception Occurred :" + e);
            }
        }


    }
}
