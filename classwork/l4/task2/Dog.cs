using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Dog : Object
    {
        string name;
        int age;
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return "i`m a dog " + name + " i`m " + age + "old \n";
        }
        public override bool Equals(object obj)
        {
            Dog dog = (Dog)obj;
            if (name.Equals(dog.name) && age.Equals(dog.age))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.GetHashCode(); 
        }
    }
}
