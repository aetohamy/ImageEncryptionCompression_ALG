namespace ImageEncryptCompress.Forms
{
    partial class MainFormUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnOpenImage = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtWidth = new MetroFramework.Controls.MetroTextBox();
            this.txtHeight = new MetroFramework.Controls.MetroTextBox();
            this.txtTapPosition = new MetroFramework.Controls.MetroTextBox();
            this.txtInitialSeed = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnEncryptDecrypt = new MetroFramework.Controls.MetroButton();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.lblTimeTaken = new MetroFramework.Controls.MetroLabel();
            this.btnColorFrequencies = new MetroFramework.Controls.MetroButton();
            this.btnConstructHuffmanTree = new MetroFramework.Controls.MetroButton();
            this.btnCompress = new MetroFramework.Controls.MetroButton();
            this.btnDecompress = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(13, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(420, 386);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(418, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "ORIGINAL IMAGE";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.AutoScroll = true;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.HorizontalScrollbar = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(442, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(420, 386);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbar = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(3, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(412, 358);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(418, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "TRANSFORMED IMAGE";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel3.Location = new System.Drawing.Point(13, 557);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(849, 2);
            this.metroLabel3.TabIndex = 2;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(13, 453);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(420, 49);
            this.btnOpenImage.TabIndex = 3;
            this.btnOpenImage.Text = "Open Image...";
            this.btnOpenImage.UseSelectable = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(614, 15);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Image Width :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(611, 37);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Image Height :";
            // 
            // txtWidth
            // 
            // 
            // 
            // 
            this.txtWidth.CustomButton.Image = null;
            this.txtWidth.CustomButton.Location = new System.Drawing.Point(89, 2);
            this.txtWidth.CustomButton.Name = "";
            this.txtWidth.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWidth.CustomButton.TabIndex = 1;
            this.txtWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWidth.CustomButton.UseSelectable = true;
            this.txtWidth.CustomButton.Visible = false;
            this.txtWidth.Lines = new string[0];
            this.txtWidth.Location = new System.Drawing.Point(709, 13);
            this.txtWidth.MaxLength = 32767;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.PasswordChar = '\0';
            this.txtWidth.ReadOnly = true;
            this.txtWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWidth.SelectedText = "";
            this.txtWidth.SelectionLength = 0;
            this.txtWidth.SelectionStart = 0;
            this.txtWidth.ShortcutsEnabled = true;
            this.txtWidth.Size = new System.Drawing.Size(107, 20);
            this.txtWidth.TabIndex = 6;
            this.txtWidth.UseSelectable = true;
            this.txtWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHeight
            // 
            // 
            // 
            // 
            this.txtHeight.CustomButton.Image = null;
            this.txtHeight.CustomButton.Location = new System.Drawing.Point(89, 2);
            this.txtHeight.CustomButton.Name = "";
            this.txtHeight.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHeight.CustomButton.TabIndex = 1;
            this.txtHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHeight.CustomButton.UseSelectable = true;
            this.txtHeight.CustomButton.Visible = false;
            this.txtHeight.Lines = new string[0];
            this.txtHeight.Location = new System.Drawing.Point(709, 37);
            this.txtHeight.MaxLength = 32767;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '\0';
            this.txtHeight.ReadOnly = true;
            this.txtHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHeight.SelectedText = "";
            this.txtHeight.SelectionLength = 0;
            this.txtHeight.SelectionStart = 0;
            this.txtHeight.ShortcutsEnabled = true;
            this.txtHeight.Size = new System.Drawing.Size(107, 20);
            this.txtHeight.TabIndex = 7;
            this.txtHeight.UseSelectable = true;
            this.txtHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTapPosition
            // 
            // 
            // 
            // 
            this.txtTapPosition.CustomButton.Image = null;
            this.txtTapPosition.CustomButton.Location = new System.Drawing.Point(89, 2);
            this.txtTapPosition.CustomButton.Name = "";
            this.txtTapPosition.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtTapPosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTapPosition.CustomButton.TabIndex = 1;
            this.txtTapPosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTapPosition.CustomButton.UseSelectable = true;
            this.txtTapPosition.CustomButton.Visible = false;
            this.txtTapPosition.Lines = new string[0];
            this.txtTapPosition.Location = new System.Drawing.Point(107, 27);
            this.txtTapPosition.MaxLength = 32767;
            this.txtTapPosition.Name = "txtTapPosition";
            this.txtTapPosition.PasswordChar = '\0';
            this.txtTapPosition.ReadOnly = true;
            this.txtTapPosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTapPosition.SelectedText = "";
            this.txtTapPosition.SelectionLength = 0;
            this.txtTapPosition.SelectionStart = 0;
            this.txtTapPosition.ShortcutsEnabled = true;
            this.txtTapPosition.Size = new System.Drawing.Size(107, 20);
            this.txtTapPosition.TabIndex = 11;
            this.txtTapPosition.UseSelectable = true;
            this.txtTapPosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTapPosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInitialSeed
            // 
            // 
            // 
            // 
            this.txtInitialSeed.CustomButton.Image = null;
            this.txtInitialSeed.CustomButton.Location = new System.Drawing.Point(89, 2);
            this.txtInitialSeed.CustomButton.Name = "";
            this.txtInitialSeed.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtInitialSeed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInitialSeed.CustomButton.TabIndex = 1;
            this.txtInitialSeed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInitialSeed.CustomButton.UseSelectable = true;
            this.txtInitialSeed.CustomButton.Visible = false;
            this.txtInitialSeed.Lines = new string[0];
            this.txtInitialSeed.Location = new System.Drawing.Point(107, 4);
            this.txtInitialSeed.MaxLength = 32767;
            this.txtInitialSeed.Name = "txtInitialSeed";
            this.txtInitialSeed.PasswordChar = '\0';
            this.txtInitialSeed.ReadOnly = true;
            this.txtInitialSeed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInitialSeed.SelectedText = "";
            this.txtInitialSeed.SelectionLength = 0;
            this.txtInitialSeed.SelectionStart = 0;
            this.txtInitialSeed.ShortcutsEnabled = true;
            this.txtInitialSeed.Size = new System.Drawing.Size(107, 20);
            this.txtInitialSeed.TabIndex = 10;
            this.txtInitialSeed.UseSelectable = true;
            this.txtInitialSeed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInitialSeed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(9, 27);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Tap Position :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(9, 5);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(79, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Initial Seed :";
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.txtInitialSeed);
            this.metroPanel3.Controls.Add(this.txtTapPosition);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(633, 448);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(229, 54);
            this.metroPanel3.TabIndex = 12;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnEncryptDecrypt
            // 
            this.btnEncryptDecrypt.Location = new System.Drawing.Point(442, 453);
            this.btnEncryptDecrypt.Name = "btnEncryptDecrypt";
            this.btnEncryptDecrypt.Size = new System.Drawing.Size(185, 49);
            this.btnEncryptDecrypt.TabIndex = 13;
            this.btnEncryptDecrypt.Text = "Encrypt / Decrypt...";
            this.btnEncryptDecrypt.UseSelectable = true;
            this.btnEncryptDecrypt.Click += new System.EventHandler(this.btnEncryptDecrypt_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 585);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 19);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status.";
            this.lblStatus.UseCustomForeColor = true;
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimeTaken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimeTaken.Location = new System.Drawing.Point(20, 566);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(79, 19);
            this.lblTimeTaken.TabIndex = 15;
            this.lblTimeTaken.Text = "Time Taken.";
            this.lblTimeTaken.UseCustomForeColor = true;
            this.lblTimeTaken.Visible = false;
            // 
            // btnColorFrequencies
            // 
            this.btnColorFrequencies.Location = new System.Drawing.Point(14, 508);
            this.btnColorFrequencies.Name = "btnColorFrequencies";
            this.btnColorFrequencies.Size = new System.Drawing.Size(202, 46);
            this.btnColorFrequencies.TabIndex = 16;
            this.btnColorFrequencies.Text = "Color Frequencies...";
            this.btnColorFrequencies.UseSelectable = true;
            this.btnColorFrequencies.Click += new System.EventHandler(this.btnColorFrequencies_Click);
            // 
            // btnConstructHuffmanTree
            // 
            this.btnConstructHuffmanTree.Location = new System.Drawing.Point(222, 508);
            this.btnConstructHuffmanTree.Name = "btnConstructHuffmanTree";
            this.btnConstructHuffmanTree.Size = new System.Drawing.Size(211, 46);
            this.btnConstructHuffmanTree.TabIndex = 17;
            this.btnConstructHuffmanTree.Text = "Huffman Tree...";
            this.btnConstructHuffmanTree.UseSelectable = true;
            this.btnConstructHuffmanTree.Click += new System.EventHandler(this.btnConstructHuffmanTree_Click);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(442, 505);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(185, 49);
            this.btnCompress.TabIndex = 18;
            this.btnCompress.Text = "Compress...";
            this.btnCompress.UseSelectable = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnDecompress
            // 
            this.btnDecompress.Location = new System.Drawing.Point(633, 505);
            this.btnDecompress.Name = "btnDecompress";
            this.btnDecompress.Size = new System.Drawing.Size(229, 49);
            this.btnDecompress.TabIndex = 19;
            this.btnDecompress.Text = "Decompress...";
            this.btnDecompress.UseSelectable = true;
            this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);
            // 
            // MainFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 624);
            this.Controls.Add(this.btnDecompress);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnConstructHuffmanTree);
            this.Controls.Add(this.btnColorFrequencies);
            this.Controls.Add(this.lblTimeTaken);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnEncryptDecrypt);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "MainFormUI";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Image Encryption and Compression";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnOpenImage;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtWidth;
        private MetroFramework.Controls.MetroTextBox txtHeight;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox txtTapPosition;
        private MetroFramework.Controls.MetroTextBox txtInitialSeed;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btnEncryptDecrypt;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLabel lblTimeTaken;
        private MetroFramework.Controls.MetroButton btnColorFrequencies;
        private MetroFramework.Controls.MetroButton btnConstructHuffmanTree;
        private MetroFramework.Controls.MetroButton btnCompress;
        private MetroFramework.Controls.MetroButton btnDecompress;
    }
}