using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int soma = 0;

        foreach (int num in numeros)
        {
        	soma += num;
        }
        double media = (double)soma / numeros.Length;
        
        Console.WriteLine("A média dos numeros é: " + media);
        Console.ReadKey();
    }
}
