using System;

class Produto
{
	public string Nome {get;set;}
	public decimal PrecoUnitario {get;set;}
	public int Quantidade {get; set;}
	
	public Produto (string nome, decimal precoUnitario, int quantidade )
	{
		Nome = nome;
		PrecoUnitario = precoUnitario;
		Quantidade = quantidade;
	}
	public decimal CalcularValorTotal(){
		return PrecoUnitario*Quantidade;
	}
	public void ExibirInfo()
	{
		Console.WriteLine("Produto: " + Nome);
		Console.WriteLine("Preço Unitário: " + PrecoUnitario);
		Console.WriteLine("Quantidade: " + Quantidade);
		Console.WriteLine("Valor Total: " + CalcularValorTotal());
		Console.ReadKey();
		
	}
}
class Program
{
    static void Main()
    {
        Produto produto = new Produto("Notebook", 3500.00m, 2);
        produto.ExibirInfo();
        Console.ReadKey();
    }
}
