using System;
using System.Collections.Generic;

namespace Task_3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextAnalysis();
        }

        public static String StringReadLine()
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine().ToLower();
            string new_str = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsLetterOrDigit(str[i]) && str[i] != ' ')
                {
                    new_str += "";
                }
                else
                    new_str += str[i];
            }
            return new_str;
        }
        public static void TextAnalysis()
        {   
            var arrString = StringReadLine().Split(' ');

            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var elem in arrString)
            {
                if (words.ContainsKey(elem))
                {
                    words[elem]++;
                }
                else
                    words.Add(elem, 1);
            }

            int maxValue = 1;
            string favoriteWord = "";
            Console.WriteLine("АНАЛИЗ ТЕКСТА: ");
            Console.WriteLine("Ниже приведен список слов Вашего текста и частота их употребления.");
            Console.WriteLine();
            foreach (KeyValuePair<string, int> keyValue in words)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                if (keyValue.Value > maxValue)
                    maxValue = keyValue.Value;
                if (words[keyValue.Key] == maxValue)
                    favoriteWord = keyValue.Key;
            }

            Console.WriteLine();
            Console.WriteLine("Итог. У Вас достаточно хороший текст! Но некоторые слова часто повторяются. А именно, чаще всего Вы употребляете слово: {0}", favoriteWord);
        }
    }
}
