using System;

/*
Exercicio: O pai de um rapaz deu a ele um cartão de vale presente
com saldo de 200.00 reais. Crie um programa que valide se o presente
comprado pelo menino ultrapassa o saldo do vale presente. Se ultrapassar
o programa deve exibir a mensagem "Saldo insuficiente para realizar a compra".
Caso contrário, deve ser exibida a mensagem "Compra realizada com sucesso"
*/

class Program
{
    static void Main(string[] args)
    {
        const double saldo = 200;

        Console.WriteLine("Digite o valor do item que deseja comprar: ");
        double valorDoItem = double.Parse(Console.ReadLine());

        if (valorDoItem <= saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar a compra");
        }
        else
        {
            Console.WriteLine("Compra realizada com sucesso");
        }
    }
}