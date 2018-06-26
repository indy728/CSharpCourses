using System;

namespace Constructors
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Kyle");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);
        }
    }
}
