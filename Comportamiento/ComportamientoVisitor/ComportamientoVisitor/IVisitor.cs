using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoVisitor
{
    interface IVisitor

    {
        void Visit(Element element);
    }
}
