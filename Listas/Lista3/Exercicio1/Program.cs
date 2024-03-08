using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_HABITANTES = 20;
        double maiorSalario = 0;
        double somatorioSalarial = 0;
        double somatorioFilhos = 0;

        for(int contador = 1; contador <= NUMERO_HABITANTES; contador++)
        {
            Console.WriteLine("\n" + contador + "° habitante\nDigite seu salario: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de filhos que voce possui: ");
            int numeroDeFilhos = int.Parse(Console.ReadLine());

            somatorioSalarial = somatorioSalarial + salario;
            somatorioFilhos = somatorioFilhos + numeroDeFilhos;

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }
        }

        double mediaFilhos = somatorioFilhos / NUMERO_HABITANTES;
        double mediaSalarial = somatorioSalarial / NUMERO_HABITANTES;

        Console.WriteLine("\nMedia salarial = " + Math.Round(mediaSalarial, 2) +
        " R$\nMedia do numero de filhos por habitante = " + Math.Round(mediaFilhos, 2) +
         "\nMaior salario = " + Math.Round(maiorSalario, 2) + " R$");
    }
}