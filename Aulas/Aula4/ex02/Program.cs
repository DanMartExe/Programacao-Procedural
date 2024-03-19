using System;

class Program
{
    /*
        Exemplo: Em um país fictício chamado Xurupita apenas podem
    concorrer à presidência da república pessoas que satisfaçam
    as seguintes condições: Deve ter idade igual ou superior a 30
    anos e ter nacionaldiade Xurupitense. Além disso, deve ser
    graduado em economia ou gestão de políticas públicas.
        Crie um programa que pergunte ao usuário sua idade, sua
        nacionalidade, se é graduado em economiza/gestão de políticas
        públicas. Ao final seu programa deve ser capaz de dizer se essa
        pessoa pode se candidatar à presidência da república de Xurupita.
    */

    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Sua nacionalidade eh xurupitense? (true/false): ");
        bool nacionalidadeXurupitense = bool.Parse(Console.ReadLine());

        Console.WriteLine("Eh graduado em economia? (true/false): ");
        bool graduacaoEmEconomia = bool.Parse(Console.ReadLine());

        Console.WriteLine("Eh graduado em gestão de políticas públicas? (true/false): ");
        bool graduacaoEmPoliticasPublicas = bool.Parse(Console.ReadLine());

        bool podeSeCandidatar = idade >= 30 && nacionalidadeXurupitense && (graduacaoEmEconomia || graduacaoEmPoliticasPublicas);

        Console.WriteLine("Pode se candidatar a presidencia de Xurupita: " + podeSeCandidatar);
    }