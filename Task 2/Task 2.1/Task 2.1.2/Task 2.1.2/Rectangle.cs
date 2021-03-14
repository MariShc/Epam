using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Rectangle : Figure
    {
        public Point P1 { get; protected set; }
        public Point P2 { get; protected set; }
        public Point P3 { get; protected set; }

        public Rectangle(Point p, Point p1, string name) : base(p, name)
        {
            P1 = p1;
            P2 = new Point { X = P1.X, Y = P.Y };
            P3 = new Point { X = P.X, Y = P1.Y };
            Console.WriteLine("Фигура Прямоугольник создана!");
        }

        public int SideA() => Math.Abs(P1.X - P.X);

        public int SideB() => Math.Abs(P1.Y - P.Y);

        public int RectArea() => SideA() * SideB();

        public int RectPerimeter() => 2 * (SideA() + SideB());
    }
}
