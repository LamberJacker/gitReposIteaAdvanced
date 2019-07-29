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
        string Name { get { return _name; } } // get prop for name
        int Intelligence { get { return _intelligence; } } // get prop for int.
        int Agility { get { return _agility; } } // get prop for ag.
        int Strength { get { return _strength; } } // get prop for str.

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
    class BootsOfSpeed : Item
    {
        public BootsOfSpeed()
        {
            _name = "BootsOfSpeed";
            _intelligence = 10;
            _agility = 10;
            _strength = 10;
        }
    }
    class Tormail : Item 
    {
        public Tormail()
        {
            _name = "Tormail";
            _intelligence = 10;
            _agility = 10;
            _strength = 60;
        }
    }
    class IronHeart : Item
    {
        public IronHeart()
        {
            _name = "IronGeart";
            _intelligence = 20;
            _agility = 20;
            _strength = 20;
        }
    }
    class Sheen : Item
    {
        public Sheen()
        {
            _name = "Sheen";
            _intelligence = 60;
            _agility = 10;
            _strength = 5;
        }
    }
    class TrinityForce : Item
    {
        public TrinityForce()
        {
            _name = "TrinityForce";
            _intelligence = 40 ;
            _agility = 40;
            _strength = 40;
        }
    }
    class RunesOfHell : Item
    {
        public RunesOfHell()
        {
            _name = "RunesOfHell";
            _intelligence = 80;
            _agility = 80;
            _strength = 80;
        }
    }
    class Colector : Item
    {
        public Colector()
        {
            _name = "Colector";
            _intelligence = 10;
            _agility = 80;
            _strength = 10;
        }
    }
}
