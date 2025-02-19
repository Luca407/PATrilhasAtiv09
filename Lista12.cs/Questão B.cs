using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string> { "Alice", "Bob", "Carlos", "Diana" };

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        Console.ReadKey();
    }
}
