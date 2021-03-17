using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    public class Player : MovableObject
    {
        public Player(string name, Point p)
        {
            Name = name;
            P = p;
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
