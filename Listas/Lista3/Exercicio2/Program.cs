using System;

class Program
{
    static void Main(string[] args)
    {
        const double META_PROMOCIONAL = 150.00;
        double somatorioValorItens = 0;

        Console.WriteLine("Digite a quantidade de itens comprados: ");
        int quantidadeItens = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite os valores dos " + quantidadeItens + " itens");

        while (quantidadeItens > 0)
        {
            double valorItem = double.Parse(Console.ReadLine());

            somatorioValorItens = somatorioValorItens + valorItem;
            quantidadeItens--;
        }

        if (somatorioValorItens > META_PROMOCIONAL)
        {
            Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra de valor " +
            somatorioValorItens + " R$");
        }
        else
        {
            Console.WriteLine("A compra nao possui frete gratis");
        }
    }
}