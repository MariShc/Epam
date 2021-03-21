using System;

namespace Task_2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatedField();
        }

        public static void CreatedField()
        {
            GameField g = new GameField(100, 100);
            g.AddPlayer("Padawan");
            Console.ReadKey();
            Console.Clear();
            foreach (Bonus bonus in g.bonuses)
                bonus.DrawObject();
            foreach (Barrier barrier in g.barriers)
                barrier.DrawObject();
            g.player.DrawPlayer(g.player.P.X, g.player.P.Y);
            g.player.HandleKey();
        }
    }
}
