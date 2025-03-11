// An interface to calculate discount based on customer type
public interface IDiscountStrategy
{
    double ApplyDiscount(double totalAmount);
}
// Different discount strategies
// Regular customer discount
public class RegularCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double totalAmount)
    {
        return totalAmount * 0.05; // 5% discount
    }
}
// Premium customer discount
public class PremiumCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double totalAmount)
    {
        return totalAmount * 0.10; // 10% discount
    }
}
// Gold customer discount
public class GoldCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double totalAmount)
    {
        return totalAmount * 0.15; // 15% discount
    }
}
// Discount calculator class
public class DiscountCalculator
{
    // Creating object with refrence of IDiscountStrategy so that It can be used for any type of discount strategy
    private readonly IDiscountStrategy _discountStrategy;
    // Constructor to set discount strategy
    public DiscountCalculator(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }
    // Method to calculate discount
    public double CalculateDiscount(double totalAmount)
    {
        return _discountStrategy.ApplyDiscount(totalAmount);
    }
}

