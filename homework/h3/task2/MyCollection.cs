using System;
using System.Collections;
using System.Collections.Generic;
namespace task2
{
    class MyCollection<T> : ICollection<T>, IList<T> where T : Animal
    {

        Animal[] arr = new Animal[4];
        int capacity = 4;
        int position = 0;

        public MyCollection() { }
        public bool IsReadOnly => throw new NotImplementedException();
        int ICollection<T>.Count // well done 
        {
            get
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != null)
                        count++;
                }
                return count;
            }
        }
        public T Current() // well done 
        {
            return (T)arr[position];
        }
        T IList<T>.this[int index] // well done 
        {
            get
            {
                return (T)arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
        public int Count() // well done 
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                    count++;
            }
            return count;
        }
        public int Capacity() // well done 
        {
            return arr.Length;
        }

        public void Add(T item) // well done 
        {
            if (position == capacity)
            {
                Animal[] temp = new Animal[arr.Length * 2];
                Array.Copy(arr, temp, arr.Length);
                arr = temp;
                capacity *= 2;
            }
            arr[position++] = item;
        }
        public int IndexOf(T item)
        {
            int indexOf = 0, i = 0;
            while (item != arr[i++])
            {
                indexOf++;
            }
            return indexOf;
        }

        public void Clear() // not now 
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item) //not now 
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex) //not now 
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            arr[index] = null;
            for (int i = 0; i < arr.Length - 1 - index; i++)
            {
                Animal temp = null;
                arr[index] = temp;
                arr[index] = arr[index + 1];
            }
        }
    }
}
