using System;

class Program
{
    /*
        Crie um programa que pergunte ao usuário se uma lampada está ligada
        (use uma variável bool). Se a lampada estiver ligada o programa deve
        desligar a lampada e exibir a mensagem "Lampada ligada? False". Se a
        lampada estiver desliagada o programa deve ligar a lampada e exibir a
        mensagem "Lampada ligada? True".
    */
    static void Main(string[] args)
    {
        Console.WriteLine("A lampada esta ligada? (true/false)");
        bool estaLigada = bool.Parse(Console.ReadLine());

        estaLigada = !estaLigada;

        Console.WriteLine("A lampada esta ligada? " + estaLigada);
    }
}