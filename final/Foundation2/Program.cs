using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Rusty Shovel", "542609", 19.99m, 1);
        Product product2 = new Product("Toothbrush", "3478", 3.49m, 9);
        Product product3 = new Product("Haunted Claymore", "634570", 99.99m, 1);

        Address address1 = new Address("123 Gravel Lane", "Teufort", "New Mexico", "USA");
        Customer customer1 = new Customer("Jane Doe", address1);
        List<Product> products = new List<Product>();
        products.Add(product1);
        products.Add(product2);
        Order order = new Order(customer1, products);

        Address address2 = new Address("756 Smissmas Drive", "Edinburg", "Scotland", "Great Britain");
        Customer customer2 = new Customer("Tavish DeGroot", address2);
        List<Product> productB = new List<Product>();
        products.Add(product3);
        Order order2 = new Order(customer2, productB);

        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order.CreatePackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order.CreateShippingLabel());
        Console.WriteLine("Total Cost: $" + order.GetTotalCost().ToString("0.00"));

        /*Console.WriteLine("Packing Label: ");
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order2.CreateShippingLabel());
        Console.WriteLine("Total Cost: $" + order.GetTotalCost().ToString("0.00"));
        */
    }
}