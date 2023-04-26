using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        object[] matriz = new object[] { "a", 10, "b", "hola", 122, 15 };

        // a)
        var letras = new List<string>();
        foreach (object item in matriz)
        {
            if (item is string)
            {
                letras.Add((string)item);
            }
        }
        Console.WriteLine("Letras: [" + string.Join(", ", letras) + "]");

        // b)
        var numeros = new List<int>();
        foreach (object item in matriz)
        {
            if (item is int)
            {
                numeros.Add((int)item);
            }
        }
        Console.WriteLine("Números: [" + string.Join(", ", numeros) + "]");

        // c)
        int maiorNumero = matriz.OfType<int>().Max();
        Console.WriteLine("Maior número: " + maiorNumero);
    }
}
