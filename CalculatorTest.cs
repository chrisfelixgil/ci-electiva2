using Xunit;
using easy_calculator;

public class CalculatorTest
{

    private readonly Calculator _calculator;

    public CalculatorTest()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Sumar_DosNumeros_RetornarResultadoCorrecto()
    {
        int resultado = _calculator.Sumar(3, 5);
        Assert.Equal(8, resultado);
    }
}