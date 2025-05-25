namespace ShoppingCart;

public class ShoppingCartItem
{
    public Product Product { get; private set; }
    public int Quantity { get; set; }

    public ShoppingCartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public double GetSubTotal()
    {
        return Product.ProductPrice * Quantity; 
    }
    
    public void DisplayItemDetails()
    {
        Console.WriteLine($"- {Product.ProductName} (ID: {Product.ProductId}) x {Quantity} = ${GetSubTotal():F2}");
    }
}