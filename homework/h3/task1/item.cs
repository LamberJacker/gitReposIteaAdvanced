using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace task1
{
    class Item
    {
        public string name;
        public int agility;
        public int intelligence;
        public int strength;
    }

    class PhaseBoots : Item
    {
        public PhaseBoots()
        {
            name = "PhaseBoots";
            agility = 30;
            intelligence = 20;
            strength = 15;
        }
    }
    class MantaStyle : Item
    {
        public MantaStyle()
        {
            name = "MantaStyle";
            agility = 30;
            intelligence = 40;
            strength = 60;
        }
    }
}
