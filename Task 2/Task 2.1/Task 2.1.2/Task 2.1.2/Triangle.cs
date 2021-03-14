using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Triangle : Figure
    {
        public Point P1 { get; protected set; }
        public Point P2 { get; protected set; }

        public Triangle(Point p, Point p1, Point p2, string name) : base(p, name)
        {
            P1 = p1;
            P2 = p2;
            Console.WriteLine("Фигура Треугольник создана!");
        }

        public double SideA() => Math.Sqrt((P1.X - P.X) * (P1.X - P.X) + (P1.Y - P.Y) * (P1.Y - P.Y));

        public double SideB() => Math.Sqrt((P2.X - P1.X) * (P2.X - P1.X) + (P2.Y - P1.Y) * (P2.Y - P1.Y));

        public double SideC() => Math.Sqrt((P2.X - P.X) * (P2.X - P.X) + (P2.Y - P.Y) * (P2.Y - P.Y));

        public double TriangleP() => SideA() + SideB() + SideC();

        public double TriangleArea() => Math.Sqrt(TriangleP() * (TriangleP() - SideA()) 
            * (TriangleP() - SideC()) * (TriangleP() - SideB()));
    }
}
