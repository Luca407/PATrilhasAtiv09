using System;

class Aluno
{
    // Propriedades
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }

    // Construtor
    public Aluno(string nome, double nota1, double nota2, double nota3)
    {
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
        Nota3 = nota3;
    }

    // Método para calcular a média das notas
    public double CalcularMedia()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }

    // Método para verificar aprovação
    public string VerificarAprovacao()
    {
        return CalcularMedia() >= 7.0 ? "Aprovado" : "Reprovado";
    }

    // Método para exibir informações do aluno
    public void ExibirInformacoes()
    {
        Console.WriteLine("Aluno: " + Nome);
        Console.WriteLine("Média: " + CalcularMedia().ToString("F2"));
        Console.WriteLine("Status: " + VerificarAprovacao());
        Console.ReadKey();
    }
}

// Exemplo de uso
class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno("João", 8.5, 7.0, 6.5);
        aluno.ExibirInformacoes();
    }
}
