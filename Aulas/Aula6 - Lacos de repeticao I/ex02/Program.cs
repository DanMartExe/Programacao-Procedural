using System;

class Program
{
    /*Crie um programa que imprima todos os números de 0 a 100*/
    static void Main(string[] args)
    {
        const int VALOR_MAXIMO = 100; //const valor que n se altera
        int contador = 0;               //numero vai ser incrementado

        while (contador <= VALOR_MAXIMO)
        {
            Console.WriteLine(contador);
            contador++;
        }
    //agora 100 até 0
        const int VALOR_MINIMO = 0;

        while (contador >= VALOR_MINIMO)
        {
            Console.WriteLine(contador);
            contador--;
        }
    }
}