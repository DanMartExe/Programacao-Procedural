using System;

class Program
{
    static void Main(string[] args)
    {
        const int ALTURA_MINIMA = 1;
        const int ALTURA_MAXIMA = 9;

        Console.WriteLine("Digite a altura do triangulo retangulo, entre " + ALTURA_MINIMA +
        " e " + ALTURA_MAXIMA + ": ");

        do
        {
            int alturaTriangulo = int.Parse(Console.ReadLine());

            if (alturaTriangulo >= ALTURA_MINIMA && alturaTriangulo <= ALTURA_MAXIMA)
            {
                for (int linha = 1; linha <= alturaTriangulo; linha++)
                {
                    for (int comprimento = 1; comprimento <= linha; comprimento++)
                    {
                        Console.Write(comprimento);
                    }
                    Console.WriteLine();
                }
                break;
            }
            else
            {
                Console.WriteLine("altura invalida, insira uma altura entre " + ALTURA_MINIMA +
                " e " + ALTURA_MAXIMA);
            }
        }
        while (true);
    } 
}