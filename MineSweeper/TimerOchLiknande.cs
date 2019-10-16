using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public class TimerOchLiknande
    {
        Form1 form1 { get; set; }
        public void Connect(Form1 form)
        {
            form1 = form;
        }


        public void SmileyBox_MouseDown(object sender, MouseEventArgs e)
        {

        }




        public void SetSmiley(SmileyNames name)
        {
            if (name == SmileyNames.Blown)
                form1.SmileyBox.Image = form1.images.BlownSmiley;
            else if (name == SmileyNames.normal)
                form1.SmileyBox.Image = form1.images.RegularSmiley;
            else if(name == SmileyNames.PressedNormal)
                form1.SmileyBox.Image = form1.images.PressedRegularSmiley;
            else if(name == SmileyNames.winning)
                form1.SmileyBox.Image = form1.images.WinningSmiley;
        }

        public enum SmileyNames
        {
            normal,
            PressedNormal, 
            Blown, 
            winning
        }



        public void FlagsLeftToPlace()
        {
            bool minus = false;
            int flags = form1.field.FlagsLeftToPlace;


                if (flags < 0)
                {
                    minus = true;
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.minus;
                }


            if (flags / 100 >= 0 && !minus)
            {
                if (flags / 100 == 0)
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.zero;
                else if (flags / 100 == 1)
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.one;
                else if (flags / 100 == 2)
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.two;
                else if (flags / 100 == 3)
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.three;
                else if (flags / 100 == 4)
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.four;
                else if (flags / 100 == 5)
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.five;
                else if (flags / 100 == 6)
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.six;
                else if (flags / 100 == 7)
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.seven;
                else if (flags / 100 == 8)
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.eight;
                else if (flags / 100 == 9)
                    form1.FlagsLeftToPlaceHundreadsBox.Image = form1.images.nine;


                flags = flags % 100;
            }


            if (minus)
                flags = (flags * -1);

            if (flags / 10 >= 0)
            {
                if (flags / 10 == 0)
                    form1.FlagsLeftToPlaceTensBox.Image = form1.images.zero;
                else if (flags / 10 == 1)
                    form1.FlagsLeftToPlaceTensBox.Image = form1.images.one;
                else if (flags / 10 == 2)
                    form1.FlagsLeftToPlaceTensBox.Image = form1.images.two;
                else if (flags / 10 == 3)
                    form1.FlagsLeftToPlaceTensBox.Image = form1.images.three;
                else if (flags / 10 == 4)
                    form1.FlagsLeftToPlaceTensBox.Image = form1.images.four;
                else if (flags / 10 == 5)
                    form1.FlagsLeftToPlaceTensBox.Image = form1.images.five;
                else if (flags / 10 == 6)
                    form1.FlagsLeftToPlaceTensBox.Image = form1.images.six;
                else if (flags / 10 == 7)
                    form1.FlagsLeftToPlaceTensBox.Image = form1.images.seven;
                else if (flags / 10 == 8)
                    form1.FlagsLeftToPlaceTensBox.Image = form1.images.eight;
                else if (flags / 10 == 9)
                    form1.FlagsLeftToPlaceTensBox.Image = form1.images.nine;
                flags = flags % 10;
            }

            if (flags / 1 >= 0)
            {
                if (flags / 1 == 0)
                    form1.FlagsLeftToPlaceOnesBox.Image = form1.images.zero;
                else if (flags / 1 == 1)
                    form1.FlagsLeftToPlaceOnesBox.Image = form1.images.one;
                else if (flags / 1 == 2)
                    form1.FlagsLeftToPlaceOnesBox.Image = form1.images.two;
                else if (flags / 1 == 3)
                    form1.FlagsLeftToPlaceOnesBox.Image = form1.images.three;
                else if (flags / 1 == 4)
                    form1.FlagsLeftToPlaceOnesBox.Image = form1.images.four;
                else if (flags / 1 == 5)
                    form1.FlagsLeftToPlaceOnesBox.Image = form1.images.five;
                else if (flags / 1 == 6)
                    form1.FlagsLeftToPlaceOnesBox.Image = form1.images.six;
                else if (flags / 1 == 7)
                    form1.FlagsLeftToPlaceOnesBox.Image = form1.images.seven;
                else if (flags / 1 == 8)
                    form1.FlagsLeftToPlaceOnesBox.Image = form1.images.eight;
                else if (flags / 1 == 9)
                    form1.FlagsLeftToPlaceOnesBox.Image = form1.images.nine;


                flags = flags % 1;
            }
        }


        public void ResetTimer()
        {
            form1.TimerHundreadsBox.Image = form1.images.zero;
            form1.TimerTensBox.Image = form1.images.zero;
            form1.TimerOnesBox.Image = form1.images.zero;
        }

        public  void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            if (!Form1.Done)
            {
                Form1.Time++;
                int ThisTime = Form1.Time / 100;


                if (ThisTime == 999)
                {
                    form1.TimerHundreadsBox.Image = form1.images.nine;
                    form1.TimerTensBox.Image = form1.images.nine;
                    form1.TimerOnesBox.Image = form1.images.nine;
                    //form1.MessageBox.Show("Damn u slow");
                }
                else if (ThisTime < 999)
                {
                    if (ThisTime / 100 >= 0)
                    {
                        if (ThisTime / 100 == 0)
                            form1.TimerHundreadsBox.Image = form1.images.zero;
                        else if (ThisTime / 100 == 1)
                            form1.TimerHundreadsBox.Image = form1.images.one;
                        else if (ThisTime / 100 == 2)
                            form1.TimerHundreadsBox.Image = form1.images.two;
                        else if (ThisTime / 100 == 3)
                            form1.TimerHundreadsBox.Image = form1.images.three;
                        else if (ThisTime / 100 == 4)
                            form1.TimerHundreadsBox.Image = form1.images.four;
                        else if (ThisTime / 100 == 5)
                            form1.TimerHundreadsBox.Image = form1.images.five;
                        else if (ThisTime / 100 == 6)
                            form1.TimerHundreadsBox.Image = form1.images.six;
                        else if (ThisTime / 100 == 7)
                            form1.TimerHundreadsBox.Image = form1.images.seven;
                        else if (ThisTime / 100 == 8)
                            form1.TimerHundreadsBox.Image = form1.images.eight;
                        else if (ThisTime / 100 == 9)
                            form1.TimerHundreadsBox.Image = form1.images.nine;


                        ThisTime = ThisTime % 100;
                    }
                    if (ThisTime / 10 >= 0)
                    {
                        if (ThisTime / 10 == 0)
                            form1.TimerTensBox.Image = form1.images.zero;
                        else if (ThisTime / 10 == 1)
                            form1.TimerTensBox.Image = form1.images.one;
                        else if (ThisTime / 10 == 2)
                            form1.TimerTensBox.Image = form1.images.two;
                        else if (ThisTime / 10 == 3)
                            form1.TimerTensBox.Image = form1.images.three;
                        else if (ThisTime / 10 == 4)
                            form1.TimerTensBox.Image = form1.images.four;
                        else if (ThisTime / 10 == 5)
                            form1.TimerTensBox.Image = form1.images.five;
                        else if (ThisTime / 10 == 6)
                            form1.TimerTensBox.Image = form1.images.six;
                        else if (ThisTime / 10 == 7)
                            form1.TimerTensBox.Image = form1.images.seven;
                        else if (ThisTime / 10 == 8)
                            form1.TimerTensBox.Image = form1.images.eight;
                        else if (ThisTime / 10 == 9)
                            form1.TimerTensBox.Image = form1.images.nine;


                        ThisTime = ThisTime % 10;
                    }
                    if (ThisTime / 1 >= 0)
                    {
                        if (ThisTime / 1 == 0)
                            form1.TimerOnesBox.Image = form1.images.zero;
                        else if (ThisTime / 1 == 1)
                            form1.TimerOnesBox.Image = form1.images.one;
                        else if (ThisTime / 1 == 2)
                            form1.TimerOnesBox.Image = form1.images.two;
                        else if (ThisTime / 1 == 3)
                            form1.TimerOnesBox.Image = form1.images.three;
                        else if (ThisTime / 1 == 4)
                            form1.TimerOnesBox.Image = form1.images.four;
                        else if (ThisTime / 1 == 5)
                            form1.TimerOnesBox.Image = form1.images.five;
                        else if (ThisTime / 1 == 6)
                            form1.TimerOnesBox.Image = form1.images.six;
                        else if (ThisTime / 1 == 7)
                            form1.TimerOnesBox.Image = form1.images.seven;
                        else if (ThisTime / 1 == 8)
                            form1.TimerOnesBox.Image = form1.images.eight;
                        else if (ThisTime / 1 == 9)
                            form1.TimerOnesBox.Image = form1.images.nine;


                        ThisTime = ThisTime % 1;
                    }
                }

            }


        }
    }
}
