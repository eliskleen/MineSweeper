using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Counters
    {
        Form1 form1 { get; set; }
        Field field { get; set; }

        public void Connect(Form1 Conform)
        {
            form1 = Conform;
            field = Conform.field;
        }
        public bool CheckIfAllOpened()
        {
            bool done = true;
            for (int b = 0; b < Form1.height; b++)
                for (int a = 0; a < Form1.width; a++)
                {
                    if (!form1.field.buttons[a, b].Bomb && !form1.field.buttons[a, b].Open)
                        done = false;

                }
            return done;
        }
        public int CountFlaggs(Button button)
        {

            int AmmountOfFlaggs = new int();
            int x = button.id[0];
            int y = button.id[1];
            button.Open = true;

            for (int a = -1; a <= 1; a++)
                for (int b = -1; b <= 1; b++)
                    if (!(a == 0 && b == 0) && CheckIfInsidefield(a + x, b + y))
                        if (form1.field.buttons[x + a, y + b].Flagged)
                            AmmountOfFlaggs++;

            return AmmountOfFlaggs;
        }
        public bool CheckIfInsidefield(int x, int y)
        {
            if ((((x) >= 0) && (x) < Form1.width) && (((y) >= 0) && (y) < Form1.height))
                return true;
            else
                return false;
        }
        public Image CountAndShowNumberOfBombs(Button button)
        {





            int AmmountOfBombs = 0;
            int x = button.id[0];
            int y = button.id[1];
            button.Open = true;
            

            for (int a = -1; a <= 1; a++)
                for (int b = -1; b <= 1; b++)
                    if (!(a == 0 && b == 0) && CheckIfInsidefield(a + x, b + y))
                        if (form1.field.buttons[x + a, y + b].Bomb)
                            AmmountOfBombs++;

            button.AmmountOfBombs = AmmountOfBombs;
            if (AmmountOfBombs == 0)
            {
                for (int a = -1; a <= 1; a++)
                    for (int b = -1; b <= 1; b++)
                        if (!(a == 0 && b == 0) && CheckIfInsidefield(a + x, b + y))
                            if (form1.field.buttons[x + a, y + b].Open == false)
                            {
                                form1.field.buttons[x + a, y + b].ThisButton.Image = CountAndShowNumberOfBombs(form1.field.buttons[x + a, y + b]);
                                form1.field.buttons[x + a, y + b].Open = true;

                            }


                return null;

            }

            else if (AmmountOfBombs == 1)
                return field.images.ButtonOne;
            else if (AmmountOfBombs == 2)
                return field.images.ButtonTwo;
            else if (AmmountOfBombs == 3)
                return field.images.ButtonThree;
            else if (AmmountOfBombs == 4)
                return field.images.ButtonFour;
            else if (AmmountOfBombs == 5)
                return field.images.ButtonFive;
            else if (AmmountOfBombs == 6)
                return field.images.ButtonSix;
            else
                return null;
        }
    }
}
