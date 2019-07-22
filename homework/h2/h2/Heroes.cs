using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace h2
{
    abstract class Hero : ICloneable
    {
        protected string name;
        protected int agility;
        protected int intelligence;
        protected int strength;
        protected int strikePwr;
        public abstract ArrayList getUltimate();
        protected Item item = new Item();
        public Hero()
        {
            AddItem();
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
                    Item phaseBoots = new PhaseBoots();
                    item = phaseBoots;
                    agility += phaseBoots.agility;
                    intelligence += phaseBoots.intelligence;
                    strength += phaseBoots.strength;
                    break;
                case 2:
                    Item mantaStyle = new MantaStyle();
                    item = mantaStyle;
                    agility += mantaStyle.agility;
                    intelligence += mantaStyle.intelligence;
                    strength += mantaStyle.strength;
                    break;
            }
        }
        public virtual object Clone()
        {
            return null;
        }
    }
    class PhantomDancer : Hero
    {
        public PhantomDancer()
        {
            name = "PhantomDancer";
            agility += 45;
            intelligence += 5;
            strength += 25;
            strikePwr += agility * 2 + intelligence * 1 + strength * 3;
        }
        public override object Clone()
        {
            return new PhantomDancer();
        }
        public override ArrayList getUltimate()
        {
            if (item.GetType().Name == "MantaStyle") return new ArrayList() { "GetUltimate" };
            else return new ArrayList() { "Ult is Done" };
        }
    }
    class AntiMage : Hero
    {
        public AntiMage()
        {
            name += "AntiMage";
            agility += 60;
            intelligence += 10;
            strength += 5;
            strikePwr += agility * 3 + intelligence * 1 + strength * 1;
        }
        public override object Clone()
        {
            return new AntiMage();
        }
        public override ArrayList getUltimate()
        {
            if (item.GetType().Name == "MantaStyle") return new ArrayList() { "GetUltimate" };
            else return new ArrayList() { "Ult is Done" };
        }
    }
}

