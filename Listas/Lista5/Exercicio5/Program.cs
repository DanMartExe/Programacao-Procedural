using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        
        const int COORDENADA_MAXIMA = 7;

        for (int linha = 0; linha <= COORDENADA_MAXIMA; linha++)
        {
            for (int coluna = 0; coluna <= COORDENADA_MAXIMA; coluna++)
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