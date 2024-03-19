using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite um numero: ");
        int numero1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite outro numero: ");
        int numero2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("A soma dos numeros eh: " + (numero1 + numero2));
    }
}