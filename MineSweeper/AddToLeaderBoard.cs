using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class AddToLeaderBoard : Form
    {
        public int Time { get; set; }

        public AddToLeaderBoard(int time)
        {
            InitializeComponent();
            Time = time;
        }

        private void AddToLeaderBoard_Load(object sender, EventArgs e)
        {
            float ActualTime = (float)Time / 100;
            TimeTxtBox.Text = ActualTime.ToString();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            LBoard Lboard = new LBoard();

            Lboard.AddToLeaderBoard(Time, NameTxtBox.Text, Form1.Bombs);
            Close();
        }
    }
}
