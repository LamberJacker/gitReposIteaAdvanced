﻿using System;
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
        public string checkClone; // field for clone collection. This field value is "CLONE" if object clone.
        string Name { get { return _name; } } // get prop for name
        int Intelligence { get { return _intelligence; } } // get prop for int.
        int Agility { get { return _agility; } } // get prop for ag.
        int Strength { get { return _strength; } } // get prop for str.
        public override string ToString() // info about fields
        {
            return "Hero - " + Name + ": Int.= " + Intelligence + "; Ag.= " + Agility + "; Str.= " + Strength + " " + checkClone;
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
