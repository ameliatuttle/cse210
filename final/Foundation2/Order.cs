using System;
using System.Collections.Generic;

namespace Foundation2
{
    class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal CalculateTotalCost()
        {
            decimal totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price * product.Quantity;
            }

            totalPrice += customer.Address.IsInUSA() ? 5 : 35;

            return totalPrice;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (Product product in products)
            {
                label += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            string label = "Shipping Label:\n";
            label += $"Name: {customer.Name}\n";
            label += customer.Address.GetFullAddress();
            return label;
        }
    }
}