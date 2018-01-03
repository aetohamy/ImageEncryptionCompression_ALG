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
    public partial class ColorFrequenciesForm : MetroFramework.Forms.MetroForm
    {
        public FrequencyGenerator ColorFrequencies { get; set; }

        public ColorFrequenciesForm(FrequencyGenerator fg)
        {
            InitializeComponent();
            ColorFrequencies = fg;
        }

        private void ColorFrequenciesForm_Load(object sender, EventArgs e)
        {
             List<Tuple<byte, int>> redFrequencies = new List<Tuple<byte, int>>();
            for(int i = 0; i < 256; i++)
            {
                if (ColorFrequencies.RedFrequencies[i] != 0)
                    redFrequencies.Add(new Tuple<byte, int>((byte)i, ColorFrequencies.RedFrequencies[i]));
            }

            List<Tuple<byte, int>> greenFrequencies = new List<Tuple<byte, int>>();
            for (int i = 0; i < 256; i++)
            {
                if (ColorFrequencies.GreenFrequencies[i] != 0)
                    greenFrequencies.Add(new Tuple<byte, int>((byte)i, ColorFrequencies.GreenFrequencies[i]));
            }

            List<Tuple<byte, int>> blueFrequencies = new List<Tuple<byte, int>>();
            for (int i = 0; i < 256; i++)
            {
                if (ColorFrequencies.BlueFrequencies[i] != 0)
                   blueFrequencies.Add(new Tuple<byte, int>((byte)i, ColorFrequencies.BlueFrequencies[i]));
            }

            dataGridViewRed.DataSource = redFrequencies.ToArray();
            dataGridViewRed.Columns[0].HeaderText = "Color";
            dataGridViewRed.Columns[1].HeaderText = "Frequency Count";
            dataGridViewGreen.DataSource = greenFrequencies.ToArray();
            dataGridViewGreen.Columns[0].HeaderText = "Color";
            dataGridViewGreen.Columns[1].HeaderText = "Frequency Count";
            dataGridViewBlue.DataSource = blueFrequencies.ToArray();
            dataGridViewBlue.Columns[0].HeaderText = "Color";
            dataGridViewBlue.Columns[1].HeaderText = "Frequency Count";
        }
    }
}
