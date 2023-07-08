using System;
using System.Collections.Generic;

namespace Foundation2
{
    class Customer
    {
        public string Name { get; private set; }
        public Address Address { get; private set; }

        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }
    }
}