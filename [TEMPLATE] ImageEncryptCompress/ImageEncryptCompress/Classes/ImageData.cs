using ImageQuantization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEncryptCompress.Classes
{
    public class ImageData
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public byte TapPosition { get; set; }
        public long InitialSeed { get; set; }
        public RGBPixel[,] ImageMatrix { get; set; }
        public int BytesSize { get; set; }
        public byte NumberOfBits { get; set; }
         
        //TOTAL:O(1)
        public ImageData()
        {
            Width = 0;//O(1)
            Height = 0; //O(1)
            TapPosition = 0; //O(1)
            InitialSeed = 0; //O(1)
            ImageMatrix = null; //O(1)
            
        }

        //TOTAL:O(1)
        public ImageData(int width , int height , byte tap , long seed , byte bits, RGBPixel[,] image)
        {
            Width = width; //O(1)
            Height = height; //O(1)
            TapPosition = tap; //O(1)
            InitialSeed = seed; //O(1)
            ImageMatrix = image; //O(1)
            BytesSize = (Width * Height) * 3; //O(1)
            NumberOfBits = bits;
        }
    }
}
