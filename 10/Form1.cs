using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Random rnd = new Random();
            bool velkaPismena = false;
            int soucet = 0;

            for (int i = 0; i < n; i++)
            {
                int Od = '*';
                int Do = 'M';
                char znak = (char)rnd.Next(Od, Do);
                listBox1.Items.Add(znak);
            }

            if (checkBox1.Checked)
            {
                foreach (char line in listBox1.Items)
                {
                    if (line >= '0' && line <= '9')
                    {
                        soucet += line - '0';
                    }
                }
            }
            if (checkBox2.Checked)
            {
                int pocet = 0;
                if (!velkaPismena)
                {
                    foreach (char line in listBox1.Items)
                    {
                        if (line >= 'A' && line <= 'Z')
                        {
                            pocet++;
                            if (pocet == 3)
                            {
                                velkaPismena = true;
                            }
                        }
                    }
                }
            }

            if (velkaPismena)
            {
                MessageBox.Show("Byla nalezena 3 velka pismena.");
            }
            if (soucet != 0)
            {
                MessageBox.Show($"Soucet cisel je {soucet}.");
            }
            if(!velkaPismena && soucet == 0)
            {
                MessageBox.Show("Nenalezena zadna velka pismena a zadna cisla.");
            }
        }
    }
}
