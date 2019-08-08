using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace task2
{
    class Worker
    {
        GoldMine mine;
        string name;
        int productivity;
        int doneWork;
        public Worker(int productivity, GoldMine mine) 
        {
            this.mine = mine;
            this.productivity = productivity;
            new Thread(WorkerWork).Start();
        }
        public int ProdWorker //prop return prod. of worker 
        {
            get
            {
                return productivity;
            }
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
            return "Name " + name + " Done work: " + doneWork;
        }
    }
}
