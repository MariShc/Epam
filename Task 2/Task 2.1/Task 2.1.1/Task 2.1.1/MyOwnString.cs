using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._1
{
    class MyOwnString
    {

        private char[] myString { get; set; }

        public MyOwnString()
        {
            myString = null;
        }

        public MyOwnString(char[] charArray)
        {
            myString = new char[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                myString[i] = charArray[i];
            }
        }

        public bool MyEquals(MyOwnString arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.myString.Length; i++)
            {
                if (myString.Length == arr.myString.Length)
                {
                    if (arr.myString[i] == myString[i])
                        counter++;
                }
            }
            return (counter == myString.Length);
        }

        public int MyLength()
        {
            return this.myString.Length;
        }

        public char[] ToCharArray()
        {
            return myString;
        }

        public MyOwnString FromCharArray(char[] array)
        {
            myString = array;

            return this;
        }

        public MyOwnString MyConcat(char[] array)
        {
            char[] newArray = new char[myString.Length + array.Length];
            for (int i = 0; i < myString.Length; i++)
            {
                newArray[i] = myString[i];
            }
            int k = 0;
            for (int j = myString.Length; j < myString.Length + array.Length; j++)
            {
                if (k < array.Length)
                {
                    newArray[j] = array[k];
                    k++;
                }
            }
            myString = newArray;
            return this;
        }

        public int MyIndexOf(char c)
        {
            for (int i = 0; i < myString.Length; i++)
            {
                if (myString[i] == c)
                    return i;
            }
            return -1;
        }

        public bool MyContains(char c) => MyIndexOf(c) >= 0;

        //Конкатенация двух строк в третью
        public MyOwnString MyConcat2(char[] array1, char[] array2)
        {
            myString = MyConcat(array1).MyConcat(array2).myString;
            return this;
        }
    }
}
