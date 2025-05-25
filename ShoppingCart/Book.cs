namespace ShoppingCart;

public class Book : Product
{
    public string Author { get; private set; }
    public string ISBN { get; private set; }

    public Book(string author, string isbn, string productName, string productId, double productPrice) : base(productName,
        productId, productPrice)
    {
        Author = author;
        ISBN = isbn;
    }

    public override string GetDescription()
    {
        return $"Book by {Author}: \"{ProductName}\" (ISBN: {ISBN})";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"It is by the author {Author} and has the ISBN {ISBN}");
    }
}