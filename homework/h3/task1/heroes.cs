using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace task1
{
    abstract class Hero : ItemCollection<Item>
    {
        protected string name;
        protected int agility;
        protected int intelligence;
        protected int strength;
        protected int strikePwr;
        public abstract bool getUltimate();
        protected ItemCollection<Item> bagItems = new ItemCollection <Item>();
        public Hero() { }
        public Hero(ItemCollection<Item> bagItems)
        {
            this.bagItems = bagItems;
        }
        public Hero(Hero hero)
        {
            name = hero.name;
            agility = hero.agility;
            intelligence = hero.intelligence;
            strength = hero.strength;
            strikePwr = hero.strikePwr;
            bagItems = hero.bagItems;
        }
        public void ShowHeroStats()
        {
            Console.WriteLine("\nName = {0}\nAgility = {1}\nIntelligence = {2}\nStrength = {3}\nStrikePower = {4}", name, agility, intelligence, strength, strikePwr);
            Console.WriteLine(new string('-', 17));
            for (int i = 0; i <= bagItems.Count; i++)
            {
                if(bagItems[i] != null) Console.WriteLine("Item = {0}", bagItems[i].Name);
            }
            Console.WriteLine(new string('-', 17));
        }
        public string Name // property of name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class PhantomDancer : Hero, ICloneable
    {
        public PhantomDancer(ItemCollection<Item> bagItems) // default constructor 
        {
            name = "PhantomDancer";
            agility += 45;
            intelligence += 5;
            strength += 25;
            strikePwr += agility * 2 + intelligence * 1 + strength * 3;
            this.bagItems = bagItems;
        }
        public PhantomDancer(PhantomDancer mage) //clone with constructor 
        {
            name = mage.name;
            agility = mage.agility;
            intelligence = mage.intelligence;
            strength = mage.strength;
            strikePwr = mage.strikePwr;
            bagItems = mage.bagItems;
        }
        private PhantomDancer(string name, int agility, int intelligence, int strength, int strikePwr, ItemCollection<Item> bagItems) //private constructor 
        {
            this.name = name;
            this.agility = agility;
            this.intelligence = intelligence;
            this.strength = strength;
            this.strikePwr = strikePwr;
            this.bagItems = bagItems;
        }
        public object Clone() //clone method 
        {
            return new PhantomDancer(name, agility, intelligence, strength, strikePwr, bagItems);
        }
        public override bool getUltimate()
        {
            for (int i = 0; i < bagItems.Count; i++)
            {
                if (bagItems[i] == null) continue;
                if (bagItems[i].Name == "MantaStyle")
                    return true;
            }
            return false;
        }
    }
    class AntiMage : Hero, ICloneable
    {
        public AntiMage(ItemCollection<Item> bagItems) // default constructor 
        {
            name += "AntiMage";
            agility += 60;
            intelligence += 10;
            strength += 5;
            strikePwr += agility * 3 + intelligence * 1 + strength * 1;
            this.bagItems = bagItems;
        }
        public AntiMage(AntiMage mage) //clone with constructor 
        {
            name = mage.name;
            agility = mage.agility;
            intelligence = mage.intelligence;
            strength = mage.strength;
            strikePwr = mage.strikePwr;
            bagItems = mage.bagItems;
        }
        private AntiMage(string name, int agility, int intelligence, int strength, int strikePwr, ItemCollection<Item> bagItems) //private constructor 
        {
            this.name = name;
            this.agility = agility;
            this.intelligence = intelligence;
            this.strength = strength;
            this.strikePwr = strikePwr;
            this.bagItems = bagItems;
        }
        public object Clone() //clone method 
        {
            return new AntiMage(name, agility, intelligence, strength, strikePwr, bagItems);
        }
        public override bool getUltimate()
        {
            for (int i = 0; i < bagItems.Count; i++)
            {
                if (bagItems[i] == null) continue;
                if (bagItems[i].GetType().Name == "MantaStyle")
                    return true;
            }
            return false;
        }
    }
}

