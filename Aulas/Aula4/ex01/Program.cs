using System;

class Program
{

    /*
        Exercício: Crie um programa que Receba o sexo
        e a idade de uma pessoa. Se o sexo for igual a
        "feminino" e a idade igual a 15, o programa deve
        exibir a mensagem "Festa de debutante: True". Caso
        contrário deve exibir a mensagem 
        "Festa de debutante: False".
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o sexo (feminino/masculino): ");
        string sexo = Console.ReadLine();

        bool ehFeminoEhIdadeIgual15 = (idade == 15) && (sexo == "feminino");

        Console.WriteLine("Festa de debutante: " + ehFeminoEhIdadeIgual15);
    }
}