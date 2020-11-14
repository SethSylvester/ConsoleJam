using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJam
{
    //The grid the game is based off
    public struct Grid
    {
        public Char[,] grid;
        public Grid(int x, int y)
        {
            grid = new char[x, y];
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Game
    {
        //Lists for handling entities
        public static List<Actor> entities = new List<Actor>();
        public static List<Actor> additions = new List<Actor>();
        public static List<Actor> removals = new List<Actor>();
        private List<Actor> projectiles = new List<Actor>();
        //The grid
        private Grid _grid = new Grid(20, 25);
        //The player
        private Player _player;
        private bool _victory = false;
        //The blackboard to control enemy AI
        Blackboard _blackboard = new Blackboard();

        //Start func is called first
        public void Start()
        {
            //Make the player
            _player = new Player(_grid.X / 2, _grid.Y -1);

            //Create barrier walls
            for (int i = 0; i < _grid.Y; i++)
            {
                Actor wall = new Actor(0, i);
                wall.SetAppearence('|');
                Actor wall2 = new Actor(_grid.X - 1, i);
                wall2.SetAppearence('|');

                //Add the walls
                additions.Add(wall);
                additions.Add(wall2);
            }

            //Spawn Enemies
            for (int i = 3; i < _grid.X - 1; i++)
            {
                Enemy e = new Enemy(i, 1);
            }

            //Start the blackboard up
            _blackboard.Start();
        }

        //Update is called once per frame
        public void Update()
        {
            //Set victory to true
            _victory = true;

            //Add things in additions
            foreach (Actor a in additions)
            {
                entities.Add(a);
                if (a is Projectile)
                    projectiles.Add(a);
            }

            //Remove things from additions
            foreach (Actor a in removals)
            {
                entities.Remove(a);
                if (a is Projectile)
                    projectiles.Remove(a);

            }

            //Clear additions/removals
            additions.Clear();
            removals.Clear();

            //Update the entities
            foreach (Actor a in entities)
            {
                a.Update();
                if (a is Enemy)
                    _victory = false;
            }

            //Update the blackboard
            _blackboard.Update();

            foreach (Actor a in entities)
            {
                //Replace this with a lives system later
                if (a.X == _player.X && a.Y == _player.Y && a != _player)
                {
                    Console.Clear();
                    Screen scn = new Screen(2);
                }

                //Enemy collision
                foreach (Projectile p in projectiles)
                {
                    if (a.X == p.X && a.Y == p.Y && a != p && a is Enemy)
                    {
                        removals.Add(a);
                        removals.Add(p);
                        _player.score++;
                    }
                }
            }

            //Draw
            Draw();

            if (_victory)
            {
                Console.Clear();
                Screen scn = new Screen(1);
            }
        }

        //Draw the actors to the screen
        public void Draw()
        {
            ClearGrid();
            Console.Clear();

            //Draw actors
            foreach (Actor a in entities)
            {
                _grid.grid[a.X, a.Y] = a.GetAppearence();
            }

            for (int y = 0; y < _grid.Y; y++)
            {
                for (int x = 0; x < _grid.X; x++)
                {
                    Console.Write(_grid.grid[x, y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Score: " + _player.score);
        }

        //Clears the screen
        private void ClearGrid()
        {
            for (int y = 0; y < _grid.Y; y++)
            {
                for (int x = 0; x < _grid.X; x++)
                {
                    _grid.grid[x, y] = ' ';
                }
            }
        }

    }

}