﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Square : Figure
    {   
        public Point P1 { get; protected set; }
        public Point P2 { get; protected set; }
        public Point P3 { get; protected set; }

        public Square(Point p, Point p1, string name) : base(p, name)
        {
            P1 = p1;
            P2 = new Point { X = P1.X, Y = P.Y };
            P3 = new Point { X = P.X, Y = P1.Y };
            Console.WriteLine("Фигура Квадрат создана!");
        }

        public int SideA() => Math.Abs(P1.X - P.X);

        public int SquareArea() => SideA() * SideA();

        public int SquarePerimeter() => 2 * (SideA() + SideA());
    }
}
