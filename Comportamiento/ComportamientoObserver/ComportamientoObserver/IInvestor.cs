﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoObserver
{
    interface IInvestor
    {
        void Update(Stock stock);
    }
}
