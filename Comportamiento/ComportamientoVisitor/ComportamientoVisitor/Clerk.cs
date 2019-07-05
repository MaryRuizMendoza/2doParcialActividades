using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoVisitor
{
    class Clerk : Employee

    {
        public Clerk()
          : base("Hank", 25000.0, 14)
        {
        }
    }

    class Director : Employee

    {
        public Director()
          : base("Elly", 35000.0, 16)
        {
        }
    }

    class President : Employee

    {
        public President()
          : base("Dick", 45000.0, 21)
        {
        }
    }
}
