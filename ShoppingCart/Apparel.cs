namespace ShoppingCart;

public class Apparel : Product
{
    public string Size { get; private set; }
    public string Material { get; private set; }

    public Apparel(string size, string material, string productName, string productId, double productPrice) : base(
        productName,
        productId, productPrice)
    {
        Size = size;
        Material = material;
    }

    public override string GetDescription()
    {
        return $"{Size} {Material} {ProductName}";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"  Size: {Size}");
        Console.WriteLine($"  Material: {Material}");
    }
}