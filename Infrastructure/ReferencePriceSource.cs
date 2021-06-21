using RfqParser.Infrastructure;

namespace RfqParser.Domain
{
    internal class ReferencePriceSource
    {
        public void subscribe(IReferencePriceSourceListener listener)
        {
            return;
        }

        public double get(int securityId)
        {
            double refPrice = 0.0;

            return refPrice;
        }
    }
}