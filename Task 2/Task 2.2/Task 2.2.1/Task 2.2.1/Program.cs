using System;

namespace Task_2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameField g = new GameField(100, 100);
            g.AddPlayer("Padawan");
            Console.ReadKey();
            Console.Clear();
            g.player.DrawPlayer(g.player.P.X, g.player.P.Y);
            g.player.HandleKey();
        }
    }
}
