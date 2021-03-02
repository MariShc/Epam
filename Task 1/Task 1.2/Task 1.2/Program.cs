using System;
using System.Text;

namespace Прост
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

            //Task 1.2.3
            Console.WriteLine("Task 1.2.3");
            Console.WriteLine();
            LowerCase();

            DividingLine();
            Console.ReadKey();

            //Task 1.2.4
            Console.WriteLine("Task 1.2.4");
            Console.WriteLine();
            Validator();

            DividingLine();
            Console.ReadKey();
        }

        static void Averages()
        {
            Console.WriteLine("Введите строку:");
            string str1 = Console.ReadLine();
            char[] charsArray = str1.ToCharArray();
            StringBuilder str2 = new StringBuilder();
            for (int i = 0; i < charsArray.Length; i++)
            {
                if (!Char.IsLetterOrDigit(charsArray[i]))
                {
                    charsArray[i] = ' ';
                }
                str2.Append(charsArray[i]);
            }

            string[] wordsArray = str2.ToString().Split(' ');
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
            int average = 0;
            if (lengthWords != 0 || sumWords != 0)
                average = lengthWords / sumWords;
            Console.WriteLine();
            Console.WriteLine("Средняя длина слова во введённой текстовой строке: {0}.", average);
        }

        static void Doubler()
        {
            Console.Write("Введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string str2 = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            foreach (char symbol in str1)
            {
                if (str2.Contains(symbol))
                {
                    result.Append(symbol).Append(symbol);
                }
                else
                    result.Append(symbol);
            }
            Console.WriteLine();
            Console.WriteLine("Результат: {0}", result);
        }

        static void LowerCase()
        {

            Console.Write("(Вариант без *) Введите строку: ");
            string str1 = Console.ReadLine();
            string[] wordsArray1 = str1.Split(" ");
            int sumIsLowerWords1 = 0;
            foreach (string word in wordsArray1)
            {
                if (!word.Equals(""))
                {
                    if (Char.IsLower(word, 0))
                    {
                        sumIsLowerWords1++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество слов, начинающихся с маленькой буквы: {0}", sumIsLowerWords1);

            Console.WriteLine();
            Console.Write("(Вариант со *) Введите строку: ");
            string str2 = Console.ReadLine();
            string[] wordsArray2 = str2.Split(' ', ';', ',', ':');
            int sumIsLowerWords2 = 0;
            foreach (string word in wordsArray2)
            {
                if (!word.Equals(""))
                {
                    if (Char.IsLower(word, 0))
                    {
                        sumIsLowerWords2++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество слов, начинающихся с маленькой буквы: {0}", sumIsLowerWords2);
        }

        static void Validator()
        {
            char[] dividing = new char[3] { '.', '!', '?' };
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] wordsArray = str.Split(" ");
            string result = "";
            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (!wordsArray[i].Equals(""))
                {
                    if (i == 0)
                    {
                        wordsArray[i] = Char.ToUpper(wordsArray[0][0]) + ""
                            + wordsArray[0].Substring(1, wordsArray[0].Length - 1);
                    }
                    for (int j = 0; j < dividing.Length; j++)
                    {
                        if (wordsArray[i][wordsArray[i].Length - 1].Equals(dividing[j]))
                        {
                            if (i + 1 < wordsArray.Length)
                            {
                                wordsArray[i + 1] = Char.ToUpper(wordsArray[i + 1][0]) + ""
                                    + wordsArray[i + 1].Substring(1, wordsArray[i + 1].Length - 1);
                            }
                        }
                    }
                    if (i != 0)
                    {
                        result += " ";
                    }
                    result += wordsArray[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine(result);
        }

        static void DividingLine()
        {
            Console.WriteLine("----------------------------------");
        }
    }
}

