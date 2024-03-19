using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        const double valorBoleto = 100;
        string statusBoleto = Console.ReadLine();
        // ternário                                                  else
        double valorFinal = (statusBoleto != "vencido") ? valorBoleto : valorBoleto + (valorBoleto * 0.15);

        System.Console.WriteLine("O valor final eh: " + valorFinal);
    }
}