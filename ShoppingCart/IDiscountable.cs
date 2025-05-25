namespace ShoppingCart;

public interface IDiscountable
{
    double ApplyDiscount(double percentage);

    double DiscountAmount { get; }
}