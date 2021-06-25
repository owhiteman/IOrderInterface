using System;

namespace OrderInterface
{
    public interface IOrder
    {
        void GetOrder();
    }

    public class CustomerOrder : IOrder
    {
        public void GetOrder()
        {
            Console.WriteLine("Customer Order");
        }
    }

    public class PurchaseOrder : IOrder
    {
        public void GetOrder()
        {
            Console.WriteLine("Purchase Order");
        }
    }

    class MainClass
    {        

        public static void Main()
        {
            CustomerOrder customer = new CustomerOrder();
            PurchaseOrder purchase = new PurchaseOrder();

            customer.GetOrder();
            purchase.GetOrder();
        }
    }
}
