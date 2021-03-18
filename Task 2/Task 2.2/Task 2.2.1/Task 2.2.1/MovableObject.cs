using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    abstract public class MovableObject : GameObject
    {
        public Direction direction;
        abstract public void Move(Direction dir);

    }
}
