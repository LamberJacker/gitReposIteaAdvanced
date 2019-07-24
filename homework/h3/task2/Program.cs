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
            animalCollection.Add(new Dog("Marta","Alabai"));
            animalCollection.Add(new Cat("Toma", "Pers"));
            animalCollection.Add(new Dog("Maria", "Chau-Chau"));
            animalCollection.Add(new Cat("Murzik", "Dvornaga"));
            animalCollection.Add(new Dog("Sobol", "Ovcharka"));
            animalCollection.Add(new Dog("Misha", "Foxterier"));



            // Show collection:
            foreach (Animal an in animalCollection)
            {
                Console.WriteLine(an.ToString());
            }
            
            //Show capacity:
            Console.WriteLine(animalCollection.Capacity());
            
            //Show count:
            Console.WriteLine(animalCollection.Count());
            
            
            //Show IndexOf:
            //Console.WriteLine(animalCollection.IndexOf();
        }
    }
}
