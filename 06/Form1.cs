using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // zjistit podle vstupu a,b,c, zda se jedna o kvadr, pravidelny hranol nebo krychli (tj. pokud je a,b i c stejne, jedna se o krychli)


        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);

            if(a != b && b != c && c != a)
            {
                // Kvadr
            }
            else if (a == b && a!= c && b != c)
            {
                // Pravidelny hranol
            }
            else if (a == b && b == c)
            {
                // Krychle
                int a;
            }
        }
    }
}
