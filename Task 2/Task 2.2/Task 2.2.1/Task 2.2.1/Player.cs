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
                    Console.Clear();
                    DrawPlayer(P.X, P.Y);
                    break;
                case Direction.LEFT:
                    P = new Point { X = P.X - 1, Y = P.Y };
                    Console.Clear();
                    DrawPlayer(P.X, P.Y);
                    break;
                case Direction.UP:
                    P = new Point { X = P.X, Y = P.Y - 1 };
                    Console.Clear();
                    DrawPlayer(P.X, P.Y);
                    break;
                case Direction.DOWN:
                    P = new Point { X = P.X, Y = P.Y + 1 };
                    Console.Clear();
                    DrawPlayer(P.X, P.Y);
                    break;
                default:
                    break;
            }
        }

        public void HandleKey()
        {
            do
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        Move(Direction.LEFT);
                        Console.WriteLine("LEFT");
                        break;
                    case ConsoleKey.RightArrow:
                        Move(Direction.RIGHT);
                        Console.WriteLine("RIGHT");
                        break;
                    case ConsoleKey.DownArrow:
                        Move(Direction.DOWN);
                        Console.WriteLine("DOWN");
                        break;
                    case ConsoleKey.UpArrow:
                        Move(Direction.UP);
                        Console.WriteLine("UP");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("ESCAPE");
                        return;
                    default: break;
                }
            }
            while (true);
        }

        public void DrawPlayer(int p_x, int p_y)
        {
            Console.SetCursorPosition(p_x, p_y);
            Console.WriteLine("Ваш игрок " + Name);
        }
    }
}
