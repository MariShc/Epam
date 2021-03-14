using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    public class Figure
    {

        public Point P { get; protected set; }

        public string Name { get; protected set; }

        protected Figure(Point p, string name)
        {
            P = p;
            Name = name;
        }
    }
}
