using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace task2
{
    class GoldMine
    {
        internal int gold {get; set;}
        bool flagEmptyMine;
        public GoldMine()
        {
            gold = 50;
        }
        public bool MineIsEmpty() 
        {
            return flagEmptyMine;
        }
    }
}
