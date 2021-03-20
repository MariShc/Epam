﻿using System;
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

        public override void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.RIGHT:
                    P = new Point { X = P.X + 3, Y = P.Y };
                    break;
                case Direction.LEFT:
                    P = new Point { X = P.X - 3, Y = P.Y };
                    break;
                case Direction.UP:
                    P = new Point { X = P.X, Y = P.Y - 3 };
                    break;
                case Direction.DOWN:
                    P = new Point { X = P.X, Y = P.Y + 3 };
                    break;
                default:
                    break;
            }
        }
        public void DrawEnemy(int p_x, int p_y)
        {
            Console.SetCursorPosition(p_x, p_y);
            Console.WriteLine(Name);
        }
    }
}

