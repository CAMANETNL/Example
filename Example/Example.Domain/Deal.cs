using Example.Domain.Enums;
using Example.Domain.SharedKernel;

namespace Example.Domain
{
    public class Deal : Entity
    {
        public Contract Buy { get; private set; }
        public Contract Sell { get; private set; }

        public DealStatus Status
        {
            get
            {
                if (Buy.Signed && Sell.Signed)
                    return DealStatus.Settled;

                if (Buy.Signed && !Sell.Signed)
                    return DealStatus.BuyerSigned;

                if (!Buy.Signed && Sell.Signed)
                    return DealStatus.SelledSigned;

                return DealStatus.UnSigned;
            }
        }

        private Deal()
        {
            // This ctor is explicitly needed by EFCore
        }

        public Deal(Contract buy, Contract sell)
        {
            Buy = buy;
            Sell = sell;
        }
    }
}