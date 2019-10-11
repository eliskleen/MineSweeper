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
            myTimer.Interval = 1000;


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
        }
    }
}
