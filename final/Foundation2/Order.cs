public class Order
{
    public Customer customer { get; set; }
    public List<Product> products { get; set; }

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public decimal Total()
    {
        decimal total = 0.0m;

        foreach (Product product in products)
        {
            total += product.Price * product.Quantity;
        }

        return total;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Packing label:");
        Console.WriteLine(customer.address.FullAddress());
    }

    public void ShippingLabel()
    {
        Console.WriteLine("Shipping label:");
        Console.WriteLine(customer.name);
        Console.WriteLine(customer.address.FullAddress());

        if (customer.address.IsInUSA())
        {
            Console.WriteLine("Shipping fee: $5.00");
        }
        else if (customer.address.IsNotInUSA)
        {
            Console.WriteLine("Shipping fee: $35.00");
        }
    }
}