using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_JOGADORES = 5;
        double somatorioAltura = 0;
        double maiorAltura = 0;

        for (int i = 1; i <= NUMERO_JOGADORES; i++)
        {
            Console.WriteLine("Digite a altura do " + i + "° jogador: ");
            double alturaJogadorAtual = double.Parse(Console.ReadLine());

            somatorioAltura = somatorioAltura + alturaJogadorAtual;
            if (alturaJogadorAtual > maiorAltura)
            {
                maiorAltura = alturaJogadorAtual;
            }
        }

        double alturaMediaDoTime = somatorioAltura / NUMERO_JOGADORES;

        Console.WriteLine("A media de altura do time eh: " + Math.Round(alturaMediaDoTime, 2) + "m");
        Console.WriteLine("A pessoa com a maior altura mede: " + Math.Round(maiorAltura, 2) + "m");
    }
}