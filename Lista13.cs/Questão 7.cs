using System;
using System.Collections.Generic;

// Exercício 7: Classe Conta Bancária
class ContaBancaria
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

    // Método para verificar saldo
    public void VerSaldo()
    {
        Console.Write("Digite o número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());
        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine();

        if (Autenticar(numeroConta, senha))
        {
            Console.WriteLine("Saldo da conta " + numeroConta + ": " + contas[numeroConta].Item1);
        }
        else
        {
            Console.WriteLine("Autenticação falhou!");
        }
    }
}

// Função Main para testar a classe ContaBancaria
class Program
{
    static void Main()
    {
        ContaBancaria banco = new ContaBancaria();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n1. Abrir Conta");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Sacar");
            Console.WriteLine("4. Ver Saldo");
            Console.WriteLine("5. Fechar Conta");
            Console.WriteLine("6. Sair");
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
                    banco.VerSaldo();
                    break;
                case 5:
                    banco.FecharConta();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
