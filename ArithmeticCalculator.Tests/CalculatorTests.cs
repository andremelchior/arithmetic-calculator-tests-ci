using ArithmeticCalculator;

namespace ArithmeticCalculator.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        this._calculator = new Calculator();
    }

    [Fact]
    public void Sum_ShouldReturnCorrectResult()
    {
        double n1 = 3;
        double n2 = 2;

        var result = this._calculator.Sum(n1, n2);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtration_ShouldReturnCorrectResult()
    {
        double n1 = 3;
        double n2 = 3;

        var result = this._calculator.Subtration(n1, n2);

        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiplication_ShouldReturnCorrectResult()
    {
        double n1 = 2;
        double n2 = 2;

        var result = this._calculator.Multiplication(n1, n2);

        Assert.Equal(4, result);
    }

    [Fact]
    public void Division_ShouldReturnCorrectResult()
    {
        double n1 = 4;
        double n2 = 2;

        var result = this._calculator.Division(n1, n2);

        Assert.Equal(2, result);
    }
}
