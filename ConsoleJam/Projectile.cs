using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJam
{
    class Projectile : Actor
    {
        bool friendly;
        public Projectile(int x, int y, bool friend) : base(x, y)
        {
            if (friend)
                appearence = 'I';
            else
                appearence = 'z';
            friendly = friend;
            Game.additions.Add(this);
        }

        //Updates called once per frame
        public override void Update()
        {
            //if the projectile is not hitting the boundry move up
            if (Y != 1 && friendly)
                Y--;
            else if (Y != 24 && !friendly)
                Y++;
            //if the projectile is hitting the boundry dissapate
            else
                Game.removals.Add(this);
        }
    }
}
