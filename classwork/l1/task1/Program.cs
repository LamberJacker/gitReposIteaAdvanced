using System;

namespace task1
{
    class Parent
    {
        protected int x = 1;

        public int getParent()
        {
            return x;
        }
    }

    class Child : Parent
    {
        public int getChild()
        {
            return x;
        }
    }

    class Program
    {
        static void Main()
        {
            Child child1 = new Child();
            Console.WriteLine(child1.getParent());
            

            Parent child2 = new Child();
            Console.WriteLine(child2.getParent());

            Console.ReadKey();
        }
    }
}
