using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MyClass
    {
        public string getAut(string login, string pass)
        {
            if (login.Equals("admin") & pass.Equals("123"))
                return "Access";
            else return "Denide";
        }
    }
}
