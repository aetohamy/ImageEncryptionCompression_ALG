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
    public partial class EncryptForm : MetroFramework.Forms.MetroForm
    {
        public string InitialSeed { get; set; }
        public string TapPosition { get; set; }
        public bool IsAlphaNumeric { get; set; }

        public EncryptForm(string seed = "" , string tap ="")
        {
            InitializeComponent();
            InitialSeed = seed;
            TapPosition = tap;
            txtInitialSeed.Text = seed;
            txtTapPosition.Text = tap;
            IsAlphaNumeric = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            InitialSeed = txtInitialSeed.Text;
            TapPosition = txtTapPosition.Text;
            if (checkBoxAlphaNumeric.Checked) { IsAlphaNumeric = true; }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
