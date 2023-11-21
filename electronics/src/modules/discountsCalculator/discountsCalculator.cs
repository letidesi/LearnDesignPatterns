namespace learnDesignPatters;

public class DiscountsCalculator
{
    public double Calculate(Budgets budgets)
    {
        IDiscount firstDiscount = new DiscountsForFiveItens();
        IDiscount secondDiscount = new DiscountsForTenItens();

        firstDiscount.Next = secondDiscount;

        return firstDiscount.Discount(budgets);
    }
}