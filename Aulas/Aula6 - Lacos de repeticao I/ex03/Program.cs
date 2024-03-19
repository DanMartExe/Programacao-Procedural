using System;

class Program
{
    static void Main(string[] args)
    {
        double somatorio = 0;
        string resposta = "s";

        while (resposta == "s")
        {
            System.Console.WriteLine("Digite o valor que deseja doar: ");
            double valorDigitado = double.Parse(Console.ReadLine());
            somatorio = somatorio + valorDigitado;
            System.Console.WriteLine("A vaquinha arrecadou " + somatorio + " R$ ate agora");
            System.Console.WriteLine("Deseja continuar?\n[s] = sim\n[n] - nao");
            resposta = Console.ReadLine();
        }
        System.Console.WriteLine("Fechamos a vaquinha, e o valor arrecadado foi: " + somatorio +" R$");
    }
}