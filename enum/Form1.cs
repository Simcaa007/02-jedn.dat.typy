using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum dny
        {
            Pondeli,
            Utery,
            Streda,
            Ctvrtek,
            Patek,
            Sobota,
            Nedele
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Prvni den v tydnu je: {dny.Pondeli}");
        }
    }
}
