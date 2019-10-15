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
            LBoard LBoard = new LBoard();
            List<LeaderBoard> LeaderBoard = LBoard.GetLeaderBoard(0);
            List<int> AmmountOfBombs = new List<int>();

            foreach (LeaderBoard row in LeaderBoard)
            {
                AmmountOfBombs.Add(row.AmmountOfBombs);
            }
            AmmountOfBombs.Sort();

            comboBox1.DataSource = AmmountOfBombs.Distinct().ToList();

            comboBox1.Text = Form1.Bombs.ToString();
            UpdateDatagrid(Form1.Bombs);
        }
        public void UpdateDatagrid(int Bombs)
        {
            LBoard LBoard = new LBoard();

            dataGridView1.DataSource = LBoard.GetLeaderBoard(Bombs);
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDatagrid(Int32.Parse(comboBox1.Text));
        }
    }
}
