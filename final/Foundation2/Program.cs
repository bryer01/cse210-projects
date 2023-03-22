using System;

public class Program
{
    public static void Main()
    {
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer = new Customer("John Smith", address);
        Order order = new Order(customer);
        Product product1 = new Product("Product 1", 1, 10.00m, 2);
        Product product2 = new Product("Product 2", 2, 20.00m, 1);
        order.products.Add(product1);
        order.products.Add(product2);
        order.PackingLabel();
        order.ShippingLabel();

    }
}
