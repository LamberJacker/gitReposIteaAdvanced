using System;
using System.Collections;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main()
        {
            Dictionary<Cat, Dog> dicAnimal = new Dictionary<Cat, Dog>();

            Cat cat1 = new Cat("Toma", 18);
            Cat cat2 = new Cat("Murzik", 25);
            Cat cat3 = new Cat("Sasha", 25);
            Cat cat4 = new Cat("Vasa", 5);
            Cat cat5 = new Cat("Grey", 1);
            Dog dog1 = new Dog("Marta", 10);
            Dog dog2 = new Dog("Sobol", 8);

            dicAnimal.Add(cat1, dog1);
            dicAnimal.Add(cat2, dog2);

            Console.WriteLine(new string('-', 20));

            foreach (KeyValuePair<Cat, Dog> kind in dicAnimal)
            {
                Console.WriteLine(kind + "\n");
            }

            IComparer<Cat> comparator = new CatComparator();
            SortedDictionary<Cat, Dog> dicSortAnimal = new SortedDictionary<Cat, Dog>(comparator);
            dicSortAnimal.Add(cat1, dog1);
            dicSortAnimal.Add(cat2, dog2);



            LinkedList<Dog> dogList = new LinkedList<Dog>();
            dogList.AddFirst(new Dog("Dog1",1));
            dogList.AddFirst(new Dog("Dog2", 2));

            Console.WriteLine(new string ('-',20));

            Console.WriteLine(dogList.Contains(new Dog("Dog1", 1)));
        }
    }
}
