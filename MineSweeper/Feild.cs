using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Field
    {

        public Button[,] buttons = new Button[10, 10];
        public Form1 form1 { get; set; }
        public Create create { get; set; }
        public Counters counter { get; set; }
        public int TotalAmmountOfBombs { get; set; }
        public int FlagsLeftToPlace { get; set; }
        public Field()
        {

        }
        public void Connect(Form1 form)
        {
            form1 = form;
            counter = form1.counter;
            create = form1.create;
            FlagsLeftToPlace = Form1.Bombs;
            TotalAmmountOfBombs = Form1.Bombs;
        }
        



        public void Restart()
        {

            FlagsLeftToPlace = Form1.Bombs;
            Form1.FirstClick = true;
            create.Createfield(false);
            Form1.Time = 0;
            Form1.Done = false;
            Form1.TimerAndStuff.ResetTimer();
            Form1.myTimer.Stop();

        }


        public void OpenButton(Button button)
        {
            if (Form1.FirstClick)
            {
                create.PlaceBombs(Form1.Bombs, button);
                Form1.FirstClick = false;
                Form1.myTimer.Start();
            }

            if (!button.Open && button.Bomb && !button.Flagged)
            {
                button.Open = true;
                button.form1.Finished(false);

            }

            else if (!button.Flagged && !button.Open)
            {

                //button.Open = true;
                button.ThisButton.Image = counter.CountAndShowNumberOfBombs(button);
            }
            else if (button.Open && !button.Flagged)
            {
                int x = button.id[0];
                int y = button.id[1];
                if (counter.CountFlaggs(button) == button.AmmountOfBombs)
                {
                    for (int a = -1; a <= 1; a++)
                        for (int b = -1; b <= 1; b++)
                            if (!(a == 0 && b == 0) && counter.CheckIfInsidefield(x + a, y + b))
                            {
                                buttons[x + a, y + b].Open = false;
                                OpenButton(buttons[x + a, y + b]);

                            }
                }

            }
        }






        
        public void Show()
        {
            for (int a = 0; a <= 9; a++)
                for (int b = 0; b <= 9; b++)
                {
                    if (buttons[a, b].Bomb && !buttons[a, b].Open && !buttons[a, b].Flagged)
                        buttons[a, b].ThisButton.Image = buttons[a, b].images.BombImage;
                    else if (!buttons[a, b].Bomb && !buttons[a, b].Open && buttons[a, b].Flagged)
                        buttons[a, b].ThisButton.Image = buttons[a, b].images.WrongPlacedFlag;
                    else if (buttons[a, b].Bomb && buttons[a, b].Open)
                        buttons[a, b].ThisButton.Image = buttons[a, b].images.OpenedBomb;
                    else if (!buttons[a, b].Bomb && buttons[a, b].Flagged)
                        buttons[a, b].ThisButton.Image = buttons[a, b].images.WrongPlacedFlag;


                    buttons[a, b].ThisButton.Update();
                }
        }

        
       


    }
}
    