public class Product
{
    public string Name {get; set;}
    public string ProductID {get; set;}
    public decimal Price {get; set;}
    public int Quantity {get; set;}

    public Product(string name, string productid, decimal price, int quantity)
    {
        Name = name;
        ProductID = productid;
        Price = price;
        Quantity = quantity;
    }
}