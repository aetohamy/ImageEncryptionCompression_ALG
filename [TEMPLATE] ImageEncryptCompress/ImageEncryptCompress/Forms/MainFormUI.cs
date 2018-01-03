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
    public partial class MainFormUI : MetroFramework.Forms.MetroForm
    {
        public RGBPixel[,] ImageMatrix { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public long InitialSeed { get; set; }
        public byte NumberOfBits { get; set; }
        public byte TapPosition { get; set;}

        public MainFormUI()
        {
            InitializeComponent();
            this.ActiveControl = metroLabel1;
            NumberOfBits = 0;
        }

        private async void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Bitmap Images. (.bmp) |*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the bImageHeighted image and display it
                string OpenedFilePath = openFileDialog1.FileName;
                lblStatus.Text = "Opening Image...";
                this.ActiveControl = metroLabel1;
                await Task.Run(() =>ImageMatrix = ImageOperations.OpenImage(OpenedFilePath));
                ImageOperations.DisplayImage(ImageMatrix, pictureBox1);
                lblStatus.Text = "Image Loaded.";
                txtWidth.Text = ImageOperations.GetWidth(ImageMatrix).ToString();
                txtHeight.Text = ImageOperations.GetHeight(ImageMatrix).ToString();
                ImageWidth = Convert.ToInt32(txtWidth.Text);
                ImageHeight = Convert.ToInt32(txtHeight.Text);
                lblTimeTaken.Visible = false;
            }
            this.ActiveControl = metroLabel1;
        }

        private void btnEncryptDecrypt_Click(object sender, EventArgs e)
        {
            EncryptForm encryptForm = new EncryptForm(txtInitialSeed.Text, txtTapPosition.Text);
            if (encryptForm.ShowDialog() == DialogResult.OK)
            {
                txtInitialSeed.Text = encryptForm.InitialSeed;
                txtTapPosition.Text = encryptForm.TapPosition;
                // Get Required Data and convert them to their corresponding data types
                long seed = 0;
                if (!encryptForm.IsAlphaNumeric)
                {
                     seed = Convert.ToInt64(encryptForm.InitialSeed, 2);
                }
                InitialSeed = seed;
                byte tap = Convert.ToByte(encryptForm.TapPosition);
                TapPosition = tap;
                byte bits = Convert.ToByte(encryptForm.InitialSeed.Length);
                NumberOfBits = bits;
                EncodeImage(seed, tap, bits,encryptForm.IsAlphaNumeric);
            }
        }

        private async void EncodeImage(long initialSeed, byte tap, byte numberOfBits , bool alpha)
        {
            if (!alpha)
            {
                Register register = new Register(initialSeed, tap, numberOfBits);  // O(1)
                long pixelsDone = 0; // UI
                Stopwatch watch = new Stopwatch(); //UI
                lblTimeTaken.Visible = true; //UI
                lblStatus.Text = "Encoding Image...";
                watch.Start(); //UI
                for (int i = 0; i < ImageHeight; i++) // O(N^2)
                {
                    await Task.Run(() =>
                    {
                        for (int j = 0; j < ImageWidth; j++) //O(N^2)
                        {
                            ImageMatrix[i, j].red ^= (byte)register.StepK(8); // O(1)
                        ImageMatrix[i, j].green ^= (byte)register.StepK(8); //O(1)
                        ImageMatrix[i, j].blue ^= (byte)register.StepK(8); //O(1)
                            pixelsDone++; // UI
                    }
                    }).
                    ContinueWith((ant) =>
                    {
                    //lblStatus.Text = "Encoding " + pixelsDone + " pixels / " + (ImageHeight * ImageWidth) + " pixels : " + ((long)(pixelsDone * 100) / (ImageHeight * ImageWidth))
                    string te = watch.Elapsed.ToString(@"m\:ss");
                        lblTimeTaken.Text = "Time Elapsed : " + te;
                    }
                    , TaskScheduler.FromCurrentSynchronizationContext());
                }
                watch.Stop();
                string tsOut = watch.Elapsed.ToString(@"m\:ss");
                lblTimeTaken.Text = "Time Elapsed : " + tsOut;
                lblStatus.Text = "Image Encoded.";
                ImageOperations.DisplayImage(ImageMatrix, pictureBox2);
            }
            else
            {
                PasswordRegister register = new PasswordRegister(txtInitialSeed.Text, TapPosition); // O(1)
                long pixelsDone = 0; // UI
                Stopwatch watch = new Stopwatch(); //UI
                lblTimeTaken.Visible = true; //UI
                lblStatus.Text = "Encoding Image...";
                watch.Start(); //UI
                for (int i = 0; i < ImageHeight; i++) 
                {
                    await Task.Run(() =>
                    {
                        for (int j = 0; j < ImageWidth; j++)
                        {
                            ImageMatrix[i, j].red ^= (byte)register.StepK(8); 
                            ImageMatrix[i, j].green ^= (byte)register.StepK(8); 
                            ImageMatrix[i, j].blue ^= (byte)register.StepK(8); 
                            pixelsDone++; // UI
                        }
                    }).
                    ContinueWith((ant) =>
                    {
                        //lblStatus.Text = "Encoding " + pixelsDone + " pixels / " + (ImageHeight * ImageWidth) + " pixels : " + ((long)(pixelsDone * 100) / (ImageHeight * ImageWidth))
                        string te = watch.Elapsed.ToString(@"m\:ss");
                        lblTimeTaken.Text = "Time Elapsed : " + te;
                    }
                    , TaskScheduler.FromCurrentSynchronizationContext());
                }
                watch.Stop();
                string tsOut = watch.Elapsed.ToString(@"m\:ss");
                lblTimeTaken.Text = "Time Elapsed : " + tsOut;
                lblStatus.Text = "Image Encoded.";
                ImageOperations.DisplayImage(ImageMatrix, pictureBox2);
            }
            //ImageColorFrequencies.GenerateFromImage(ImageMatrix);
        }

        private void btnColorFrequencies_Click(object sender, EventArgs e)
        {
            FrequencyGenerator fg = new FrequencyGenerator();
            fg.GenerateFromImage(ImageMatrix);
            ColorFrequenciesForm frequenciesForm = new ColorFrequenciesForm(fg);
            frequenciesForm.Show();
        }

        private void btnConstructHuffmanTree_Click(object sender, EventArgs e)
        {
            FrequencyGenerator fg = new FrequencyGenerator();
            fg.GenerateFromImage(ImageMatrix);
            HuffmanTree tree = new HuffmanTree(fg);
            tree.ConstructTree();
            tree.GetStringRepresentation();
            HuffmanTreeForm treeConstructionForm = new HuffmanTreeForm(tree);
            treeConstructionForm.Show();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            FrequencyGenerator fg = new FrequencyGenerator();
            fg.GenerateFromImage(ImageMatrix);
            HuffmanTree tree = new HuffmanTree(fg);
            tree.ConstructTree();
            ImageData data = new ImageData(ImageWidth, ImageHeight, TapPosition, InitialSeed,NumberOfBits, ImageMatrix);
            CompressFileForm compressForm = new CompressFileForm(data, tree);
            compressForm.Show();
        }

        private async void btnDecompress_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "TDAS Images. (.tdas) |*.tdas";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                BinaryFile file = new BinaryFile();
                Stopwatch watch = new Stopwatch();
                watch.Start();
                lblStatus.Text = "Decompressing Image...";
                await Task.Run(()=>file.Read(openFileDialog1.FileName));
                watch.Stop();
                lblStatus.Text = "Decompression Completed.";
                string te = watch.Elapsed.ToString(@"m\:ss");
                lblTimeTaken.Visible = true;
                lblTimeTaken.Text = te;
                ImageMatrix = file.Image;
                ImageHeight = file.ImageHeight;
                ImageWidth = file.ImageWidth;
                InitialSeed = file.InitialSeed;
                TapPosition = file.TapPosition;
                ImageOperations.DisplayImage(ImageMatrix, pictureBox1);
                txtHeight.Text = file.ImageHeight.ToString();
                txtWidth.Text = file.ImageWidth.ToString();
                string tmp = Convert.ToString(file.InitialSeed, 2);
                txtInitialSeed.Text = tmp.PadLeft(file.NumberOfBits, '0');
                txtTapPosition.Text = file.TapPosition.ToString();
            }
        }
    }
}
