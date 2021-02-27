using System;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1.2.1
            Console.WriteLine("Task 1.2.1");
            Console.WriteLine();
            Averages();

            DividingLine();
            Console.ReadKey();

            //Task 1.2.2
            Console.WriteLine("Task 1.2.2");
            Console.WriteLine();
            Doubler();

            DividingLine();
            Console.ReadKey();
        }

        static void Averages()
        {
            Console.WriteLine("Введите строку:");
            string str1 = Console.ReadLine();
            char[] charsArray = str1.ToCharArray();
            string str2 = "";
            for (int i = 0; i < charsArray.Length; i++)
            {
                if (!Char.IsLetterOrDigit(charsArray[i]))
                {
                    charsArray[i] = ' ';
                }
                str2 += charsArray[i];
            }

            string[] wordsArray = str2.Split(" ");
            int sumWords = 0;
            int lengthWords = 0;
            foreach (string word in wordsArray)
            {
                if (!(word == ""))
                {
                    sumWords++;
                    lengthWords += word.Length;
                }
            }

            //результат округляется до целого в меньшую сторону
            int average = lengthWords / sumWords;
            Console.WriteLine();
            Console.WriteLine("Средняя длина слова во введённой текстовой строке: {0}.", average);
        }

        static void Doubler()
        {
            Console.Write("Введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string str2 = Console.ReadLine();
            string result = "";
            foreach (char symbol in str1)
            {
                if (str2.Contains(symbol))
                {
                    result += symbol;
                    result += symbol;
                }
                else
                    result += symbol;
            }
            Console.WriteLine();
            Console.WriteLine("Результат: " + result);
        }

        static void DividingLine()
        {
            Console.WriteLine("----------------------------------");
        }
    }
}
