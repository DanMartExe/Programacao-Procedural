using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite as quatro notas do aluno: ");
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        double nota3 = double.Parse(Console.ReadLine());        
        double nota4 = double.Parse(Console.ReadLine());

        double mediaDoAluno = (nota1 + nota2 + nota3 + nota4) / 4.0;

        if (mediaDoAluno >= 5.0)
        {
            System.Console.WriteLine("Aluno aprovado");
        }
        else if (mediaDoAluno >= 3.0)
        {
            System.Console.WriteLine("Aluno em recuperacao");
        }
        else
        {
            System.Console.WriteLine("Aluno reprovado");
        }
    }
}