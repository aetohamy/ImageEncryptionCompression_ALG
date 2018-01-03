using ImageEncryptCompress.Classes;
using ImageQuantization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEncryptCompress.Forms
{
    public partial class CompressFileForm : MetroFramework.Forms.MetroForm
    {
        public ImageData ImageData { get; set; }
        public HuffmanTree Tree { get; set; }

        public CompressFileForm(ImageData data , HuffmanTree tree)
        {
            InitializeComponent();
            ImageData = data;
            Tree = tree;
        }

        private void CompressFileForm_Load(object sender, EventArgs e)
        {
            double originalSizeKB = (double)ImageData.BytesSize * 0.001;
            dataGridViewInformation.Rows.Add("Original Size", originalSizeKB + " KB.");
            long redComp = 0;
            long greenComp = 0;
            long blueComp = 0;

            foreach (var red in Tree.RedEncodings)
                redComp += Tree.Frequencies.RedFrequencies[red.Key] * red.Value.Count;
            foreach (var green in Tree.GreenEncodings)
                greenComp += Tree.Frequencies.GreenFrequencies[green.Key] * green.Value.Count;
            foreach (var blue in Tree.BlueEncodings)
                blueComp += Tree.Frequencies.BlueFrequencies[blue.Key] * blue.Value.Count;

            double totalComp = (redComp + greenComp + blueComp) * 0.000125;
            dataGridViewInformation.Rows.Add("Size After Compression", totalComp + " KB.");
            double compRatio = ((double)totalComp / originalSizeKB) * 100;
            dataGridViewInformation.Rows.Add("Compression Ratio", compRatio + " %.");
            double extraSize = 0; 
            extraSize += (Tree.Frequencies.RedFrequencies.Count(x => x!=0)) * 5; //  5 = 1Byte(Color) + 4Bytes(FrequencyCount)
            extraSize += (Tree.Frequencies.GreenFrequencies.Count(x => x!=0)) * 5;
            extraSize += (Tree.Frequencies.BlueFrequencies.Count(x=> x!=0)) * 5;
            extraSize += 9; //InitialSeed (long 8 Bytes) + TapPosition(Byte)
            extraSize += 8; //ImageWidth (4 Bytes Int) + ImageHeight (4 Bytes Int)
            extraSize += 2 * 3; //Frequencies Count metadata before each color each Int 4 Bytes
            extraSize += 1; // Byte Of NumberOfBits
            extraSize *= 0.001;

            dataGridViewInformation.Rows.Add("Extra Information", extraSize + "  KB.");
            dataGridViewInformation.Rows.Add("Total Compressed Size", extraSize+totalComp + "  KB.");


        }

        private async void btnCreateFile_Click(object sender, EventArgs e)
        {
            FrequencyGenerator fg = new FrequencyGenerator();
            Stopwatch watch = new Stopwatch();
            lblStatus.Text = "Calculating Frequencies...";
            watch.Start();
            await Task.Run(()=>fg.GenerateFromImage(ImageData.ImageMatrix));
            lblStatus.Text = "Constructing Tree...";
            HuffmanTree tree = new HuffmanTree(fg);
            await Task.Run(() => tree.ConstructTree());
            BinaryFile file = new BinaryFile(ImageData.ImageMatrix, ImageData.InitialSeed, ImageData.TapPosition, ImageData.Width, ImageData.Height,ImageData.NumberOfBits, tree);
            lblStatus.Text = "Creating Binary File.";
            await Task.Run(() => file.Create(txtFileName.Text));
            watch.Stop();
            lblStatus.Text = "Binary File Created.";
            lblTimeTaken.Visible = true;
            string te = watch.Elapsed.ToString(@"m\:ss");
            lblTimeTaken.Text = te;
        }
    }
}
