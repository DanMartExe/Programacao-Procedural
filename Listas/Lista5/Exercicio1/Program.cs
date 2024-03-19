using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contadorCrescente = 0, contadorDecrescente = 200; contadorCrescente <= 100; contadorCrescente += 2, contadorDecrescente -= 4)
        {
            Console.WriteLine($"{contadorCrescente} - {contadorDecrescente}");
        }
    }
}