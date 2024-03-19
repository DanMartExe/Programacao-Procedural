using System;

class Program
{
    // Alt + Shift + baixo, copia a linha
    /* Uma famosa ótica criou uma promoção baseada na idade de seus clientes.
    Ela verifica qual a idade da pessoa e desconta do preço do óculos o equivalente
    do valor da idade (em reais). Crie um programa que receba a idade de uma pessoa
    e o preço do óculos que ela deseja comprar. Ao final, seu programa deve exibir
    o preço do óculos descontado do valor da idade.*/

    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite o preço do óculos: (R$)");
        double precoOculos = double.Parse(Console.ReadLine());

        precoOculos = precoOculos - idade;

        System.Console.WriteLine("O preco com desconto eh: " + precoOculos + " R$");
    }
}