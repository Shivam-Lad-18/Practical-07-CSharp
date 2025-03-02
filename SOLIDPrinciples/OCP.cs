public interface IDiscountStrategy
{
    double ApplyDiscount(double totalAmount);
}

public class RegularCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double totalAmount)
    {
        return totalAmount * 0.05; // 5% discount
    }
}
public class PremiumCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double totalAmount)
    {
        return totalAmount * 0.10; // 10% discount
    }
}
public class GoldCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double totalAmount)
    {
        return totalAmount * 0.15; // 15% discount
    }
}
public class DiscountCalculator
{
    private readonly IDiscountStrategy _discountStrategy;

    public DiscountCalculator(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public double CalculateDiscount(double totalAmount)
    {
        return _discountStrategy.ApplyDiscount(totalAmount);
    }
}

