﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RfqParser.Infrastructure
{
    interface IReferencePriceSource
    {
        void subscribe(IReferencePriceSourceListener listener);

        double get(int securityId);
    }
}
