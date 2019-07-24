using System;
using System.Collections;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main()
        {
            MyCollection <Animal> animalCollection = new MyCollection <Animal> ();

            // initialize collection:
            Dog an0 = new Dog("Marta", "Alabai");
            Cat an1 = new Cat("Toma", "Pers");
            Dog an2 = new Dog("Maria", "Chau-Chau");
            Cat an3 = new Cat("Murzik", "Dvornaga");
            Dog an4 = new Dog("Sobol", "Ovcharka");
            Dog an5 = new Dog("Misha", "Foxterier");

            animalCollection.Add(an0);
            animalCollection.Add(an1);
            animalCollection.Add(an2);
            animalCollection.Add(an3);
            animalCollection.Add(an4);
            animalCollection.Add(an5);

            // Show collection:
            Console.WriteLine("Our collection of animals : ");
            foreach (Animal an in animalCollection)
            {
                Console.WriteLine(an.ToString());
            }
            
            //Show capacity:
            Console.WriteLine("\nCapacity of animal collection is - " + animalCollection.Capacity());
            
            //Show count:
            Console.WriteLine("\nCount of all animal is - " + animalCollection.Count());

            //Show IndexOf:
            Console.WriteLine("\nIndex of \" " + an5.GetVoice() + " \" is - "+ animalCollection.IndexOf(an5));
            Console.WriteLine("\nIndex of \" " + an2.GetVoice() + " \" is - " + animalCollection.IndexOf(an2));

            //Show FindMethods:
            Console.WriteLine(new string('-', 20));
            animalCollection.FindName("Marta");
            animalCollection.FindName("Murzik");

            Console.WriteLine(new string('-', 20));
            animalCollection.FindType("Pers");
            animalCollection.FindType("Dvornaga");
            
            //Show RemoveAt:
            Console.WriteLine(new string('-', 20));
            animalCollection.RemoveAt(100);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Our collection of animals : ");
            foreach (Animal an in animalCollection)
            {
                Console.WriteLine(an.ToString());
            }
            
            //Show Remove:
            Console.WriteLine(new string('-', 20));
            //animalCollection.Remove(an2);
            Console.WriteLine("Our collection of animals : ");
            foreach (Animal an in animalCollection)
            {
                Console.WriteLine(an.ToString());
            }

            //StopedProg
            Console.ReadKey();
        }
    }
}
