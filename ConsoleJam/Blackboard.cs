using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJam
{
    class Blackboard
    {
        int timerDefault = 3;
        int timer = 0;
        int linesYValue = 1;
        //The left and right of each enemy line.
        Actor leftEdge;
        Actor rightEdge;
        Random rand = new Random();

        //Whether or not to move right
        bool moveRight = true;

        //Start func
        public void Start()
        { CalculateEdges(); }

        //Update once every frame
        public void Update()
        {
           CalculateEdges();

            //dont move them if the left or right is null
            if (leftEdge == null || rightEdge == null)
                return;

            
            if (timer >= timerDefault)
            {
                EnemyMovement();

                Projectile proj = new Projectile(rand.Next(leftEdge.X, rightEdge.X), linesYValue + 2, false);
                timer = 0;
            }
            timer++;
        }

        //movement function
        private void EnemyMovement()
        {
            if (moveRight)
            {
                if (rightEdge.X < 18)
                {
                    foreach (Actor e in Game.entities)
                        if (e is Enemy)
                        e.X++;
                }
                else
                    moveRight = false;
            }
            else
            {
                if (leftEdge.X > 1)
                {
                    foreach (Actor e in Game.entities)
                        if (e is Enemy)
                        e.X--;
                }
                else
                {
                    moveRight = true;
                    foreach (Actor e in Game.entities)
                        if (e is Enemy && e.Y != 24)
                            e.Y++;
                    linesYValue++;
                }
            }

        }

        //Calculate the left and rightmost enemy
        private void CalculateEdges()
        {
            foreach (Actor e in Game.entities)
            {
                if (e is Enemy)
                {
                    if (leftEdge == null)
                        leftEdge = e;
                    if (e.X < leftEdge.X)
                        leftEdge = e;
                    if (rightEdge == null)
                        rightEdge = e;
                    if (e.X > rightEdge.X)
                        rightEdge = e;
                }
            }
        }
    }
}
