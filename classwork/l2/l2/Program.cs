using System;
using System.Collections;


namespace l2
{
    class Dog : ICloneable
    {
        string name;
        int age;
        public Dog() { }
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override object Clone()
        {
            return new Dog(name, age);
        }

        public override bool Equals(object objct)
        {
            Dog dog = (Dog)objct;
            if (objct == null) return false;
            if (!name.Equals(dog.name)) return false;
            if (age != dog.age) return false;
            if (!(objct is Dog)) return false;
            return true;
        }
    }
    class Program
    {
        static void Main()
        {
            Dog dog1 = new Dog("Dog", 25);
            Dog dog2 = new Dog("Dog", 25);
            Dog dog3 = new Dog("Dog", 25);
            dog3.Clone(dog2);
            Console.WriteLine(dog1.Equals(dog2));
        }
    }
}
