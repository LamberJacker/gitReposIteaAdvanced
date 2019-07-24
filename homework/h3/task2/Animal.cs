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
        public abstract string GetVoice();
        public override string ToString()
        {
            return "Name : " + name + " type : " + type;
        }
        public string Type
        {
            get
            {
                return type;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
    class Dog : Animal
    {
        public Dog(string name, string type) : base(name, type)
        {
            base.name = name;
            base.type = type;
        }
        public override string GetVoice()
        {
            return "DOG";
        }
    }
    class Cat : Animal
    {
        public Cat(string name, string type) : base(name, type)
        {
            base.name = name;
            base.type = type;
        }
        public override string GetVoice()
        {
           return "CAT";
        }
    }
}

