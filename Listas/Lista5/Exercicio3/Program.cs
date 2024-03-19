using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite a altura do retangulo: ");
        int alturaRetangulo = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a base do retangulo: ");
        int baseRetangulo = int.Parse(Console.ReadLine());

        for (int i = 0; i < alturaRetangulo; i++)
        {
            for (int j = 0; j < baseRetangulo; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}