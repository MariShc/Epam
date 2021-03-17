using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{
    public class Enemy : MovableObject
    {

        public Enemy(EnemyType type, Point p)
        {
            switch (type)
            {
                case EnemyType.Dragon:
                    Name = EnemyType.Dragon.ToString();
                    break;
                case EnemyType.Zombie:
                    Name = EnemyType.Zombie.ToString();
                    break;
                case EnemyType.Ghost:
                    Name = EnemyType.Ghost.ToString();
                    break;
                case EnemyType.Vampire:
                    Name = EnemyType.Vampire.ToString();
                    break;
                case EnemyType.Werewolf:
                    Name = EnemyType.Werewolf.ToString();
                    break;
            }
            P = p;
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}

