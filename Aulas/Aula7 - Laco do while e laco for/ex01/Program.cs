using System;

class Program
{
    /* Crie um programa que some os numeros impares digitados até que o somatorio
    deles seja maior que o 50 (números pares não devem entrar no somatório)*/
    static void Main(string[] args)
    {
        const int VALOR_MAXIMO = 50;
        double somatorio = 0;
        double valorDigitado = 0;

        do
        {
            System.Console.WriteLine("Digite um valor impar p/ o somatório: ");
            valorDigitado = double.Parse(Console.ReadLine());
            if (valorDigitado % 2 == 1)
            {
                somatorio = somatorio + valorDigitado;
            }
        }
        while (somatorio <= VALOR_MAXIMO);

        System.Console.WriteLine("O valor do somatório foi: " + somatorio);
    }
}