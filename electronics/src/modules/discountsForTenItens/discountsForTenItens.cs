namespace learnDesignPatters;

public class DiscountsForTenItens : IDiscount
{
    public IDiscount? Next { get; set; }

    public double Discount(Budgets budgets)
    {
        if (budgets.Itens.Count > 700)
            return budgets.Value * 0.2;

        return Next.Discount(budgets);
    }
}