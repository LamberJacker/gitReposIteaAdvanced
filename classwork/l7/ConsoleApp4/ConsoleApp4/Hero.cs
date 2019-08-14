using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Hero
    {
        public string name { get; set; }
        public int level { get; set; }
        public string ultimate { get; set; }
        public Hero() { }
        public Hero(string name, int level, string ultimate) { this.name = name; this.level = level; this.ultimate = ultimate; }

        public override string ToString()
        {
            return "Name: " + name + "; Level: " + level + "; Ultimate: " + ultimate;
        }
    }
}
