using System;

/*
Exercicio: Crie um programa que receba a idade de três pessoas e verifique qual
a maior das três idades. Ao final seu programa deve imprimir a mensagem "A maior
das três idades é: x"
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a idadade da primeira pessoa: ");
        int idadePessoa1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a idadade da segunda pessoa: ");
        int idadePessoa2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a idadade da terceira pessoa: ");
        int idadePessoa3 = int.Parse(Console.ReadLine());

        if (idadePessoa1 >= idadePessoa2 && idadePessoa1 >= idadePessoa3)
        {
            Console.WriteLine("A maior das três idades é: " + idadePessoa1);
        }
        else if (idadePessoa2 >= idadePessoa1 && idadePessoa2 >= idadePessoa3)
        {
            Console.WriteLine("A maior das três idades é: " + idadePessoa2);
        }
        else
        {
            Console.WriteLine("A maior das três idades é: " + idadePessoa3);
        }
    }
}