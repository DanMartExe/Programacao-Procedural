using System;

class Program
{
    // tipo da variavel - nome - valor (criando variável)
    // nome - valor (reutilizando, ao utilizar o mesmo nome)
    //Exercício: crie um programa que peça para uma pessoa digitar seu nome e salário, armazene em variáveis e ao final imprima a mensagem "Seu nome é " + nome + "Seu salário é: " + salário
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu salario: ");
        double salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Seu nome é " + nome + " e seu salário é: " + salario);
    }
}

//int idade = 17;
//long numeroDeEstrelasNaGalaxia = 40000000;
//double altura = 1,78;
//char sexo = 'M';
//bool casado = false;
// primitivo é o atomo da programação
// int idade = int.Parse("17"); Parse converte texto em num/dado
// double altura = double.Parse("1,80");
// int idade = int.Parse(Console.ReadLine());