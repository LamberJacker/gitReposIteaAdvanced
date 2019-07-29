using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace taks
{
    class Hero
    {
        protected string _name;
        protected int _intelligence;
        protected int _agility;
        protected int _strength;
        protected List<Item> bag = new List<Item>();
        
        public Hero() // default constr
        {
            for (int i = 0; i < 1; i++)
            {
                bag.Add(new Item());
            }
        } 
        public string Name { get { return _name; } } // prop for name
        public int Intelligence { get { return _intelligence; } } // prop for int.
        public int Agility { get { return _agility; } } // prop for ag.
        public int Strength { get { return _strength; } } // prop for str.
        public override string ToString() // info about fields
        {
            return Name + ": Int.= " + Intelligence + "; Ag.= " + Agility + "; Str.= " + Strength + "\n" + ShowBag();
        }
        string ShowBag()
        {
            string bagInfo = "";
            Console.WriteLine(new string ('-',20));
            for (int i = 0; i < 7; i++)
            {
                bagInfo += "\n" + bag[i].ToString();
            }
            return bagInfo;
        }

        
    }
    class Tryndamere : Hero
    {
        public Tryndamere()
        {
            _name = "Tryndamere";
            _intelligence = 2;
            _agility = 15;
            _strength = 40;
        }
    }
    class Kayle : Hero
    {
        public Kayle()
        {
            _name = "Kayle";
            _intelligence = 15;
            _agility = 20;
            _strength = 8;
        }
    }
    class Brand : Hero
    {
        public Brand()
        {
            _name = "Brand";
            _intelligence = 40;
            _agility = 5;
            _strength = 0;
        }
    }
    class Zed : Hero
    {
        public Zed()
        {
            _name = "Zed";
            _intelligence = 10;
            _agility = 30;
            _strength = 15;
        }
    }
    class Yasuo : Hero
    {
        public Yasuo()
        {
            _name = "Yasuo";
            _intelligence = 9;
            _agility = 30;
            _strength = 15;
        }
    }
    class Oriana : Hero
    {
        public Oriana()
        {
            _name = "Oriana";
            _intelligence = 35;
            _agility = 15;
            _strength = 3;
        }
    }
    class Nasus : Hero
    {
        public Nasus()
        {
            _name = "Nasus";
            _intelligence = 10;
            _agility = 20;
            _strength = 40;
        }
    }
}
