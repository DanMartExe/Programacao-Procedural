using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ditite a base do triangulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ditite a altura do triangulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        bool ehMaiorQue20 = areaTriangulo > 20;

        Console.WriteLine("A area do triangulo eh maior que 20? " + ehMaiorQue20);
    }
}