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
        public static string Game = "";

        public LBoard board = new LBoard();

        public static int height { get; set; }
        public static int width  { get; set; }
        PictureBox creator = new PictureBox();

        public static int Bombs { get; set; }
        public static bool Done { get; set; }
        public static int Time { get; set; }
        public Form1()
        {
            InitializeComponent();
            height = 9;
            width = 9;
            InitializePictures();


        }
        public void InitializePictures()
        {
            int x = 13;
            int y = 130;
            
            for (float i = 0; i < 480; i++)
            {
                if (!this.Controls.ContainsKey($@"pictureBox{(i + 1).ToString()}"))
                {
                    this.creator = (System.Windows.Forms.PictureBox)this.Controls["pictureBox" + (i + 1).ToString()];
                    this.creator = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.creator)).BeginInit();
                    this.SuspendLayout();
                    
                    this.creator.Location = new System.Drawing.Point(x, y);

                    this.creator.Name = $"pictureBox{(i + 1).ToString()}";
                    this.creator.Size = new System.Drawing.Size(36, 36);
                    this.creator.TabIndex = 0;
                    this.creator.TabStop = false;

                    ((System.ComponentModel.ISupportInitialize)(this.creator)).EndInit();
                    this.Controls.Add(this.creator);
                }
                x += 37;
                if (((i + 1) / 30) % 1 == 0)
                {
                    y += 37;
                    x = 13;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Game = "Beginner";
            Bombs = 10;
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



            // bool pressed = field.buttons[1, 3].Bomb;


            //field.Show();
            SetLocations();

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
                if(board.IsTopTen(Time, Game))
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
        }



        



        private void ShowLeaderBoard_Click(object sender, EventArgs e)
        {
            LeaderBoardForm l = new LeaderBoardForm();
            l.Show();
        }

        private void intermediateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game = "Intermediate";
            Bombs = 40;
            width = 16;
            height = 16;
            SetLocations();
            field.Restart();
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game = "Expert";
            Bombs = 99;
            width = 30;
            height = 16;
            SetLocations();
            field.Restart();
        }

        private void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game = "Beginner";
            Bombs = 10;
            width = 9;
            height = 9;
            SetLocations();
            field.Restart();
        }
        public void SetLocations()
        {
            Size SetSize = new Size(width * 37 + 40, height * 36 + 194);
            Point SmileyPoint = new Point((((width * 37 + 40) / 2) - 29), SmileyBox.Location.Y);
            Point FlagCounterHundreadsLocation = new Point((width * 37 + 11) - 99, FlagsLeftToPlaceHundreadsBox.Location.Y);
            Point FlagCounterTensLocation = new Point((width * 37 + 11) - 66, FlagsLeftToPlaceTensBox.Location.Y);
            Point FlagCounterOnesLocation = new Point((width * 37 + 11) - 33, FlagsLeftToPlaceOnesBox.Location.Y);
            Point LeaderBoardButtonLocation = new Point((width * 37 + 11) - 99, ShowLeaderBoard.Location.Y);
            Size SizeOfToolstrip = new Size((width * 37 + 40), GameMenuStrip.Height);

            GameMenuStrip.Size = SizeOfToolstrip;
            ShowLeaderBoard.Location = LeaderBoardButtonLocation;
            FlagsLeftToPlaceHundreadsBox.Location = FlagCounterHundreadsLocation;
            FlagsLeftToPlaceTensBox.Location = FlagCounterTensLocation;
            FlagsLeftToPlaceOnesBox.Location = FlagCounterOnesLocation;
            SmileyBox.Location = SmileyPoint;
            this.Size = SetSize;
        }
    }
}
