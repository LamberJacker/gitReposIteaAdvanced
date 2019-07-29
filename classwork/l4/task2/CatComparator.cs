using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class CatComparator : IComparer<Cat>
    {
        public int Compare(Cat x, Cat y)
        {
            if (x.Age > y.Age)
            {
                return 1;
            }
            else if (x.Age < y.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
