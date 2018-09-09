using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //member variables
        public T[] newArray;
        private int count;
        private int capacity;
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
    }
}
