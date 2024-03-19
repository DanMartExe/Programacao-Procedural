using System;

class Program
{
    static void Main(string[] args)
    {
        const string USUARIO_SISTEMA = "admin";
        const string SENHA_SISTEMA = "123senha";
        const int TENTATIVAS_MAXIMAS = 3;

        int contadorTentativas = 0;

        do
        {
            Console.WriteLine("Nome de usuario: ");
            string usuarioDigitado = Console.ReadLine();

            Console.WriteLine("Senha: ");
            string senhaDigitada = Console.ReadLine();

            if (usuarioDigitado == USUARIO_SISTEMA && senhaDigitada == SENHA_SISTEMA)
            {
                Console.WriteLine("Login realizado com sucesso.");
                break;
            }
            contadorTentativas++;
        }
        while (contadorTentativas < TENTATIVAS_MAXIMAS);

        if (contadorTentativas >= TENTATIVAS_MAXIMAS)
        {
            Console.WriteLine("Sua conta foi bloqueada.");
        }
    }
}