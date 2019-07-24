using System;
using System.Collections;
using System.Collections.Generic;
namespace task2
{
    class MyCollection<T> : ICollection<T>, IList<T>, IEnumerable<T>, IEnumerator<T> where T : Animal
    {

        Animal[] arr = new Animal[4];
        int capacity = 4;
        int position = 0;
        int positionMV = -1;

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

        public bool Remove(T item)// not done
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this as IEnumerator<T>;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
        
        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }
        T IEnumerator<T>.Current
        {
            get
            {
                return (T)arr[positionMV];
            }
        }
        object IEnumerator.Current
        {
            get { return arr[positionMV]; }
        }

        public void RemoveAt(int index) // 50 - 50 
        {
            arr[index] = null;
            for (int i = 0; i < arr.Length - 1 - index; i++)
            {
                Animal temp = null;
                arr[index] = temp;
                arr[index] = arr[index + 1];
            }
        }

        public bool MoveNext() // well done 
        {
            if (positionMV < position-1)
            {
                positionMV++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset() // well done 
        {
            positionMV = -1;
        }

        public void Dispose() // well done 
        {
            this.Reset();
        }
        public void FindType(string type)
        {
            for (int i = 0; i < position - 1; i++)
            {
                if (arr[i].Type == type)
                    Console.WriteLine("index of " + type + " is " + i);  
            }
        }
        public void FindName(string name)
        {
            for (int i = 0; i < position - 1; i++)
            {
                if (arr[i].Name == name)
                    Console.WriteLine("index of " + name + " is " + i);
            }
        }
    }
}
