using System;

class Program
{
    /*Crie um jogo de palavras cruzadas em que o jogador deve adivinhar uma palavra
    com base em uma dica fornecida pelo programa. Use um laço while para permitir
    que o jogador faça multiplas tentativas até acertar a palavra. O jogo deve
    oferecer uma pontuação com base no número de tentativas necessárias para
    adivinhar a palavra. LIMITAR NÚMERO DE RESPOSTAS A 3*/
    static void Main(string[] args)
    {
        const string RESPOSTA_CORRETA = "Karpov";
        const int PONTUACAO_INICIAL = 100;
        const int NUMERO_MAXIMO_TENTATIVAS = 3;

        int contadorTentativas = 1;

        do
        {
            Console.WriteLine("\n[Dica] - Foi campeao mundial de xadrez");
            Console.WriteLine("Digite o valor do campo: ");
            string respostaUsuario = Console.ReadLine();

            if (respostaUsuario == RESPOSTA_CORRETA)
            {
                double pontuacaoFinal = PONTUACAO_INICIAL / contadorTentativas;
                Console.WriteLine("Voce acertou! A sua pontuacao foi: " + pontuacaoFinal);
                break;
            }
            contadorTentativas++;
        }
        while (contadorTentativas <= NUMERO_MAXIMO_TENTATIVAS);
        
        if (contadorTentativas > NUMERO_MAXIMO_TENTATIVAS)
        {
            System.Console.WriteLine("GAME OVER");
            break;
        }
    }
}