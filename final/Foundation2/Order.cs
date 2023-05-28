public class Order
{
    private List<Product> products;
    private Customer customer;
    private decimal ShippingCost = 0.0m;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;

        if (customer.Address.IsInUSA())
        {
            ShippingCost = 5.0m;
        }

        else
        {
            ShippingCost = 35.0m;
        }
    }
    public decimal GetTotalCost()
    {
        decimal totalCost = 0.0m;

        foreach (Product product in products)
        {
            totalCost += product.Price * product.Quantity;
        }
        totalCost += ShippingCost;
        return totalCost;
    }
    public string CreateShippingLabel()
    {
        string label = "";

        foreach (Product product in products)
        {
            label = customer.Name + "\n" +
            customer.Address.ToString() + "\n";
        }
        return label;
    }

    public string CreatePackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += "Product name: " + product.Name + "\n" +
            "Product ID: " + product.ProductID + "\n";

        }
        return label;
    }
}