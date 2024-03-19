using System;
using System.IO.Pipes;
using System.Reflection;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
//Crie um programa que receba o nome da rua e o número
// do cep de uma pessoa e imprima ao final "rua:"
// + rua + ", cep: " + cep

        Console.WriteLine("Digite o nome da rua: ");
        string rua = Console.ReadLine();

        Console.WriteLine("Digite o CEP: ");
        string cep = Console.ReadLine(); //int/string apenas se for pra calculo, string é mais flexível - podendo colocar até traço, etc...
        
        Console.WriteLine("Rua: " + rua + ", cep: " + cep);

//Crie um programa que receba o peso e altura de uma
//pessoa, calcule e exiba o imc dessa pessoa 
//(IMC = peso / altura*altura).
        
        Console.WriteLine("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua altura: ");
        double altura = double.Parse(Console.ReadLine());
        
        double imc = peso / (altura * altura);

        Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2));

//Crie um programa que receba uma quantidade de dias
//e converta em anos. Ao final o programa deve
//apresentar a mensagem "O total deu " + anos +
//"anos e "+ dias + " dias"

        Console.WriteLine("Digite o numero de dias que deseja converter: ");
        int diasIniciais = int.Parse(Console.ReadLine());

        int anos = diasIniciais / 365;
        int dias = diasIniciais % 365;

        Console.WriteLine("O total deu " + anos + "anos e " + dias + "dias");
    }
}