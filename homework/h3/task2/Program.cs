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
            Dog an1 = new Dog("Marta", "Alabai");
            Cat an2 = new Cat("Toma", "Pers");
            Dog an3 = new Dog("Maria", "Chau-Chau");
            Cat an4 = new Cat("Murzik", "Dvornaga");
            Dog an5 = new Dog("Sobol", "Ovcharka");
            Dog an6 = new Dog("Misha", "Foxterier");

            animalCollection.Add(an1);
            animalCollection.Add(an2);
            animalCollection.Add(an3);
            animalCollection.Add(an4);
            animalCollection.Add(an5);
            animalCollection.Add(an6);

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

            //StopedProg
            Console.ReadKey();
        }
    }
}
