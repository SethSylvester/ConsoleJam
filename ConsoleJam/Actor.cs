using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJam
{
    class Actor
    {
        //Coordinates for the grid
        private int xCord;
        private int yCord;

        //The look of the actor
        protected char appearence = ' ';

        public Actor(int x, int y)
        {
            xCord = x;
            yCord = y;
        }

        //Virtual functions
        public virtual void Update() { }
        public char GetAppearence() { return appearence; }

        //Set Appearence
        public void SetAppearence(char look) { appearence = look; }

        //X and Y constructors.
        public int X
        {
            get { return xCord; }
            set { xCord = value; }
        }
        public int Y
        {
            get { return yCord; }
            set { yCord = value; }
        }

    }
}
