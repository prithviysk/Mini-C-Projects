namespace ShoppingCart;

public class ShoppingCart
{
    public string CartId { get; private set; }
    public string CustomerId { get; private set; }
    
    private List<ShoppingCartItem> _items = new List<ShoppingCartItem>();

    public ShoppingCart(string cartId, string customerId)
    {
        CartId = cartId;
        CustomerId = customerId;
        Console.WriteLine($"\nShopping cart {CartId} created for customer {CustomerId}.");
    }

    public void AddItem(Product product, int quantity)
    {
        var existingItem = _items.FirstOrDefault(item => item.Product.ProductId == product.ProductId);

        if (existingItem == null)
        {
            _items.Add(new ShoppingCartItem(product, quantity));
            Console.WriteLine($"Added {quantity} x '{product.ProductName}' to cart.");
        }
        else
        {
            Console.WriteLine($"Item '{product.ProductName}' already in cart");
            existingItem.Quantity += quantity;
        }
    }

    public void RemoveItem(string productId)
    {
        var itemToRemove = _items.FirstOrDefault(item => item.Product.ProductId == productId);
        if (itemToRemove != null)
        {
            _items.Remove(itemToRemove);
            Console.WriteLine($"Removed {itemToRemove.Quantity} x '{itemToRemove.Product.ProductName}' from cart.");
        }
        else
        {
            Console.WriteLine($"Product with ID {productId} not found in cart.");
        }
    }

    public double GetCartTotal()
    {
        return _items.Sum(item => item.GetSubTotal());
    }

    public void DisplayCart()
    {
        Console.WriteLine($"\n--- Shopping Cart {CartId} Contents for Customer {CustomerId} ---");
        if (!_items.Any())
        {
            Console.WriteLine("  Cart is empty.");
            return;
        }
        
        foreach (var item in _items)
        {
            item.DisplayItemDetails();
        }
        Console.WriteLine($"Total: ${GetCartTotal():F2}");
        Console.WriteLine("------------------------------------------");
    }

    public List<ShoppingCartItem> GetCartItems()
    {
        return new List<ShoppingCartItem>(_items);
    }
}