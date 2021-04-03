using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_3._2._1
{
    class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        private const int defaultCapacity = 8;
        private T[] MyArray { get; set; }

        private int length;

        private int capacity;
        public int Length
        {
            get => length;
        }

        public int Capacity
        {
            get => capacity;

            set
            {
                if (value < Length)
                {
                    throw new ArgumentOutOfRangeException("value", value, "ArgumentOutOfRange_SmallCapacity");
                }
                T[] arrayNew = new T[value];
                if (length > 0)
                {
                    Array.Copy(MyArray, 0, arrayNew, 0, length);
                }
                MyArray = arrayNew;
                capacity = value;


            }
        }

        public DynamicArray()
        {
            Capacity = defaultCapacity;
            MyArray = new T[Capacity];
        }

        public DynamicArray(int _capacity)
        {
            if (_capacity < 0)
                throw new ArgumentOutOfRangeException("capacity", _capacity, "ArgumentOutOfRange_NeedNonNegNum");
            else
            {
                Capacity = _capacity;
                MyArray = new T[Capacity];
            }
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            else
                MyArray = collection.ToArray();

            length = collection.ToArray().Length;
            Capacity = length * 2;
        }

        public void Add(T item)
        {
            if (length == Capacity) Capacity *= 2;
            MyArray[length++] = item;
        }

        public void AddRange (IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            int countCollection = collection.Count();
            while (Capacity < length + countCollection) Capacity *= 2;
            length = length + countCollection;
            Array.Copy(collection.ToArray(), 0, MyArray, length, countCollection);
        }

        public void RemoveAt(int index)
        {
            if (index >= length)
            {
                throw new IndexOutOfRangeException();
            }
            int shiftIndex = index + 1;
            if (shiftIndex < length)
            {
                Array.Copy(MyArray, shiftIndex, MyArray, index, length - shiftIndex);
            }
            length--;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < length; i++)
            {
                if (MyArray[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void Insert(int index, T item)
        {
            if (index >= length)
            {
                throw new ArgumentOutOfRangeException("index", index, "ArgumentOutOfRange");
            }

            if (MyArray.Length == length) Capacity *= 2;

            if (index < length)
                Array.Copy(MyArray, index, MyArray, index + 1, length - index);

            MyArray[index] = item;
            length++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < length; i++)
                yield return MyArray[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public T this[int index]
        {
            get
            {
                if (index >= length)
                    throw new ArgumentOutOfRangeException("index", index, "ArgumentOutOfRange");
                return MyArray[index];
            }

            set
            {
                if (index >= length)
                    throw new ArgumentOutOfRangeException("index", index, "ArgumentOutOfRange");
                MyArray[index] = value;
            }
        }
    }
}
