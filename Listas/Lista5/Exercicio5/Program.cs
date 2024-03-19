using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();

        for (int linha = 0; linha <= 7; linha++)
        {
            for (int coluna = 0; coluna <= 7; coluna++)
            {
                if (linha % 2 == 0)
                {
                    Tabuleiro.Adicionar(linha, coluna, "C");
                }
            }
        }

        Tabuleiro.ImprimeTabuleiro();
    }
}