﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoVisitor
{
    class IncomeVisitor : IVisitor

    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            employee.Income *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}",
              employee.GetType().Name, employee.Name,
              employee.Income);
        }
    }
}
