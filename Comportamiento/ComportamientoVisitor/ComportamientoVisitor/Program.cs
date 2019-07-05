﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            Console.ReadKey();
        }

    }
}

