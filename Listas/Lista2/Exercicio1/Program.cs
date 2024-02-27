using System;

class Program
{
    static void Main(string[] args)
    {
        const string loginSistema = "admin";
        const string senhaSistema = "123senha";

        Console.WriteLine("Digite seu nome de usuario: ");
        string loginDigitado = Console.ReadLine();

        Console.WriteLine("Digite sua senha: ");
        string senhaDigitada = Console.ReadLine();

        if (loginDigitado == loginSistema && senhaDigitada == senhaSistema)
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais invalidas");
        }
    }
}