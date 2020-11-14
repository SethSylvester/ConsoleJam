using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJam
{
    class Enemy : Actor
    {
        public Enemy(int x, int y) : base(x, y)
        {
            appearence = 'x';
            Game.additions.Add(this);
        }

    }
}
