using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de moedas de um centavo: ");
        int quantidadeDeMoedas = int.Parse(Console.ReadLine());

        int real = quantidadeDeMoedas / 100;
        int centavo = quantidadeDeMoedas % 100;

        Console.WriteLine("O total em dinheiro eh: " + real + " real(is) e " + centavo + " centavo(s)");
    }
}