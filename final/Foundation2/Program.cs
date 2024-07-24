using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Rushmoore st.", "Kansas", "Arkansas", "USA");
        Address address2 = new Address("Nishimoto st.", "Kyukyu", "Osaka", "Japan");

        Customer customer1 = new Customer("Gerald Riverhelm", address1);
        Customer customer2 = new Customer("Akira Yoriko", address2);

        Product product1 = new Product("Dining utensil", "49165", 4.99, 10);
        Product product2 = new Product("Colored pencil", "27454", 12.5, 3);
        Product product3 = new Product("Guitar", "79053", 499.99, 1);
        Product product4 = new Product("Flashdrive", "61216", 59.99, 2);

        Order order1 = new Order(customer1);
        order1.AddProducts(product1);
        order1.AddProducts(product2);
        order1.AddProducts(product3);

        Order order2 = new Order(customer2);
        order2.AddProducts(product2);
        order2.AddProducts(product3);
        order2.AddProducts(product4);

        order1.ShippingLabel();
        order1.PackingLabel();
        Console.WriteLine($"Total Cost: ${order1.TotalCost().ToString("0.##")}");

        order2.ShippingLabel();
        order2.PackingLabel();
        Console.WriteLine($"Total Cost: ${order2.TotalCost().ToString("0.##")}");
    }
}