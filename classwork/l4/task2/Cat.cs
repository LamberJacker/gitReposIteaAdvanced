using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Cat
    {
        string name;
        int age;
        public int Age
        {
            get
            {
                return age;
            }
        }
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return "i`m a cat " + name + " i`m " + age + "old \n";
        }
    }
}
