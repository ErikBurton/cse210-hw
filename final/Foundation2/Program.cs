using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new Product("Laptop", "P001", 1200.00, 2);
        Product product2 = new Product("Printer", "P002", 300.00, 1);
        Product product3 = new Product("Mouse", "P003", 20.00, 3);

        // Create addresses
        Address address1 = new Address("789 Seaside Avenue", "Daytona Beach", "FL", "USA");
        Address address2 = new Address("2112 Overture Park", "Toronto", "Ontario", "Canada");

        // Create customers
        Customer customer1 = new Customer("Tom Petty", address1);
        Customer customer2 = new Customer("Geddy Lee", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}