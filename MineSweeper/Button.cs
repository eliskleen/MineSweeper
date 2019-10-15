﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public class Button
    {
        public Images images = new Images();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        public int AmmountOfFlaggs { get; set; }
        public int AmmountOfBombs { get; set; }
        public bool Bomb { get; set; }
        public bool Flagged { get; set; }
        public bool Open { get; set; }
        public int[] id = new int[2];
        public System.Windows.Forms.PictureBox ThisButton { get; set; }
        public Field field = new Field();
        public Form1 form1 { get; set; }
        public Counters counter = new Counters();

        public Button()
        {
            Flagged = false;
            Open = false;
            Bomb = false;


        }
        public void Connect(Field field1)
        {
            field = field1;
            form1 = field1.form1;
        }
        public void Button_Clicked(object sender, EventArgs e)
        {

            MouseEventArgs me = (MouseEventArgs)e;
            if (!Form1.Done)
            {


                if (me.Button == MouseButtons.Left)
                {

                    field.OpenButton(this);
                    if (form1.counter.CheckIfAllOpened())
                        form1.Finished(true);

                }
                if (me.Button == MouseButtons.Right && !Form1.FirstClick)
                {
                    if (!Flagged && !Open)
                    {
                        Flagged = !Flagged;
                        field.FlagsLeftToPlace--;
                        this.ThisButton.Image = images.Flag;
                        Form1.TimerAndStuff.FlagsLeftToPlace();
                    }
                    else if (Flagged && !Open)
                    {
                        Flagged = !Flagged;
                        field.FlagsLeftToPlace++;
                        Form1.TimerAndStuff.FlagsLeftToPlace();
                        this.ThisButton.Image = images.UnpressedButton;
                    }




                }


            }
        }
        
        
        
    }
}