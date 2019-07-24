using System;

namespace task2
{
    class Owner : ICloneable
    {
        string _name;
        public Owner() { }
        public Owner(string name)
        {
            _name = name;
        }
        public object Clone()
        {
            return new Owner(name);
        }
    }
    class Dog : ICloneable
    {
        Owner owner;
        public 

        public object Clone()
        {
            return new Dog;
        }
    }
    class Program
    {
        static void Main()
        {

        }
    }
}
