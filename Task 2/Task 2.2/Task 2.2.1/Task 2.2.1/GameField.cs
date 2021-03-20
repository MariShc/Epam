using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._1
{

    class GameField
    {
        public Player player;

        List<Enemy> enemys;

        List<Bonus> bonuses;

        List<Barrier> barriers;

        public int Width { get; set; }

        public int Height { get; set; }


        public GameField(int width, int height)
        {
            Width = width;
            Height = height;
            AddEnemy();
            AddBonus();
            AddBarrier();
        }

        public Point PointRandom()
        {
            Random rnd = new Random();
            int p1 = rnd.Next(0, 100);
            int p2 = rnd.Next(0, 100);
            return new Point { X = p1, Y = p2 };

        }

        public void AddPlayer(string name)
        {
            player = new Player(name, PointRandom());
            Console.WriteLine($"Игрок {player.Name} создан!");
        }

        public void AddEnemy()
        {
            Random rnd = new Random();
            enemys = new List<Enemy>();
            int index;
            for (int i = 0; i <= 4; i++)
            {
                index = rnd.Next(1, 6);
                enemys.Add(new Enemy((EnemyType)index, PointRandom()));
                Console.WriteLine($"Враг {enemys[i].Name} добавлен на поле!");
            }
        }

        public void AddBonus()
        {
            Random rnd = new Random();
            bonuses = new List<Bonus>();
            int index;
            for (int i = 0; i <= 3; i++)
            {
                index = rnd.Next(1, 5);
                bonuses.Add(new Bonus((BonusType)index, PointRandom()));
                Console.WriteLine($"Бонус {bonuses[i].Name} добавлен на поле!");
            }
        }

        public void AddBarrier()
        {
            Random rnd = new Random();
            barriers = new List<Barrier>();
            int index;
            for (int i = 0; i <= 3; i++)
            {
                index = rnd.Next(1, 5);
                barriers.Add(new Barrier((BarrierType)index, PointRandom()));
                Console.WriteLine($"Барьер {barriers[i].Name} добавлен на поле!");
            }
        }
    }
}

