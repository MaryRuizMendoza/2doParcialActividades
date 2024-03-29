﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionaabstractFactoryl
{
    class Program
    {
        static void Main(string[] args)
        {
                ContinentFactory africa = new AfricaFactory();
                AnimalWorld world = new AnimalWorld(africa);
                world.RunFoodChain();
                ContinentFactory america = new AmericaFactory();
                world = new AnimalWorld(america);
                world.RunFoodChain();
            
                Console.ReadKey();
        }
    }
}
