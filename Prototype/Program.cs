using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Vedat",
                LastName = "Baysal",
                City = "İstanbul"
            };

            Customer customer1 = (Customer)customer.Clone();
            customer1.FirstName = "Mahmut";

            Console.WriteLine(customer.FirstName);

            Console.WriteLine(customer1.FirstName);
            Console.ReadKey();

        }
    }
}
