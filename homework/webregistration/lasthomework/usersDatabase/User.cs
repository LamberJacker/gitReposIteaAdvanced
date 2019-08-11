using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lasthomework
{
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public long age { get; set; }
        public int sex { get; set; }
        public override string ToString()
        {
            return "id = " + id + "; Name = " + name + "; Login = " + login + "; Password = "
                + password + "; Address " + address + "; Age = " + age + "; Sex(gender) = " + sex;
        }
    }
}
