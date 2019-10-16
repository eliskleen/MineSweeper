using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace MineSweeper
{

    

    public class Images
    {

        public Image minus = Image.FromFile(@".//Bilder\Timer\Minus.png");
        public Image zero = Image.FromFile(@".//Bilder\Timer\Zero.png");
        public Image one = Image.FromFile(@".//Bilder\Timer\One.png");
        public Image two = Image.FromFile(@".//Bilder\Timer\Two.png");
        public Image three = Image.FromFile(@".//Bilder\Timer\Three.png");
        public Image four = Image.FromFile(@".//Bilder\Timer\Four.png");
        public Image five = Image.FromFile(@".//Bilder\Timer\Five.png");
        public Image six = Image.FromFile(@".//Bilder\Timer\Six.png");
        public Image seven = Image.FromFile(@".//Bilder\Timer\Seven.png");
        public Image eight = Image.FromFile(@".//Bilder\Timer\Eight.png");
        public Image nine = Image.FromFile(@".//Bilder\Timer\Nine.png");



        public Image ButtonOne = Image.FromFile(@".//Bilder\Buttons\One.jpg");
        public Image ButtonTwo = Image.FromFile(@".//Bilder\Buttons\Two.jpg");
        public Image ButtonThree = Image.FromFile(@".//Bilder\Buttons\Three.jpg");
        public Image ButtonFour = Image.FromFile(@".//Bilder\Buttons\Four.jpg");
        public Image ButtonFive = Image.FromFile(@".//Bilder\Buttons\Five.jpg");
        public Image ButtonSix = Image.FromFile(@".//Bilder\Buttons\Six.jpg");
        public Image Flag = Image.FromFile(@".//Bilder\Buttons\Flaggan.png");
        public Image BombImage = Image.FromFile(@".//Bilder\Buttons\LitenBomb.png");
        public Image UnpressedButton = Image.FromFile(@".//Bilder\Buttons\UnpressedButton.png");
        public Image OpenedBomb = Image.FromFile(@".//Bilder\Buttons\LitenSprängdBomb.png");
        public Image WrongPlacedFlag = Image.FromFile(@"C:.//Bilder\Buttons\WrongFlagged.png");
        public Image RegularSmiley = Image.FromFile(@".//Bilder\Buttons\VanligSmiley.png");
        public Image PressedRegularSmiley = Image.FromFile(@".//Bilder\Buttons\PressedVanligSmiley.png");
        public Image BlownSmiley = Image.FromFile(@".//Bilder\Buttons\SprängdBombSmiley.png");
        public Image WinningSmiley = Image.FromFile(@".//Bilder\Buttons\WinningSmiley.png");


    }
}
