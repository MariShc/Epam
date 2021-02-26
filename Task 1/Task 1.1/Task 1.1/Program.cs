using System;
using System.Collections.Generic;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1.1.1
            Console.WriteLine("Task 1.1.1");
            Console.WriteLine();
            int a = InputValue("a");
            int b = InputValue("b");
            RectSquare(a, b);

            DividingLine();

            //Task 1.1.2
            Console.WriteLine("Task 1.1.2");
            Console.WriteLine();
            int n1 = InputValue("N");
            Triangle(n1);

            DividingLine();

            //Task 1.1.3
            Console.WriteLine("Task 1.1.3");
            Console.WriteLine();
            int n2 = InputValue("N");
            AnotherTriangle(n2, n2);

            DividingLine();

            //Task 1.1.4
            Console.WriteLine("Task 1.1.4");
            Console.WriteLine();
            int n3 = InputValue("N");
            XmasTree(n3);

            DividingLine();
            Console.ReadKey();

            //Task 1.1.5
            Console.WriteLine("Task 1.1.5");
            Console.WriteLine();
            SumNumbers();

            DividingLine();
            Console.ReadKey();

            //Task 1.1.6
            Console.WriteLine("Task 1.1.6");
            Console.WriteLine();
            FontAdjustment();

            DividingLine();
            Console.ReadKey();

            //Task 1.1.7
            Console.WriteLine("Task 1.1.7");
            Console.WriteLine();
            ArrayProcessing();

            DividingLine();
            Console.ReadKey();

            //Task 1.1.8
            Console.WriteLine("Task 1.1.8");
            Console.WriteLine();
            NoPositive();

            DividingLine();
            Console.ReadKey();

            //Task 1.1.9
            Console.WriteLine("Task 1.1.9");
            Console.WriteLine();
            NonNegativeSum();

            DividingLine();
            Console.ReadKey();

            //Task 1.1.10
            Console.WriteLine("Task 1.1.10");
            Console.WriteLine();
            Array2D();

            DividingLine();
            Console.ReadKey();
        }

        static void RectSquare(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                int sqr = a * b;
                Console.WriteLine("a = {0}, b = {1}", a, b);
                Console.WriteLine("Площадь прямоугольника равна {0}.", sqr);
            }
            else Console.WriteLine("Введено некорректное значение!");
        }

        static int InputValue(string s) 
        {
            int valueS;
            do
            {
                Console.Write("Введите {0}: ", s);
            } while (!Int32.TryParse(Console.ReadLine(), out valueS));
            return valueS;

        }

        static void Triangle(int n)
        {
            string s = "";
            for(int i = 0; i < n; i++)
            {
                s += '*';
                Console.WriteLine(s);
            }
        }

        static void AnotherTriangle(int n, int countTriangle)
        {
            for (int i = 0; i < countTriangle; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = n - i - 1; k < n - i + i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
               
        
        static void XmasTree(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                AnotherTriangle(n, i);
            }
        }

        static void SumNumbers()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            Console.WriteLine("Cумма чисел меньше 1000, кратных 3 или 5 равна: {0}.", sum);
        }

        static void FontAdjustment()
        {
            List<string> fonts = new List<string>();

            int n;
            do
            {
                Console.WriteLine("Введите: ");
                Console.WriteLine("\t" + "1: bold");
                Console.WriteLine("\t" + "2: italic");
                Console.WriteLine("\t" + "3: underline");
                if (!Int32.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Вы ввели не цифру!");
                }
                switch (n)
                {
                    case 1:
                        if (!fonts.Contains("Bold"))
                        {
                            fonts.Add("Bold");
                        }
                        else
                        {
                            fonts.Remove("Bold");
                        }
                        Console.WriteLine("Параметры надписи: " + string.Join(", ", fonts));
                        break;
                    case 2:
                        if (!fonts.Contains("Italic"))
                        {
                            fonts.Add("Italic");
                        }
                        else
                        {
                            fonts.Remove("Italic");
                        }
                        Console.WriteLine("Параметры надписи: " + string.Join(", ", fonts));
                        break;
                    case 3:
                        if (!fonts.Contains("Underline"))
                        {
                            fonts.Add("Underline");
                        }
                        else
                        {
                            fonts.Remove("Underline");
                        }
                        Console.WriteLine("Параметры надписи: " + string.Join(", ", fonts));
                        break;
                }
            }
            while (n < 4);
        }

        static void ArrayProcessing()
        {
            int[] array = new int[10];
            Random nums = new Random();
            Console.WriteLine("Рандомный массив:");
            for (int i = 0; i < array.Length; i++)
                array[i] = nums.Next(0, 50);
            Console.WriteLine("[" + string.Join(", ", array) + "]");
            Console.WriteLine();

            int max = array[0], min = array[0];
            foreach (int elem in array)
            {
                if (max < elem)
                    max = elem;
                if (min > elem)
                    min = elem;
            }
            Console.WriteLine("Максимальный элемент массива: {0}", max);
            Console.WriteLine("Минимальный элемент массива: {0}", min);
            Console.WriteLine();

            //Сортировка пузырьком
            int tmp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = array.Length - 1; k > i; k--)
                {
                    if (array[k - 1] > array[k])
                    {
                        tmp= array[k - 1];
                        array[k - 1] = array[k];
                        array[k] = tmp;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        static void NoPositive()
        {
            int[,,] arr = new int[2, 2, 2];
            int x = -3;

            //Заполнение массива
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = x++;
                    }
                }
            }

            //Замена всех положительных элементов на нули и вывод массива
            Console.WriteLine("Массив с замененными положительными элементами на нули:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0)
                            arr[i, j, k] = 0;
                        Console.WriteLine(arr[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void NonNegativeSum()
        {
            int[] array = new int[9] {-1, 0, 9, -5, 6, 11, -8, -2, 4};
            Console.WriteLine("Массив:");
            Console.WriteLine("[" + string.Join(", ", array) + "]");
            int nonNegativeSum = 0;
            foreach (int elem in array)
            {
                if (elem > 0)
                    nonNegativeSum += elem;
            }
            Console.WriteLine("Сумма неотрицательных элементов массива равна: {0}.", nonNegativeSum);
        }

        static void Array2D()
        {
            int[,] array = new int[3, 3];
            int x = 0;
            int sum = 0;
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = x++;
                    Console.WriteLine(array[i, j]);
                    if ((i + j) % 2 == 0)
                        sum += array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Cумма элементов массива, стоящих на чётных позициях: {0}", sum);
        }

        static void DividingLine()
        {
            Console.WriteLine("----------------------------------");
        }
    }
}
