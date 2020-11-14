using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJam
{
    static class Time
    {
        //Delta Time
        private static long _previousTime = 0;
        private static double CalculateDeltaTime()
        {
            long now = DateTime.Now.Millisecond;
            double deltaTime = (now - _previousTime);
            _previousTime = now;
            //Make it absolute to prevent weird return negative value situations
            return System.Math.Abs(deltaTime);
        }

        //Property for deltaTime
        public static double DeltaTime
        { get { return CalculateDeltaTime(); } }

    }
}
