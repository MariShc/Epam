using System;
using System.Collections.Generic;

namespace Task_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleOfPeople();
        }

        static int InputValue(string s)
        {
            int valueS;
            do
            {
                Console.WriteLine("Введите {0}: ", s);
            } while (!Int32.TryParse(Console.ReadLine(), out valueS));
            return valueS;

        }

        static void CircleOfPeople()
        {
            int n = N_People();
            Console.WriteLine("Сгенерирован круг людей. Начинаем вычеркивать каждого второго.");

            Queue<int> countPeople = new Queue<int>();
            for (int i = 1; i <= n; i++)
            {
                countPeople.Enqueue(i);
            }
            int countRound = 1;
            while (countPeople.Count != 1)
            {
                countPeople.Enqueue(countPeople.Dequeue());
                countPeople.Dequeue();
                Console.WriteLine($"Раунд {countRound}. Вычеркнут человек. Людей осталось: {countPeople.Count}");
                countRound++;
            }
            if (countPeople.Count == 1)
                Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");

        }

        static int N_People()
        {
            int n  = InputValue("N"); ;
            while (n < 2)
            {
                Console.WriteLine("Нужно ввести N больше 2, т. к. вычеркивается каждый 2-ой!");
                n = InputValue("N");
            }
            return n;
        }
    }
}
