using System;
using System.Collections;

namespace ConsoleApp17
{
    class Program
    {
        class Dog :ICloneable
        {
            String name = "Susleg";
          public  int age=5;
            public Dog() { }
            Dog(String name,int age)
            {
                this.name = name;
                this.age = age;
            }
            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }
                if(!(obj is Dog))
                {
                    return false;
                }
                Dog dog = (Dog)obj;
                if (!name.Equals(dog.name))
                {
                    return false;
                }
                if (age!=dog.age)
                {
                    return false;
                }
                return true;
            }
            public override String ToString()
            {
                return name;
            }

            public object Clone()
            {
                return new Dog(name,age);
            }
        }
        class Cat
        {
            String name = "Krevedko";
           public override String ToString()
            {
                return name;
            }
        }
        static void Main(string[] args)
        {
            Object ob =new Object();
            

            // ((Dog)ob).getDogName();
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = null;
            Cat cat = new Cat();
            Console.WriteLine(dog1.Equals(cat));

            Dog cloneDog = (Dog)dog1.Clone();
            Console.WriteLine(cloneDog);


        }
    }
}
