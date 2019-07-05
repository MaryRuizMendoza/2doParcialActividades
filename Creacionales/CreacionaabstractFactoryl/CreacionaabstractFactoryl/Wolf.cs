using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionaabstractFactoryl
{
    class Wolf : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison

            Console.WriteLine(this.GetType().Name +
              " come a  " + h.GetType().Name);
        }
    }
}
