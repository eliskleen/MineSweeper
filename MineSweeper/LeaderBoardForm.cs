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
    public partial class LeaderBoardForm : Form
    {
        public LeaderBoardForm()
        {
            InitializeComponent();
        }

        private void LeaderBoardForm_Load(object sender, EventArgs e)
        {
            List<string> Games = new List<string>();

            Games.Add("Beginner");
            Games.Add("Intermediate");
            Games.Add("Expert");

            comboBox1.DataSource = Games;

            comboBox1.Text = Form1.Game;
            UpdateDatagrid(comboBox1.Text);
        }
        public void UpdateDatagrid(string Game)
        {
            LBoard LBoard = new LBoard();

            dataGridView1.DataSource = LBoard.GetLeaderBoard(Game);
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDatagrid(comboBox1.Text);
        }
    }
}
