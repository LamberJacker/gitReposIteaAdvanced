using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Order
    {
        public long id { get; set; }
        public long user_id { get; set; }
        public string name { get; set; }
        public int model { get; set; }
        public override string ToString()
        {
            return "id = " + id + "; user_Id = " + user_id + "; NameOrder = " + name + "; modelOrder = "
                + model;
        }
    }
}
