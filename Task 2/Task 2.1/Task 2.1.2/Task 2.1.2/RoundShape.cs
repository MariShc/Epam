using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class RoundShape : Figure
    {
        private int _radius;

        protected int Radius
        {
            get => _radius;

            set
            {
                if (value < 0)
                {
                    do
                    {
                        if (value < 0)
                        {
                            Console.WriteLine("Радиус не может быть отрицательным!");
                            Console.Write("radius = ");
                        }
                        else
                            Console.Write("radius = ");
                    } while (!(Int32.TryParse(Console.ReadLine(), out value)) || value < 0);
                    _radius = value;
                }
                else
                {
                    _radius = value;
                }
            }
        }

        protected RoundShape(Point p, int radius, string name) : base (p, name)
        {
            Radius = radius;
        }
    }
}
