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

        public override void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.RIGHT:
                    P = new Point { X = P.X + 1, Y = P.Y };
                    break;
                case Direction.LEFT:
                    P = new Point { X = P.X - 1, Y = P.Y };
                    break;
                case Direction.UP:
                    P = new Point { X = P.X, Y = P.Y - 1 };
                    break;
                case Direction.DOWN:
                    P = new Point { X = P.X, Y = P.Y + 1 };
                    break;
                default:
                    break;
            }
        }
    }
}
