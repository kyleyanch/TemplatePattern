
namespace Template1
{
    public abstract class OrderProcessor
    {
        public void ProcessOrder()
        {
            ValidateOrder();
            if (ShouldApplyDiscount())   // HOOK
            {
                ApplyDiscount();
            }
            ChargePayment();
            ShipOrder();
            SendConfirmation();
        }

        protected abstract void ChargePayment();
        protected abstract void ShipOrder();

        protected virtual void ValidateOrder()
        {
            Console.WriteLine("Validating order...");
        }

        protected virtual void SendConfirmation()
        {
            Console.WriteLine("Sending confirmation email...");
        }

        // HOOK METHODS
        protected virtual bool ShouldApplyDiscount()
        {
            return false; // default: no discount
        }

        protected virtual void ApplyDiscount()
        {
            Console.WriteLine("Applying standard discount...");
        }
    }

}
