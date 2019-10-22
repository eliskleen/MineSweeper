using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_fix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = MineSweeper.Form1.SetSize;
            var test = form11.AutoScaleDimensions;

        }


        private void form11_Resize(object sender, EventArgs e)
        {
            this.Size = MineSweeper.Form1.SetSize;
        }

        private void form11_Resize_1(object sender, EventArgs e)
        {
            this.Size = MineSweeper.Form1.SetSize;
        }
    }
}
