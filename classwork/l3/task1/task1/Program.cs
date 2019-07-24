using System;
using System.Collections;
using System.Collections.Generic;
namespace task1
{
    class GenAnimal<T> where T : Animal
    {
        T ob;
        public GenAnimal(T ob)
        {
            this.ob = ob;
        }
        public void getTypeOb()
        {
            ob.GetVoice();
            Console.WriteLine("Type: " + ob.GetType());
        }
    }
    abstract class Animal
    {
        protected string name;
        protected string type;
        public Animal(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        public abstract void GetVoice();
        public override string ToString()
        {
            return "Name "  + name + " type " + type;
        }
    }
    class Dog : Animal
    {
        public Dog (string name, string type) : base(name, type)
        {
            base.name = name;
            base.type = type;
        }
        public override void GetVoice()
        {
            Console.WriteLine("Gav, GAv, Gav");
        }
    }
    class Cat : Animal
    {
        public Cat(string name, string type) : base(name, type)
        {
            base.name = name;
            base.type = type;
        }
        public override void GetVoice()
        {
            Console.WriteLine("Miau, Miau, Miau, Miau");
        }
    }
    class Program
    {
        static void Main()
        {
            List<Animal> listAnimal = new List<Animal>();
            listAnimal.Add(new Cat("Cat", "chiniese"));

            foreach (Animal str in listAnimal)
            {
                Console.WriteLine(str);
            }
        }
    }
}

