public class Product
{
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, int id, decimal price, int quantity)
    {
        Name = name;
        Id = id;
        Price = price;
        Quantity = quantity;
    }
}