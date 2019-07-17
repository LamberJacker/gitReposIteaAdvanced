using System;

namespace task3
{
    interface IGlucable
    {
        bool isGluck();
    }
    abstract class TabletPC
    {
        string cpu;
        int ram;
        public TabletPC(string cpu, int ram)
        {
            this.cpu = cpu;
            this.ram = ram;
        }
        public virtual string GetInfo()
        {
            return ("CPU = " + cpu + ", RAM = " + ram);
        }
        public abstract void GetMark();
    }
    class Ipad : TabletPC , IGlucable
    {
        int diag;
        public Ipad(int diag, string cpu, int ram) : base (cpu, ram)
        {
            this.diag = diag;
        }
        public override void GetMark()
        {
            Console.WriteLine("mark is nice");
        }
        public override string GetInfo()
        {
            return ( base.GetInfo() + " + diag = " + diag);
        }
        public bool isGluck()
        {
            return true;
        }

    }

    class Program
    {
        static void Main()
        {
            Console.ReadKey();
        }
    }
}
