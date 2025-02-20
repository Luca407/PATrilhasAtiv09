using System;
using System.Collections.Generic;

class Banco
{
    private Dictionary<int, Tuple<double, string>> contas = new Dictionary<int, Tuple<double, string>>();
    
    // Método para abrir uma conta com senha
    public void AbrirConta()
    {
        Console.Write("Digite o número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());
        Console.Write("Crie uma senha: ");
        string senha = Console.ReadLine();
        
        if (!contas.ContainsKey(numeroConta))
        {
            contas[numeroConta] = new Tuple<double, string>(0, senha);
            Console.WriteLine("Conta " + numeroConta + " aberta com sucesso.");
        }
        else
        {
            Console.WriteLine("Conta já existe!");
        }
    }

    // Método para autenticação
    private bool Autenticar(int numeroConta, string senha)
    {
        return contas.ContainsKey(numeroConta) && contas[numeroConta].Item2 == senha;
    }

    // Método para fechar uma conta
    public void FecharConta()
    {
        Console.Write("Digite o número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());
        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine();

        if (Autenticar(numeroConta, senha))
        {
            contas.Remove(numeroConta);
            Console.WriteLine("Conta " + numeroConta + " fechada com sucesso.");
        }
        else
        {
            Console.WriteLine("Autenticação falhou!");
        }
    }

    // Método para depósito
    public void Depositar()
    {
        Console.Write("Digite o número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor do depósito: ");
        double valor = double.Parse(Console.ReadLine());
        
        if (contas.ContainsKey(numeroConta))
        {
            double saldoAtual = contas[numeroConta].Item1;
            string senha = contas[numeroConta].Item2;
            contas[numeroConta] = new Tuple<double, string>(saldoAtual + valor, senha);
            Console.WriteLine("Depósito de " + valor + " realizado na conta " + numeroConta);
        }
        else
        {
            Console.WriteLine("Conta não encontrada!");
        }
    }

    // Método para saque
    public void Sacar()
    {
        Console.Write("Digite o número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());
        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine();
        Console.Write("Digite o valor do saque: ");
        double valor = double.Parse(Console.ReadLine());

        if (Autenticar(numeroConta, senha))
        {
            double saldoAtual = contas[numeroConta].Item1;
            if (saldoAtual >= valor)
            {
                contas[numeroConta] = new Tuple<double, string>(saldoAtual - valor, senha);
                Console.WriteLine("Saque de " + valor + " realizado na conta " + numeroConta);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        else
        {
            Console.WriteLine("Autenticação falhou!");
        }
    }

    static void Main()
    {
        Banco banco = new Banco();
        
        while (true)
        {
            Console.WriteLine("\n1. Abrir Conta");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Sacar");
            Console.WriteLine("4. Fechar Conta");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            
            int opcao = int.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    banco.AbrirConta();
                    break;
                case 2:
                    banco.Depositar();
                    break;
                case 3:
                    banco.Sacar();
                    break;
                case 4:
                    banco.FecharConta();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
