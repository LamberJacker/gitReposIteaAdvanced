using System;
using System.Collections;


namespace task3
{
    class MyCollection : ICollection, IList
    {
        int[] arr = new int[4];
        int length = 0;
        int capacity = 4;
        int currentIndex = 0;

        int ICollection.Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        object IList.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int this[int index] { get { return arr[index]; } set { arr[index] = value; } }

        public int Count()
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) count++;
            }
            return count;
        }
        public int Capacity()
        {
            return arr.Length;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public int Add(object value)
        {
            if (length == capacity)
            {
                int[] temp = new int[arr.Length * 2];
                Array.Copy(arr, temp, arr.Length)
            }
            arr[currentIndex++] = (int)value;
            length = currentIndex;
            return 0;
        }
    }
    class Program
    {
        static void Main()
        {
            
        }
    }
}
