using System;
using System.Linq;

class Program
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        string id = GerarId();
        Console.WriteLine("ID: " + id);
    }

    static string GerarId()
    {
        string[] partes = new string[4];
        for (int i = 0; i < partes.Length; i++)
        {
            partes[i] = GerarAlfanumerico(4);
        }
        return string.Join("-", partes);
    }

    static string GerarAlfanumerico(int tamanho)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        return new string(Enumerable.Range(0, tamanho)
            .Select(_ => chars[random.Next(chars.Length)]).ToArray());
    }
}