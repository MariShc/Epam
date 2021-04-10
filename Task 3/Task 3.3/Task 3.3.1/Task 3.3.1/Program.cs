using System;

namespace Task_3._3._1
{
    class Program
    { 
        static void Main(string[] args)
        {
            int[] mas = new int[] { 2, 6, 7 };
            Console.WriteLine("Возведение каждого элемента массива в степень 2:");
            mas.SomeAction(Exp);
            Console.WriteLine("Умножение каждого элемента массива на 3:");
            mas.SomeAction(MultBy3);
            Console.WriteLine("Некоторая магическая сумма:");
            mas.SomeAction(SomeMagicSum);
            Console.WriteLine("Сумма элементов массива:");
            mas.SumItems();
            Console.WriteLine("Среднее значение в массиве:");
            mas.Average();
            int[] mas2 = new int[] { 1, 2, 2, 4, 2, 5, 4, 4, 5 };
            Console.WriteLine("Самый часто повторяемый элемент в массиве: [" + string.Join(",", mas2) + "]");
            mas2.MostFrequent();
        }

        public static int Exp(int elem) => (int)Math.Pow(elem, 2);

        public static float Exp(float elem) => (float)Math.Pow(elem, 2);

        public static double Exp(double elem) => (double)Math.Pow(elem, 2);

        public static byte Exp(byte elem) => (byte)Math.Pow(elem, 2);

        public static short Exp(short elem) => (short)Math.Pow(elem, 2);

        public static int MultBy3(int elem) => elem * 3;

        public static float MultBy3(float elem) => elem * 3;

        public static double MultBy3(double elem) => elem * 3;

        public static byte MultBy3(byte elem) => (byte)(elem * 3);

        public static short MultBy3(short elem) => (short)(elem * 3);

        public static int SomeMagicSum(int elem) => elem + 10000;

        public static float SomeMagicSum(float elem) => elem + 10000;

        public static double SomeMagicSum(double elem) => elem + 10000;

        public static byte SomeMagicSum(byte elem) => (byte)(elem + 10000);

        public static short SomeMagicSum(short elem) => (short)(elem + 10000);
    }
}
