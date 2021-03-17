using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    class Barrier : UnmovableObject
    {
        public Barrier(BarrierType type, Point p)
        {
            switch (type)
            {
                case BarrierType.Stone:
                    Name = BarrierType.Stone.ToString();
                    break;
                case BarrierType.Ravine:
                    Name = BarrierType.Ravine.ToString();
                    break;
                case BarrierType.Tree:
                    Name = BarrierType.Tree.ToString();
                    break;
                case BarrierType.Fence:
                    Name = BarrierType.Fence.ToString();
                    break;
            }
            P = p;
        }
    }
}
