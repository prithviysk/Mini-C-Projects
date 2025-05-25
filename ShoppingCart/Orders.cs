namespace ShoppingCart;

public class Orders
{
    public string OrderId { get; private set; }
    public DateTime OrderDate { get; private set; }
    public string CustomerId { get; private set; }
    public double TotalAmount { get; private set; }
    public string OrderStatus { get; private set; }
    
    private List<ShoppingCartItem> _orderItems;

    public Orders(string orderId, string customerId, List<ShoppingCartItem> cartItems)
    {
        OrderId = orderId;
        OrderDate = DateTime.Now;
        CustomerId = customerId;
        OrderStatus = "Pending";
        
        _orderItems = new List<ShoppingCartItem>(cartItems);

        TotalAmount = _orderItems.Sum(item => item.GetSubTotal());
        Console.WriteLine(
            $"\nOrder {OrderId} created for customer {CustomerId} on {OrderDate}. Total: ${TotalAmount:F2}");
    }

    public void UpdateStatus(string status)
    {
        OrderStatus = status;
        Console.WriteLine($"Order {OrderId} status updated to: {OrderStatus}");
    }
    
    public void DisplayOrderSummary()
    {
        Console.WriteLine($"\n--- Order Summary: {OrderId} ---");
        Console.WriteLine($"  Customer ID: {CustomerId}");
        Console.WriteLine($"  Order Date: {OrderDate}");
        Console.WriteLine($"  Status: {OrderStatus}");
        Console.WriteLine($"  Total Amount: ${TotalAmount:F2}");
        Console.WriteLine("  Items:");
        foreach (var item in _orderItems)
        {
            item.DisplayItemDetails();
        }
        Console.WriteLine("----------------------------------");
    }
}