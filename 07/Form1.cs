using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pismena = 0;
            int cisla = 0;
            int lomitko = 0;
            int zbytek = 0;
            foreach (string line in textBox1.Lines)
            {
                char ch = line[0];
                if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
                {
                    pismena++;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    cisla++;
                }
                else if(ch == '\\')
                {
                    lomitko++;
                }
                else
                {
                    zbytek++;
                }
            }

            MessageBox.Show($"V textoboxu je {pismena} pismen," +
                $"{cisla} cisel, {lomitko} lomitek a {zbytek} jinych znaku.");

            foreach (string line in textBox1.Lines)
            {
                char ch = line[0];
                if (radioButton1.Checked)
                {
                    if (ch >= 'a' && ch <= 'z')
                    {
                        listBox1.Items.Add(line + ", " + (char)((int)ch - 32));
                    }
                    else
                    {
                        listBox1.Items.Add(line);
                    }
                }
                if (radioButton2.Checked)
                {
                    if (ch >= 'A' && ch <= 'Z')
                    {
                        listBox1.Items.Add(line + ", " + (char)((int)ch + 32));
                    }
                    else
                    {
                        listBox1.Items.Add(line);
                    }
                }

            }
        }
    }
}
