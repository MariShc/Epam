using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Line : Figure
    {
        public Point P1 { get; protected set; }

        public Line(Point p, Point p1, string name) : base(p, name)
        {
            P1 = p1;
            Console.WriteLine("Фигура Линия создана!");
        }

        public double LengthLine() => Math.Sqrt((P1.X - P.X) * (P1.X - P.X) + (P1.Y - P.Y) * (P1.Y - P.Y));
    }
}
