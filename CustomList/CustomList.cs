using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        //member variables
        public T[] newArray;
        private int count { get; set; }
        private int capacity { get; set; }
        public T[] array;

        //constructor
        public CustomList()
        {
            capacity = 5;
            count = 0;
            array = new T[capacity];
        }

        //member methods

        // Indexer
        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public void Add(T elementToAdd)
        {
            count++;
            T[] newArray;

            if (count > capacity)
            {
                capacity *= 2;
                newArray = new T[capacity];

                for (int i = 0; i < count - 1; i++)
                {
                    newArray[i] = array[i];
                }

                newArray[count - 1] = elementToAdd;
                array = newArray;
            }
            else
            {
                array[count - 1] = elementToAdd;
            }
        }

        public void Remove(T valueToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(valueToRemove))
                {
                    count--;
                    for (; i < count; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    array[count] = default(T);
                    break;
                }
            }
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result;

            result = list1;
            foreach (T item in list2)
            {
                result.Add(item);
            }

            return result;
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();

            if (list1.count > list2.count)
            {
                result = list1;
                for (int i = 0; i < list2.count; i++)
                {
                    list1.Remove(list1[i]);
                }
            }
            else if (list2.count > list1.count)
            {
                result = list2;
                for(int i = 0; i < list1.count; i++)
                {
                    list2.Remove(list2[i]);
                }
            }
            else
            {
                return result;
            }

            //result = list1;
            //foreach (T item in list2)
            //{
            //    result.Remove(item);
            //}

            return result;
        }
    }
}
