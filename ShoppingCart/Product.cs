namespace ShoppingCart;

public abstract class Product
{
    public string ProductName { get; private set; }
    public string ProductId { get; private set; }
    public double ProductPrice { get; protected set; }
    
    public Product(string productName, string productId, double productPrice)
    {
        ProductName = productName;
        ProductId = productId;
        ProductPrice = productPrice;
    }

    public abstract string GetDescription();

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"--- Product Details ---");
        Console.WriteLine($"  ID: {ProductId}");
        Console.WriteLine($"  Name: {ProductName}");
        Console.WriteLine($"  Price: ${ProductPrice:F2}");
    }
}