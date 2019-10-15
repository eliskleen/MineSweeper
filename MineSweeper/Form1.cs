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
    public partial class Form1 : Form
    {

        public Field field = new Field();
        public Counters counter = new Counters();
        public Create create = new Create();
        public static TimerOchLiknande TimerAndStuff = new TimerOchLiknande();
        public static Timer myTimer = new Timer();
        public static bool FirstClick = true;
        public Images images = new Images();

        public LBoard board = new LBoard();

        public static int Bombs = 10;
        public static bool Done { get; set; }
        public static int Time { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




            Time = 0;
            myTimer.Tick += new EventHandler(TimerAndStuff.TimerEventProcessor);
            myTimer.Interval = 10;

            
            field.Connect(this);
            create.Connect(field);
            counter.Connect(this);


            
            TimerAndStuff.Connect(this);

            
            field.create.Createfield(true);

            TimerOnesBox.Image = images.zero;
            TimerTensBox.Image = images.zero;
            TimerHundreadsBox.Image = images.zero;
            TimerAndStuff.SetSmiley(TimerOchLiknande.SmileyNames.normal);

            TimerAndStuff.FlagsLeftToPlace();

            
            comboBox1.Text = Bombs.ToString();
            comboBox1.Enabled = false;
            comboBox1.Enabled = true;
            // bool pressed = field.buttons[1, 3].Bomb;


            //field.Show();

        }
        public void Finished(bool won)
        {
            if (!won)
            {
                field.Show();
                Done = true;
                TimerAndStuff.SetSmiley(TimerOchLiknande.SmileyNames.Blown);
               
            }
            else
            {
                TimerAndStuff.SetSmiley(TimerOchLiknande.SmileyNames.winning);
                Done = true;
                if(board.IsTopTen(Time, Bombs))
                {
                    AddToLeaderBoard AddForm = new AddToLeaderBoard(Time);
                    AddForm.ShowDialog();
                }
                

            }

        }

        private void SmileyBox_MouseDown(object sender, MouseEventArgs e)
        {
            TimerAndStuff.SetSmiley(TimerOchLiknande.SmileyNames.PressedNormal);
        }

        private void SmileyBox_MouseUp(object sender, MouseEventArgs e)
        {
            TimerAndStuff.SetSmiley(TimerOchLiknande.SmileyNames.normal);
            
            field.Restart();
            button1.PerformClick();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!myTimer.Enabled)
            {

                int test = 0;
                string text = comboBox1.Text;
                string[] split = text.Split(':');

                if (split[0] == "TimerIntervallSet")
                {
                    if (Int32.TryParse(split[1], out test))
                        myTimer.Interval = test;
                }
                else if (Int32.TryParse(text, out test))
                {
                    if(test > 91)
                        MessageBox.Show("Asså va gör du? kan du inte räkna eller? du får inte ha mer än 91 bomber....");
                    else
                    {
                        Bombs = test;
                        field.FlagsLeftToPlace = Bombs;
                        TimerAndStuff.FlagsLeftToPlace();
                    }
                    
                }
                else
                    MessageBox.Show("Asså fattar du inte att det bara ska vara siffror här? Ärligt...");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void ShowLeaderBoard_Click(object sender, EventArgs e)
        {
            LeaderBoardForm l = new LeaderBoardForm();
            l.Show();
        }
    }
}
