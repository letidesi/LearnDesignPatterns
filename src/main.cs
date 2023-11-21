namespace learnDesignPatters;

class Program
{
    static void Main(string[] args)
    {
        DiscountsCalculator calculator = new DiscountsCalculator();

        Budgets budgets = new Budgets(500);

        var firstItem = new Item(nome: "Impressora", value: 500);
        var secondItem = new Item(nome: "Computador", value: 2600);
        var thirdItem = new Item(nome: "Celular", value: 700);

        budgets.AdicionaItem(firstItem);
        budgets.AdicionaItem(secondItem);
        budgets.AdicionaItem(thirdItem);

        double desconto = calculator.Calculate(budgets);
        Console.WriteLine(desconto);
    }
}