namespace learnDesignPatters;

public interface IDiscount
{
    double Discount(Budgets budgets);

    IDiscount Next { get; set; }
}