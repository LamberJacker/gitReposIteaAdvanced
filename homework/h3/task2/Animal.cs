using System;
using System.Collections;
using System.Collections.Generic;
namespace task2
{
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
            return "Name " + name + " type " + type;
        }
    }
    class Dog : Animal
    {
        public Dog(string name, string type) : base(name, type)
        {
            base.name = name;
            base.type = type;
        }
        public override void GetVoice()
        {
            Console.WriteLine("i`m a Dog");
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
            Console.WriteLine("i`m a Cat");
        }
    }
}

