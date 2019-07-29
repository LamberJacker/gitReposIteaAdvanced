using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace taks
{
    class BagItems : IEnumerable, IEnumerator
    {
        List<Item> bag = new List<Item>();
        int possition = -1;
        public BagItems() // default constr for list of 6 random items 
        {
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                int rndValue = rnd.Next(0,8);
                switch (rndValue)
                {
                    case 0:
                        bag.Add(new BFSword());
                        break;
                    case 1:
                        bag.Add(new BootsOfSpeed());
                        break;
                    case 2:
                        bag.Add(new Tormail());
                        break;
                    case 3:
                        bag.Add(new IronHeart());
                        break;
                    case 4:
                        bag.Add(new Sheen());
                        break;
                    case 5:
                        bag.Add(new TrinityForce());
                        break;
                    case 6:
                        bag.Add(new RunesOfHell());
                        break;
                    case 7:
                        bag.Add(new Colector());
                        break;
                }
            }
        }

        public object Current { get { return bag; } } // prop for IEnumerator.Current()

        public IEnumerator GetEnumerator() //realize of  IEnumerable 
        {
            return this as IEnumerator;
        }

        public List<Item> getListOfBag() // get bag of items 
        {
            return bag;
        }

        public bool MoveNext()  // IEnumerator.MoveNext() 
        {
            if (possition < 0 && possition > bag.Count - 1)
                return false;
            else
                possition++;
                return true;
        } 

        public void Reset() // IEnumerator.Reset() 
        {
            possition = -1;
        }

        public override string ToString() //show consists of bags 
        {
            string bagItem = "Bag Items:";
            for (int i = 0; i < 7; i++)
            {
                bagItem += "\n"+ "Slot#" + i + ". " + bag[i].ToString();
            }
            return bagItem;
        }
    }
}
