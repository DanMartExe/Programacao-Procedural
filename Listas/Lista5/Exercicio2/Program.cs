using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_TABUADA = 10;
        const int QUANTIDADE_TABUADAS = 10;

        for (int indiceTabuada = QUANTIDADE_TABUADAS; indiceTabuada >= 1; indiceTabuada--)
        {
            for (int multiplicador = 1; multiplicador <= TAMANHO_TABUADA; multiplicador++)
            {
                Console.WriteLine($"{indiceTabuada} X {multiplicador} = {indiceTabuada * multiplicador}");
            }
            Console.WriteLine();
        }
    }
}