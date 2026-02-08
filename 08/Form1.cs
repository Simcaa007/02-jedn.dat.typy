using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool delitel = false;
            foreach (string line in textBox1.Lines)
            {
                int cislo = int.Parse(line);
                for (int i = 2; i < cislo; i++)
                {
                    if (cislo % i == 0)
                    {
                        delitel = true;
                        break;
                    }
                }
            }
            if (!delitel)
            {
                MessageBox.Show("Ano, bylo nalezeno prvocislo.");
            }
            else
            {
                MessageBox.Show("Ne, nebylo nalezeno prvocislo.");
            }
        }
    }
}
