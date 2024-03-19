using System;

/*
Exercício: Crie um programa que receba um numero inteiro do usuario.
Seu programa deve ser capaz de verificar se o numero eh par e,
caso seja, imprimir a mensagem "O numero eh par"
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O numero eh par");
        }
        else
        {
            Console.WriteLine("O numero eh impar");
        }
    }
}