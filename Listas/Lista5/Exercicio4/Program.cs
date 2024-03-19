using System;

class Program
{
    static void Main(string[] args)
    {
        int somatorioImpares = 0;
        int numeroDigitado = 0;

        System.Console.WriteLine("Digite numeros inteiros: ");

        do
        {
            numeroDigitado = int.Parse(Console.ReadLine());

            if ((numeroDigitado > 0) && (numeroDigitado % 2 == 1))
            {
                somatorioImpares = somatorioImpares + numeroDigitado;
            }
        }
        while (numeroDigitado >= 0);

        Console.WriteLine($"O somatorio de impares eh: {somatorioImpares}");
    }
}