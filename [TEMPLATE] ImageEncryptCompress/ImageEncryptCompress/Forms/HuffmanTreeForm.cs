using ImageQuantization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEncryptCompress.Forms
{
    public partial class HuffmanTreeForm : MetroFramework.Forms.MetroForm
    {
        public HuffmanTree Tree { get; set; }

        public HuffmanTreeForm(HuffmanTree tree)
        {
            InitializeComponent();
            Tree = tree;
        }

        private void HuffmanTreeForm_Load(object sender, EventArgs e)
        {
            richTextBoxRed.Text = Tree.RedTreeString;
            richTextBoxGreen.Text = Tree.GreenTreeString;
            richTextBoxBlue.Text = Tree.BlueTreeString;
        }
    }
}
