using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace task2
{
    class Stronghold
    {
        List<Worker> listWorkers;
        GoldMine mine;

        public Stronghold(List<Worker> listWorkers, GoldMine mine) 
        {
            this.listWorkers = listWorkers;
            this.mine = mine;
            for (int i = 0; i < 3; i++)
            {
                listWorkers.Add(new Worker(3, mine));
            }
            new Thread(AddNewWorker).Start();
        }
        public void AddNewWorker()
        {
            while (!mine.MineIsEmpty())
            {
                Thread.Sleep(10000);
                Console.Clear();
                listWorkers.Add(new Worker(3, mine));
                Console.WriteLine(ToString());
            }
        }
        public override string ToString()
        {
            return "New worker was added to mine!";
        }
    }
}
