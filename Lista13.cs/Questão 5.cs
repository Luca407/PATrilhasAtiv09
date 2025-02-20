
using System;


class Livro
{
	public string Titulo {get;set;}
	public string Autor {get;set;}
	public bool Disponivel {get; private set;}
	
	public Livro(string titulo, string autor)
	{
		Titulo = titulo;
		Autor = autor;
		Disponivel = true;
	}
	
	 public bool EstaDisponivel()
    {
        return Disponivel;
    }

    public bool RealizarEmprestimo()
    {
        if (Disponivel)
        {
            Disponivel = false;
            return true;
        }
        return false;
    }
	public void DevolverLivro()
    {
        Disponivel = true;
    }

    // Método para exibir informações do livro
    public void ExibirInformacoes()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Disponível: " + (Disponivel ? "Sim" : "Não"));
    }
}

// Exemplo de uso
class Program
{
    static void Main()
    {
        Console.Write("Digite o título do livro: ");
        string titulo = Console.ReadLine();
        
        Console.Write("Digite o autor do livro: ");
        string autor = Console.ReadLine();
        
        Livro livro = new Livro(titulo, autor);
        livro.ExibirInformacoes();
        
        Console.WriteLine("\nDeseja realizar um empréstimo? (s/n)");
        if (Console.ReadLine().ToLower() == "s")
        {
            if (livro.RealizarEmprestimo())
            {
                Console.WriteLine("Empréstimo realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("O livro não está disponível para empréstimo.");
            }
        }
        
        livro.ExibirInformacoes();
        
        Console.WriteLine("\nDeseja devolver o livro? (s/n)");
        if (Console.ReadLine().ToLower() == "s")
        {
            livro.DevolverLivro();
            Console.WriteLine("Livro devolvido com sucesso.");
        }
        
        livro.ExibirInformacoes();
        Console.ReadKey();
    }
}
