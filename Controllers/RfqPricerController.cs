using Microsoft.AspNetCore.Mvc;
using RfqParser.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RfqParser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RfqPricerController : ControllerBase
    {
        private RfqParser _rfqParser;
        private RfqPricerEngine _rfqPricerEngine;

        [HttpPost]
        public double ComputePrice(string rfqLine)
        {
            double res = 0;

            if(!_rfqParser.IsValid(rfqLine))
            {
                return -1;
            }
            
            Rfq rfq = _rfqParser.rfqBuilder(rfqLine);
            
            return _rfqPricerEngine.PricingOrchestration(rfq);           
        }
    }
}
