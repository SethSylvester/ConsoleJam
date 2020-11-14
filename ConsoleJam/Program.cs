using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJam
{
    class Program
    {
        public static bool running = true;
        static void Main(string[] args)
        {
            double totalTime = 0;

            Game game = new Game();
            Screen scn = new Screen(1);
            game.Start();

            while (running)
            {
                totalTime += Time.DeltaTime;

                //5~ fps
                if (totalTime > 200)
                {
                    game.Update();
                    totalTime = 0;
                }
            }
        }

    }
}
