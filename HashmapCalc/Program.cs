using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var operacoes = new Dictionary<string, Func<double[], double>>();
        operacoes["+"] = nums => nums.Sum();
        operacoes["-"] = nums => nums.Aggregate((x, y) => x - y);
        operacoes["*"] = nums => nums.Aggregate((x, y) => x * y);
        operacoes["/"] = nums => {
            if (nums[1] == 0)
            {
                throw new ArgumentException("O segundo número não pode ser zero.");
            }
            return nums.Aggregate((x, y) => x / y);
        };

        double[] numeros = new double[] { 2, 3, 4 };
        Console.WriteLine("Soma: " + operacoes["+"](numeros));
        Console.WriteLine("Subtração: " + operacoes["-"](numeros));
        Console.WriteLine("Multiplicação: " + operacoes["*"](numeros));
        Console.WriteLine("Divisão: " + operacoes["/"](new double[] { 10, 2 }));
    }
}
