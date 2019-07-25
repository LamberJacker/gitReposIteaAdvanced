using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace task1
{
    abstract class Hero : ItemCollection<T>
    {
        protected string name;
        protected int agility;
        protected int intelligence;
        protected int strength;
        protected int strikePwr;
        public abstract ArrayList getUltimate();
        
        public Hero()
        {
            AddItem();
        }

        public Hero(Hero hero)
        {
            name = hero.name;
            agility = hero.agility;
            intelligence = hero.intelligence;
            strength = hero.strength;
            strikePwr = hero.strikePwr;
            item = hero.item;
        }
        public void ShowHeroStats()
        {
            Console.WriteLine("\nName = {0}\nAgility = {1}\nIntelligence = {2}\nStrength = {3}\nStrikePower = {4}", name, agility, intelligence, strength, strikePwr);
            Console.WriteLine(new string('-', 17));
            Console.WriteLine("Item = {0}", item.name);
            Console.WriteLine(new string('-', 17));
        }
        private void AddItem()
        {
            Random rnd = new Random();
            int rndItem = rnd.Next(1, 3);
            switch (rndItem)
            {
                case 1:
                    //Item phaseBoots = new PhaseBoots();
                    //item = phaseBoots;
                    //agility += phaseBoots.agility;
                    //intelligence += phaseBoots.intelligence;
                    //strength += phaseBoots.strength;
                    break;
                case 2:
                    //Item mantaStyle = new MantaStyle();
                    //item = mantaStyle;
                    //agility += mantaStyle.agility;
                    //intelligence += mantaStyle.intelligence;
                    //strength += mantaStyle.strength;
                    break;
            }
        }
        public string Name { get { return name; } set { name = value; } }
    }
    class PhantomDancer : Hero, ICloneable
    {
        public PhantomDancer()
        {
            name = "PhantomDancer";
            agility += 45;
            intelligence += 5;
            strength += 25;
            strikePwr += agility * 2 + intelligence * 1 + strength * 3;
        }
        public PhantomDancer(PhantomDancer mage)
        {
            name = mage.name;
            agility = mage.agility;
            intelligence = mage.intelligence;
            strength = mage.strength;
            strikePwr = mage.strikePwr;
            item = mage.item;
        }
        public PhantomDancer(string name, int agility, int intelligence, int strength, int strikePwr, Item item)
        {
            this.name = name;
            this.agility = agility;
            this.intelligence = intelligence;
            this.strength = strength;
            this.strikePwr = strikePwr;
            this.item = item;
        }
        public object Clone()
        {
            return new PhantomDancer(name, agility, intelligence, strength, strikePwr, item);
        }
        public override ArrayList getUltimate()
        {
            if (item.GetType().Name == "MantaStyle") return new ArrayList() { "GetUltimate" };
            else return new ArrayList() { "Ult is Done" };
        }
    }
    class AntiMage : Hero, ICloneable
    {
        public AntiMage()
        {
            name += "AntiMage";
            agility += 60;
            intelligence += 10;
            strength += 5;
            strikePwr += agility * 3 + intelligence * 1 + strength * 1;
        }
        public AntiMage(AntiMage mage)
        {
            name = mage.name;
            agility = mage.agility;
            intelligence = mage.intelligence;
            strength = mage.strength;
            strikePwr = mage.strikePwr;
            item = mage.item;
        }
        public AntiMage(string name, int agility, int intelligence, int strength, int strikePwr, Item item)
        {
            this.name = name;
            this.agility = agility;
            this.intelligence = intelligence;
            this.strength = strength;
            this.strikePwr = strikePwr;
            this.item = item;
        }

        public object Clone()
        {
            return new AntiMage(name, agility, intelligence, strength, strikePwr, item);
        }
        public override ArrayList getUltimate()
        {
            if (item.GetType().Name == "MantaStyle") return new ArrayList() { "GetUltimate" };
            else return new ArrayList() { "Ult is Done" };
        }
    }
}

