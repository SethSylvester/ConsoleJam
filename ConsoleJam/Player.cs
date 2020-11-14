using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJam
{
    class Player : Actor
    {
        public int score = 0;
        public Player(int x, int y) : base (x, y)
        {
            appearence = '^';
            Game.additions.Add(this);
        }

        public Player() : this(1, 1) { }

        //Update is called once per frame
        public override void Update()
        {
            //Flush the input buffer
            ConsoleKeyInfo input = new ConsoleKeyInfo();

            //If an input is avalible, collect it
            if (Console.KeyAvailable)
                input = Console.ReadKey(true);

            //Movement
            if (input.KeyChar == 'a' && X > 1)
                X--;
            if (input.KeyChar == 'd' && X < 18)
                X++;

            //Fire
            if (input.Key == ConsoleKey.Spacebar)
                Fire();

            //Exit
            if (input.Key == ConsoleKey.Escape)
                Program.running = false;
        }

        //The shoot function
        private void Fire()
        {
            Projectile projectile = new Projectile(X, Y - 1, true);
        }
    }
}
