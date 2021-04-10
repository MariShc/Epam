using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_3._3._1
{
    public static class SuperArray
    {
        public static void SomeAction<T>(this T[] mas, Func<T, T> action)
        {
            if (action != null)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = action(mas[i]);
                    Console.WriteLine(mas[i]);
                }
            }
        }
        public static void SumItems(this int[] array) => Console.WriteLine(array.Sum());

        public static void SumItems(this float[] array) => Console.WriteLine(array.Sum());

        public static void SumItems(this double[] array) => Console.WriteLine(array.Sum());

        public static void SumItems(this byte[] array)
        {
            byte sumItems = 0;

            foreach (byte item in array)
                sumItems += item;

            Console.WriteLine(sumItems);
        }

        public static void SumItems(this short[] array)
        {
            short sumItems = 0;

            foreach (short item in array)
                sumItems += item;

            Console.WriteLine(sumItems);
        }

        public static void Average(this int[] array) => Console.WriteLine(array.Sum() / array.Length);

        public static void Average(this float[] array) => Console.WriteLine(array.Sum() / array.Length);

        public static void Average(this double[] array) => Console.WriteLine(array.Sum() / array.Length);

        public static void Average(this byte[] array)
        {
            byte sumItems = 0;

            foreach (byte item in array)
                sumItems += item;

            byte average = (byte)(sumItems / array.Length);
            Console.WriteLine(average);
        }

        public static void Average(this short[] array)
        {
            short sumItems = 0;

            foreach (short item in array)
                sumItems += item;

            short average = (short)(sumItems / array.Length);
            Console.WriteLine(average);
        }

        public static void MostFrequent(this int[] array) => 
            Console.WriteLine(array.GroupBy(i => i).OrderByDescending(i => i.Count()).ToArray()[0].Key);

        public static void MostFrequent(this float[] array) =>
            Console.WriteLine(array.GroupBy(i => i).OrderByDescending(i => i.Count()).ToArray()[0].Key);

        public static void MostFrequent(this double[] array) =>
            Console.WriteLine(array.GroupBy(i => i).OrderByDescending(i => i.Count()).ToArray()[0].Key);

        public static void MostFrequent(this byte[] array) =>
            Console.WriteLine(array.GroupBy(i => i).OrderByDescending(i => i.Count()).ToArray()[0].Key);

        public static void MostFrequent(this short[] array) =>
            Console.WriteLine(array.GroupBy(i => i).OrderByDescending(i => i.Count()).ToArray()[0].Key);
    }
}
