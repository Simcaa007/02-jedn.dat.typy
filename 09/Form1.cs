using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minSude = 0;
            bool sudeNalezeno = false;
            int i = 0;
            int radky = textBox1.Lines.Length;

            while (i < radky && !sudeNalezeno)
            {
                int cislo = int.Parse(textBox1.Lines[i]);
                if (cislo % 2 == 0)
                {
                    minSude = cislo;
                    sudeNalezeno = true;
                }
                i++;
            }

            while (i < radky)
            {
                int cislo = int.Parse(textBox1.Lines[i]);
                if (cislo % 2 == 0 && cislo < minSude)
                {
                    minSude = cislo;
                }
                i++;
            }

            if (!sudeNalezeno)
            {
                MessageBox.Show("Nenalezeno zadne sude cislo.");
                return;
            }
            else
            {
                MessageBox.Show($"Nejmensi sude cislo je {minSude}.");
            }
        }
    }
}
