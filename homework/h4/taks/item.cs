using System;
using System.Collections.Generic;
using System.Text;

namespace taks
{
    class Item
    {
        protected string _name;
        protected int _intelligence;
        protected int _agility;
        protected int _strength;
        public Item()
        {
            // Random rnd = new Random();
            // int rndValue = rnd.Next(0, 7);
            int rndValue = 1;
            switch (rndValue)
            {
                case 1:
                    new BFSword();
                    break;
            }
        }
        public string Name { get { return _name; } } // prop for name
        public int Intelligence { get { return _intelligence; } } // prop for int.
        public int Agility { get { return _agility; } } // prop for ag.
        public int Strength { get { return _strength; } } // prop for str.

        public override string ToString() // info about fields
        {
            return Name + ": Int.= " + Intelligence + "; Ag.= " + Agility + "; Str.= " + Strength;
        }
    }
    class BFSword : Item
    {
        public BFSword()
        {
            _name = "BFSword";
            _intelligence = 0;
            _agility = 5;
            _strength = 80;
        }
    }
}
