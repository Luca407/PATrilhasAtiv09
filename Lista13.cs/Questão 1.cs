using System;

class Calculadora
{
    // Método para soma
    public double Somar(double a, double b)
    {
        return a + b;
    }

    // Método para subtração
    public double Subtrair(double a, double b)
    {
        return a - b;
    }

    // Método para multiplicação
    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    // Método para divisão com verificação para evitar divisão por zero
    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: Não é possivel dividir por zero!");
            return double.NaN; // Retorna Not a Number (NaN)
        }
        return a / b;
    }

    static void Main()
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("Digite dois valores: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("\nSoma: " + calc.Somar(a, b));
        Console.WriteLine("Subtração: " + calc.Subtrair(a, b));
        Console.WriteLine("Multiplicação: " + calc.Multiplicar(a, b));
        Console.WriteLine("Divisão: " + calc.Dividir(a, b));
        Console.ReadKey();
    }
}
