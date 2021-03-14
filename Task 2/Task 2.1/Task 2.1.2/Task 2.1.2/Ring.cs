using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Ring : RoundShape
    {
        private int _innerRadius;
        protected int InnerRadius
        {
            get => _innerRadius;

            set
            {
                if (value < 0 || value >= Radius)
                {
                    do
                    {
                        if (value < 0)
                        {
                            Console.WriteLine("Внутренний радиус не может быть отрицательным!");
                            Console.Write("inner radius = ");
                        }
                        else if (value >= Radius)
                        {
                            Console.WriteLine("Внутренний радиус не может быть больше внешнего!");
                            Console.Write("inner radius = ");
                        }
                        else
                            Console.Write("inner radius = ");
                    } while (!(Int32.TryParse(Console.ReadLine(), out value)) || value < 0 || value >= Radius);
                    _innerRadius = value;
                }
                else
                {
                    _innerRadius = value;
                }
            }
        }
        public Ring(Point p, int radius, int innerRadius, string name) : base(p, radius, name)
        {
            InnerRadius = innerRadius;
            Console.WriteLine("Фигура Кольцо создана!");
        }
        public double RingArea() => Math.PI * (Radius * Radius - InnerRadius * InnerRadius);

        public double SumCircumference() => 2 * Math.PI * Radius + 2 * Math.PI * InnerRadius;
    }
}
