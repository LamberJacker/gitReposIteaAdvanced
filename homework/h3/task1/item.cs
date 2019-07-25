using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace task1
{
    class Item
    {
        protected string name;
        protected int agility;
        protected int intelligence;
        protected int strength;

        public Item(string name, int agility, int intelligence, int strength) // constructor for new item 
        {
            this.name = name;
            this.agility = agility;
            this.intelligence = intelligence;
            this.strength = strength;
        }
        public string Name // property for field name 
        {
            get
            {
                return name;
            }
        }
    }
}

