﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RfqParser.Domain
{
    public class RfqPricerEngine
    {

        private QuoteCalculationEngine _quoteCalculationEngine;
        private ReferencePriceSource _referencePriceSource;
        //private QuoteCalculationEngine _quoteCalculationEngine;

        public RfqPricerEngine() {}


        public double PricingOrchestration(int securityId, bool buy, int quantity)
        {
            double quotedPrice;
            double refPrice;


            refPrice = _referencePriceSource.get(securityId);
            //make the calculation async
            quotedPrice = _quoteCalculationEngine.calculateQuotePrice(securityId, refPrice, buy, quantity);

            return quotedPrice;
        }

        public double PricingOrchestration(Rfq rfq)
        {
            return PricingOrchestration(rfq.SecurityId, rfq.Buy, rfq.Quantity);
        }
    }
}
