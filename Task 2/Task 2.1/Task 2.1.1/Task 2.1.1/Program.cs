using System;

namespace Хрень
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = "Привет".ToCharArray();
            MyOwnString str = new MyOwnString(a);

            MyOwnString str1 = new MyOwnString(ReadLine(1));
            MyOwnString str2 = new MyOwnString(ReadLine(2));

            Console.WriteLine("Сравнение строк 1 и 2: {0}", str1.MyEquals(str2));
            Console.WriteLine($"Длина строки 1 равна {str1.MyLength()}");

            str1.MyConcat2(ReadLine(3), ReadLine(4));
            Console.WriteLine(str1.ToCharArray());

            Console.WriteLine($"В строке 1 есть символ 'м': { str1.MyContains('м')}");
            Console.WriteLine(str1.MyIndexOf('а'));
        }

        private static char[] ReadLine(int numberLine)
        {
            Console.WriteLine("Введите строку {0}:", numberLine);
            return Console.ReadLine().ToCharArray();
        }
    }
}
