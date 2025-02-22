using System;

class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public double CalcularArea() 
    {
        return Largura * Altura;
    }
    
    public double CalcularPerimetro() 
    {
        return 2 * (Largura + Altura);
    }
    
    static void Main()
    {
        // Testando a classe Retangulo
        Retangulo ret = new Retangulo(5, 10);
        Console.WriteLine("Área do retângulo: " + ret.CalcularArea());
        Console.WriteLine("Perímetro do retângulo: " + ret.CalcularPerimetro());
        Console.ReadKey();
    }
}
