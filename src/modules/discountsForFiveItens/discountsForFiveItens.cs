namespace learnDesignPatters;

public class DiscountsForFiveItens : IDiscount
{
    public IDiscount? Next { get; set; }

    public double Discount(Budgets budgets)
    {
        if (budgets.Itens.Count >= 500)
            return budgets.Value * 0.1;

        return Next.Discount(budgets);
    }
}