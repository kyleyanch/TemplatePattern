

namespace Template1
{
    public class InStoreOrderProcessor : OrderProcessor
    {
        protected override void ChargePayment()
        {
            Console.WriteLine("Processing cash payment...");
        }

        protected override void ShipOrder()
        {
            Console.WriteLine("Customer picks up item in store...");
        }

        protected override void SendConfirmation()
        {
            // No email confirmation needed
        }

        protected override bool ShouldApplyDiscount()
        {
            return true; //override the default and apply the discount
        }
    }

}
