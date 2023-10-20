using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();
int num1 = 2;
int num2 = 2;

Console.WriteLine($"{num1} + {num2} = {c.somar(num1, num2)}");