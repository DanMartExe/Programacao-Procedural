using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a tabuada que gostaria de consultar: ");
        int valorRecebido = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(valorRecebido + " X " + i + " = " + (valorRecebido * i));
        }
    }
}