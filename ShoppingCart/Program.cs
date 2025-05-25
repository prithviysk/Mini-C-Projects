namespace ShoppingCart;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("### Simplified Online Shopping System ###");
        
        Console.WriteLine("\n--- Creating Products ---");
        Book book1 = new Book("Andy Weir", "46635-23777-09885", "Lord of the Rings", "978-0804139021",15.99);
        Electronics laptop1 = new Electronics("E001", 12, "Dell", "978-088938823", 1200.00);
        Apparel shirt1 = new Apparel("M", "T-Shirt", "Zara", "Large", 120.00);
        Electronics headphones1 = new Electronics("Sony", 18, "WZ004", "775-783777509", 350);
        // Book book2 = new Book("B002", "Dune", 12.50, "Frank Herbert", "978-0441172719");
        
        Console.WriteLine("\n--- Available Products ---");
        book1.DisplayDetails();
        Console.WriteLine($"Description: {book1.GetDescription()}\n");
        laptop1.DisplayDetails();
        Console.WriteLine($"Description: {laptop1.GetDescription()}\n");
        shirt1.DisplayDetails();
        Console.WriteLine($"Description: {shirt1.GetDescription()}\n");
        
        ShoppingCart userCart = new ShoppingCart("CART001", "CUST001");
        
        userCart.AddItem(book1, 2);
        userCart.AddItem(laptop1, 1);
        userCart.AddItem(shirt1, 3);
        userCart.AddItem(headphones1, 1);
        
        userCart.DisplayCart();
        
        Console.WriteLine("\n--- Applying Discounts ---");
        var headPhonesInCart = userCart.GetCartItems().FirstOrDefault(item=>item.Product.ProductId == "775-783777509");

        if (headPhonesInCart != null && headPhonesInCart.Product is IDiscountable discountableProduct)
        {
            discountableProduct.ApplyDiscount(10);
        }
        else
        {
            Console.WriteLine("Headphones not found in cart or not discountable.");
        }
        
        userCart.DisplayCart();
        
        Console.WriteLine("\n--- Checking Out Cart ---");
        Orders customerOrder = new Orders("ORD001", userCart.CustomerId, userCart.GetCartItems());
        
        customerOrder.DisplayOrderSummary();
        
        customerOrder.UpdateStatus("Shipped");
        customerOrder.DisplayOrderSummary();
        
        Console.WriteLine("\n### End of Shopping System Demonstration ###");
    }
}