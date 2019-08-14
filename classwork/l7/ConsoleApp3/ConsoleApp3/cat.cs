using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Cat
    {
        public string name;
        public int age;
        public Cat(string name, int age) { this.name = name; this.age = age; }
        public override string ToString()
        {
            return "Name: " + name + "; Age: " + age;
        }
    }
}
