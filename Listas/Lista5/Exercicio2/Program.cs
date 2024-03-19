using System;

class Program
{
    static void Main(string[] args)
    {
        for (int indiceTabuada = 10; indiceTabuada >= 1; indiceTabuada--)
        {
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                Console.WriteLine($"{indiceTabuada} X {multiplicador} = {indiceTabuada * multiplicador}");
            }
            Console.WriteLine();
        }
    }
}