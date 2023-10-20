using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        int num1 = 5;
        int num2 = 10;
        int resultado = _calc.somar(num1, num2);
        Assert.Equal(15, resultado);
    }
    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        int num1 = 10;
        int num2 = 10;
        int resultado = _calc.somar(num1, num2);
        Assert.Equal(20, resultado);
    }
    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        int num = 4;
        bool resultado = _calc.EhPar(num);
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParERetornarVerdadeiro(int[] numeros)
    {
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}