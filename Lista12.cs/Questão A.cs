using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };

        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
        
        Console.ReadKey();
    }
}
