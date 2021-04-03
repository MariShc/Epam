using System;
using System.Collections.Generic;

namespace Task_3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckAddAndAddRange();
            CheckRemoveAndInsert();
            CheckMetodsIEnumerableIenumerator();
            CheckIndexator();
        }

        static void CheckAddAndAddRange()
        {
            List<string> myList = new List<string> { "ff", "hhh", "fgg", "hhh", "fgg", "d", "ff", "j" };
            DynamicArray<string> arrayString = new DynamicArray<string>(myList);
            DynamicArray<string> dynamicArray = new DynamicArray<string>();
            dynamicArray.Add("Maria");
            dynamicArray.Add("Oksana");
            dynamicArray.Add("Maksim");
            dynamicArray.Add("Svetlana");
            dynamicArray.Add("Tatyana");
            dynamicArray.Add("Igor");
            dynamicArray.Add("Ekaterina");
            dynamicArray.Add("Dmitrii");
            dynamicArray.Add("Olga");
            dynamicArray.Add("Inna");
            Console.WriteLine("Проверка методов Add и AddRange, а также свойств Capacity и Length:");
            Console.WriteLine(dynamicArray.Length);
            Console.WriteLine(dynamicArray.Capacity);
            Console.WriteLine(arrayString.Length);
            Console.WriteLine(arrayString.Capacity);
            dynamicArray.AddRange(myList);
            Console.WriteLine("Capacity нового массива: " + dynamicArray.Capacity);
            Console.WriteLine("Length нового массива: " + dynamicArray.Length);
            Console.WriteLine();
        }

        static void CheckRemoveAndInsert()
        {
            DynamicArray<int> dynamicArray = new DynamicArray<int>();
            dynamicArray.Add(9);
            dynamicArray.Add(45);
            dynamicArray.Add(0);

            dynamicArray.Add(0);
            dynamicArray.Add(0);
            dynamicArray.Add(0);
            dynamicArray.Add(0);
            dynamicArray.Add(0);

            Console.WriteLine("Проверка методов Remove и Insert:");
            Console.WriteLine("До удаления элемента, Length: " + dynamicArray.Length);
            Console.WriteLine("До удаления эелемента, Capacity: " + dynamicArray.Capacity);
            dynamicArray.Remove(45);
            Console.WriteLine("После удаления элемента, Length: " + dynamicArray.Length);
            Console.WriteLine("После удаления эелемента, Capacity: " + dynamicArray.Capacity);
            dynamicArray.Insert(1, 999);
            Console.WriteLine("После вставки элемента, Length: " + dynamicArray.Length);
            Console.WriteLine("После вставки эелемента, Capacity: " + dynamicArray.Capacity);
            Console.WriteLine();
        }

        static void CheckMetodsIEnumerableIenumerator()
        {
            Console.WriteLine("Проверка методов, реализующих интерфейсы IEnumerable и IEnumerator:");
            DynamicArray<int> dynamicArray = new DynamicArray<int>();
            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            foreach (int item in dynamicArray)
                Console.WriteLine(item);
            Console.WriteLine();
        }
        static void CheckIndexator()
        {
            Console.WriteLine("Проверка работы индексатора:");
            DynamicArray<string> dynamicArray = new DynamicArray<string>();
            dynamicArray.Add("kkk");
            dynamicArray.Add("hhh");
            dynamicArray.Add("ppp");
            for (int i = 0; i < dynamicArray.Length; i++)
                Console.WriteLine(dynamicArray[i]);
        }
    }
}
