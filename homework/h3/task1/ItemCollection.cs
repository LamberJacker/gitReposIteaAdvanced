using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class ItemCollection<T> : ICollection<T>, IList<T>, IEnumerable<T>, IEnumerator<T> where T : Item
    {
        Item[] itemCollect = new Item[4];

        int countOfItem = 0;
        int capacityArrItems = 4;
        int lengthArrItems = 0;
        int position = -1;

        public T this[int index] // well done 
        {
            get
            {
                return (T)itemCollect[index];
            }
        }

        T IList<T>.this[int index] // well done 
        {
            get
            {
                return (T)itemCollect[index];
            }
            set
            {
                if (index >= 0 & index <= capacityArrItems)
                    itemCollect[index] = value;
            }
        }

        public int Count // well done 
        {
            get { return countOfItem; }
        }

        public bool IsReadOnly => throw new NotImplementedException(); // not realized

        public T Current // well done 
        {
            get
            {
                return (T)itemCollect[countOfItem];
            }
        }

        object IEnumerator.Current // well done 
        {
            get
            {
                return itemCollect[countOfItem];
            }
        }

        public void Add(T item) // well done 
        {
            if (countOfItem == capacityArrItems)
            {
                Item[] tempArr = new Item[capacityArrItems * 2];
                Array.Copy(itemCollect, tempArr, countOfItem);
                itemCollect = tempArr;
                capacityArrItems *= 2;
            }
            countOfItem++;
            itemCollect[countOfItem] = item;
        }

        public void Clear()  // well done 
        {
            capacityArrItems = 4;
            countOfItem = 0;
            itemCollect = new Item[capacityArrItems];
        }

        public bool Contains(T item) // not realized 
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex) // not realized 
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

        public int IndexOf(T item) // well done 
        {
            int i = 0;
            while (item != itemCollect[i++]) { }
            return i;
        }

        public void Insert(int index, T item) // not realized 
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item) // well done 
        {
            {
                int i;
                for  (i = 0; i < itemCollect.Length; i++)
                {
                    if (item == itemCollect[i])
                    {
                        for (int j = i; j < itemCollect.Length - i; j++)
                        {
                            itemCollect[j] = itemCollect[j + 1];
                        }
                        return true;
                    }
                }
                return false;
            }
        }

        public void RemoveAt(int index) // well done 
        {
            itemCollect[index] = null;
            for (int j = 0; j < itemCollect.Length - index; j++)
            {
                itemCollect[j] = itemCollect[j + 1];
            }
        }

        public bool MoveNext() // well done 
        {
            if (position < countOfItem)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset() // well done  
        {
            position = -1;
        }

        public void Dispose()// well done 
        {
            this.Reset();
        }
    }
}
