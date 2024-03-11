using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();

        const int COORDENADA_MAXIMA = 7;
        
        for (int coluna = 0; coluna <= COORDENADA_MAXIMA; coluna++)
        {
            for (int linha = 0; linha <= COORDENADA_MAXIMA; linha++)
            {
                if (linha == 0 || linha == COORDENADA_MAXIMA ||
                 coluna == 0 || coluna == COORDENADA_MAXIMA)
                {
                    Tabuleiro.Adicionar(linha, coluna, "s");
                }
            }
        }

        Tabuleiro.ImprimeTabuleiro();
    }
}