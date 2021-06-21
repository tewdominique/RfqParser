using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RfqParser.Infrastructure
{
    interface IReferencePriceSourceListener
    {
        void referencePriceChanged(int securityId, double price);
    }
}
