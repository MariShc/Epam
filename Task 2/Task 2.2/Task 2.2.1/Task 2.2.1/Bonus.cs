using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    class Bonus : UnmovableObject
    {
        public Bonus(BonusType type, Point p)
        {
            switch (type)
            {
                case BonusType.Jewel:
                    Name = BonusType.Jewel.ToString();
                    break;
                case BonusType.Coin:
                    Name = BonusType.Coin.ToString();
                    break;
                case BonusType.ExtraLife:
                    Name = BonusType.ExtraLife.ToString();
                    break;
                case BonusType.Cartridge:
                    Name = BonusType.Cartridge.ToString();
                    break;
            }
            P = p;
        }
    }
}
