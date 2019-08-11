using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class UserWithOrder
    {
        public string name { get; set; }
        public string nameOrder { get; set; }
        public int model { get; set; }
        public override string ToString()
        {
            return "Name = " + name + "; NameOrder = " + nameOrder + "; model = " + model;
        }
    }
}
