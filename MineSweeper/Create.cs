using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Create
    {

        Field field { get; set; }
        Counters count = new Counters();
        Form1 form1 { get; set; }

        public void Connect(Field Conform)
        {
            field = Conform;
            form1 = Conform.form1;
        }
        public void CreateButtons(bool first)
        {

            for (int a = 0; a <= 9; a++)
                for (int b = 0; b <= 9; b++)
                {
                    if (first)
                    {
                        field.buttons[a, b] = new Button();
                        field.buttons[a, b].Connect(field);
                    }
                    else
                    {
                        field.buttons[a, b].Open = false;
                        field.buttons[a, b].Flagged = false;
                        field.buttons[a, b].Bomb = false;
                        field.buttons[a, b].AmmountOfBombs = 0;
                        field.buttons[a, b].AmmountOfFlaggs = 0;
                    }



                }

        }
        public void Createfield(bool first)
        {
            Form1.TimerAndStuff.FlagsLeftToPlace();
            CreateButtons(first);
            int number = 0;
            for (int a = 0; a <= 9; a++)
                for (int b = 0; b <= 9; b++)
                {
                    field.buttons[a, b].id[0] = a;
                    field.buttons[a, b].id[1] = b;
                    field.buttons[a, b].ThisButton = (System.Windows.Forms.PictureBox)form1.Controls["pictureBox" + (number + 1).ToString()];
                    if (first)
                        field.buttons[a, b].ThisButton.MouseDown += field.buttons[a, b].Button_Clicked;
                    field.buttons[a, b].ThisButton.BackColor = Color.LightGray;
                    field.buttons[a, b].ThisButton.Image = field.buttons[a, b].images.UnpressedButton;
                    field.buttons[a, b].Open = false;
                    number++;
                }
        }
        public void PlaceBombs(int ammount, Button button)
        {

            bool ok = true;


            Random rnd = new Random();

            for (int a = 0; a <= ammount - 1; a = a)
            {
                ok = true;

                int RandX = rnd.Next(10);
                int RandY = rnd.Next(10);

                if (!field.buttons[RandX, RandY].Bomb)
                {

                    for (int x = -1; x <= 1; x++)
                        for (int y = -1; y <= 1; y++)
                            if (count.CheckIfInsidefield(RandX + x, RandY + y))
                                if ((field.buttons[RandX, RandY].id[0] == (button.id[0] + x)) && (field.buttons[RandX, RandY].id[1] == (button.id[1] + y)))
                                {
                                    ok = false;
                                    x = 3;
                                    y = 3;
                                }

                    if (ok)
                    {
                        field.buttons[RandX, RandY].Bomb = true;
                        field.TotalAmmountOfBombs++;
                        a++;
                    }


                }

            }

        }
    }
}
