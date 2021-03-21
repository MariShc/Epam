using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    abstract public class UnmovableObject : GameObject
    {
        public virtual void DrawObject()
        {
            Console.SetCursorPosition(P.X, P.Y);
            Console.WriteLine(Name);
        }
    }
}
