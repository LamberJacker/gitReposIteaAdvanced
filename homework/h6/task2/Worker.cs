using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace task2
{
    class Worker
    {
        GoldMine mine;
        int name;
        int productivity;
        int doneWork;
        public Worker(int name,int productivity, GoldMine mine) 
        {
            this.name = name;
            this.mine = mine;
            this.productivity = productivity;
            new Thread(WorkerWork).Start();
        }
        void WorkerWork()
        {
            while (!mine.MineIsEmpty())
            {
                    Thread.Sleep(1000);
                    mine.gold -= productivity;
                    doneWork += productivity;
                    Console.WriteLine(ToString());
            }
        }
        public override string ToString() 
        {
            return "Name " + name + " mined gold: " + doneWork;
        }
    }
}
