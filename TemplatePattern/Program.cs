using Template1;

namespace Template_Pattern
{
    class Program
    {
        static void Main()
        {
            OnlineOrderProcessor onlineOrderProcessor = new OnlineOrderProcessor();
            InStoreOrderProcessor inStoreOrderProcessor = new InStoreOrderProcessor();

            Console.WriteLine("Process online order");
            Console.WriteLine("");
            onlineOrderProcessor.ProcessOrder();
            Console.WriteLine("Process in store order");
            Console.WriteLine("");
            inStoreOrderProcessor.ProcessOrder();
        }
    }
}