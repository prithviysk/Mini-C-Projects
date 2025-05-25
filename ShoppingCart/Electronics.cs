namespace ShoppingCart;

public class Electronics : Product, IDiscountable
{
    public string Brand { get; private set; }
    public int Warranty { get; private set; }
    private double _discountAmount;
    
    public double DiscountAmount
    {
        get { return _discountAmount; }
        private set { _discountAmount = value; }
    }

    public Electronics(string brand, int warranty, string productName, string productId, double productPrice) : base(
        productName,
        productId, productPrice)
    {
        Brand = brand;
        Warranty = warranty;
        _discountAmount = 0;
    }

    public override string GetDescription()
    {
        return $"Electronics from {Brand}: {ProductName} (Warranty: {Warranty} months)";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"  Brand: {Brand}");
        Console.WriteLine($"  Warranty: {Warranty} months");
        if (DiscountAmount > 0)
        {
            Console.WriteLine($"  Discount Applied: ${DiscountAmount:F2}");
            Console.WriteLine($"  Price After Discount: ${ProductPrice:F2}");
        }
    }
    
    public double ApplyDiscount(double percentage)
    {
        if (percentage < 0 || percentage > 100)
        {
            Console.WriteLine("Invalid discount percentage.");
            return ProductPrice;
        }
        
        DiscountAmount = ProductPrice * (percentage / 100.0);
        ProductPrice -= DiscountAmount;
        Console.WriteLine($"  Applied {percentage}% discount to {ProductName}. New Price: ${ProductPrice:F2}");
        return ProductPrice;
    }
}