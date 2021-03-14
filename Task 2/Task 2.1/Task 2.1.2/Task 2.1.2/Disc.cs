using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_2._1._2
{
    class Disc : RoundShape
    {

       public Disc(Point p, int radius, string name) : base (p, radius, name)
        {
            Console.WriteLine("Фигура Круг создана!");
        }

        public double Circumference() => 2 * Math.PI * Radius;

        public double CircleArea() => Math.PI * Radius * Radius;
    }
}
