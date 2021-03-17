using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    abstract public class GameObject
    {
        public virtual Point P { get; protected set; }
        public virtual string Name { get; protected set; }
    }
}
