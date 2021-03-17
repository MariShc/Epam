using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    class GameField
    {
        public Player player;

        public Enemy enemy;

        public Bonus bonus;

        public Barrier barrier;


        public int Width { get; set; }

        public int Height { get; set; }
    }
}
