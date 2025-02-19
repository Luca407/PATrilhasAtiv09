using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> palavras = new List<string> { "Super Sayajin", "Super Sayajin 5", "Super Sayajin 1000", "Super Sayajin Blue", "Super Sayajin Rose", "Instinto Superior Masterizado" };

        string maiorString = palavras[0];

        foreach (string palavra in palavras)
        {
            if (palavra.Length > maiorString.Length)
            {
                maiorString = palavra;
            }
        }

        Console.WriteLine("O mais forte é: " + maiorString);
        Console.ReadKey();
    }
}
