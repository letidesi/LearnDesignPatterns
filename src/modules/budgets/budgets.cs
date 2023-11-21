namespace learnDesignPatters;

public class Budgets
{
    public double Value { get; set; }
    public IList<Item> Itens { get; set; }

    public Budgets(double value)
    {
        Value = value;
        Itens = new List<Item>();
    }

    public void AdicionaItem(Item item)
    {
        Itens.Add(item);
    }
}