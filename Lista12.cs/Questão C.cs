using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int maior = numeros[0];
        

        foreach (int num in numeros)
        {
        	if (num > maior)
        	{
        		maior = num;
        	}
        }
        Console.WriteLine("O maior numero é: " + maior);
        Console.ReadKey();
    }
}
