using System;
using System.Collections.Generic;

namespace Task_1._1
{
    class Program
    {
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

        static void AnotherTriangle(int n)
        {
            for (int i = 0; i < n; i++)
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
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
            for (int i = 0; i < n; i++)
            {
                AnotherTriangle(i + 2);
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

        static void DividingLine()
        {
            Console.WriteLine("----------------------------------");
        }
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
            AnotherTriangle(n2);

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

            //Task 1.1.7
            Console.WriteLine("Task 1.1.7");
            Console.WriteLine();
        }
    }
}
