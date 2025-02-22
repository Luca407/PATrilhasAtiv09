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

    public double CalcularArea() => Largura * Altura;
    public double CalcularPerimetro() => 2 * (Largura + Altura);
}
