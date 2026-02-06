

namespace Template1
{
    public class OnlineOrderProcessor : OrderProcessor
    {
        protected override void ChargePayment()
        {
            Console.WriteLine("Charging credit card...");
        }

        protected override void ShipOrder()
        {
            Console.WriteLine("Shipping via courier...");
        }
    }

}
