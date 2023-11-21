namespace learnDesignPatters;

public class Item
{
    public string Nome { get; set; }
    public double Value { get; set; }

    public Item(string nome, double value)
    {
        Nome = nome;
        Value = value;
    }
}