using learnDesignPatters;

namespace LearnDesignPatterns;

public class CalculateCreateTest
{
    [Fact]
    public void Calculate()
    {
        // Arrange

        DiscountsCalculator calculator = new DiscountsCalculator();

        var budgets = new Budgets(value: 500);

        var firstItem = new Item(nome: "Impressora", value: 500);
        var secondItem = new Item(nome: "Computador", value: 2600);
        var thirdItem = new Item(nome: "Celular", value: 700);

        budgets.AdicionaItem(firstItem);
        budgets.AdicionaItem(secondItem);
        budgets.AdicionaItem(thirdItem);

        Assert.Collection(budgets.Itens,
            item =>
            {
                Assert.Equal("Impressora", item.Nome);
                Assert.Equal(500, item.Value);
            },
            item =>
            {
                Assert.Equal("Computador", item.Nome);
                Assert.Equal(2600, item.Value);
            },
            item =>
            {
                Assert.Equal("Celular", item.Nome);
                Assert.Equal(700, item.Value);
            });

        // Act
        double result = calculator.Calculate(budgets);

        // Assert 
        Assert.Equal(100, result);

    }
}