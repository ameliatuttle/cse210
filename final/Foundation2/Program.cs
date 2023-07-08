using System;
using System.Collections.Generic;

namespace Foundation2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 Main St", "City 1", "State 1", "USA");
            Address address2 = new Address("456 Market St", "City 2", "State 2", "Canada");

            // Create customers
            Customer customer1 = new Customer("Customer 1", address1);
            Customer customer2 = new Customer("Customer 2", address2);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Product 1", 1, 10, 2));
            order1.AddProduct(new Product("Product 2", 2, 15, 1));

            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Product 3", 3, 20, 3));

            // Display packing label, shipping label, and total cost for each order
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order1.CalculateTotalCost());
            Console.WriteLine();

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order2.CalculateTotalCost());
        }
    }
}