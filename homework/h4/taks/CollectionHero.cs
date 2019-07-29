using System;
using System.Collections.Generic;
using System.Text;

namespace taks
{
    class CollectionHero : ICloneable
    {
        Dictionary<Hero, List<Item>> colHero = new Dictionary<Hero, List<Item>>();

        public CollectionHero() // default constr for dictionary of 5 random heroes and bags of items 
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int rndValue = rnd.Next(0, 7);
                switch (rndValue)
                {
                    case 0:
                        colHero.Add(new Tryndamere(), new BagItems().getListOfBag());
                        break;
                    case 1:
                        colHero.Add(new Kayle(), new BagItems().getListOfBag());
                        break;
                    case 2:
                        colHero.Add(new Brand(), new BagItems().getListOfBag());
                        break;
                    case 3:
                        colHero.Add(new Zed(), new BagItems().getListOfBag());
                        break;
                    case 4:
                        colHero.Add(new Yasuo(), new BagItems().getListOfBag());
                        break;
                    case 5:
                        colHero.Add(new Oriana(), new BagItems().getListOfBag());
                        break;
                    case 6:
                        colHero.Add(new Nasus(), new BagItems().getListOfBag());
                        break;
                }
            }
        }
        public CollectionHero(Dictionary<Hero, List<Item>> cloneColHero) // constr for method Clone() 
        {
            colHero = cloneColHero;
        }
        public override string ToString() // Show our dictionary of Heroes and Items 
        {
            string result = "";
            foreach (KeyValuePair<Hero, List<Item>> f1 in colHero)
            {
                Console.WriteLine("\n" + f1.Key);
                Console.WriteLine(new string ('-',30));
                foreach (Item f2 in f1.Value)
                {
                    Console.WriteLine(f2.ToString());
                }
            }
            return result;
        }

        public object Clone() // method for Clone 
        {
            Console.WriteLine(new string ('-' , 20) + "CLONE HEROES" + new string('-', 20)); // for view in console
            Dictionary<Hero, List<Item>> cloneColHeroes = new Dictionary<Hero, List<Item>>(); // new clone of dictionary of heroes 
            cloneColHeroes = colHero; // copy link
            foreach (KeyValuePair<Hero, List<Item>> f1 in colHero) // initialize value of field "checkClone" in class Hero   
            {
                f1.Key.checkClone = "It`s CLONE";
            }
            return new CollectionHero(cloneColHeroes);
        }
    }
}
