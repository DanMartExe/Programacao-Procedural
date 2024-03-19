using NAudio.Wave.SampleProviders;

class Program 
{
    /*static void Main(string[] args)
    {
        Piano.ReproduzTecla(1,1); //(oitava,nota,tempo[m/s])
        Piano.ReproduzTecla(1,2);
        Piano.ReproduzTecla(1,3);
        Piano.ReproduzTecla(1,4);
        Piano.ReproduzTecla(1,5);
        Piano.ReproduzTecla(1,6);
        Piano.ReproduzTecla(1,7);

        const int TAMANHO_OITAVA = 7; //Uma oitava tem 7 notas
        int contador = 1;

        while (contador <= TAMANHO_OITAVA)
        {
            if (contador % 2 == 1)
            {
                Piano.ReproduzTecla(1, contador);
            }
            contador++;
        }
        //agora, p percorrer todas as notas:
        const int QUANTIDADE_OITAVAS = 4;
        int contadorOitava = 1;
        int contadorTecla = 1;

        while (contadorOitava <= QUANTIDADE_OITAVAS)
        {   
            while (contadorTecla <= TAMANHO_OITAVA) //laço interno sempre varia mais
            {
                Piano.ReproduzTecla(contadorOitava, contadorTecla);
                contadorTecla++;
            }
            contadorOitava++;
            contadorTecla = 1;
        }

        //Piano.TocarAsaBranca(); //funções
        //Piano.TocarTwinkleTwinkle();


    }
    */
    static void Main(string[] args)
    {
Piano.ReproduzTecla(1, 3, 400); // Mi
Piano.ReproduzTecla(1, 3, 400); // Mi
Piano.ReproduzTecla(1, 4, 400); // Fá
Piano.ReproduzTecla(1, 5, 400); // Sol
Piano.ReproduzTecla(1, 5, 400); // Sol
Piano.ReproduzTecla(1, 4, 400); // Fá
Piano.ReproduzTecla(1, 3, 400); // Mi
Piano.ReproduzTecla(1, 2, 400); // Ré
Piano.ReproduzTecla(1, 1, 400); // Dó
Piano.ReproduzTecla(1, 1, 1200); // Dó
Piano.ReproduzTecla(1, 2, 1200); // Ré
Piano.ReproduzTecla(1, 3, 1200); // Mi
Piano.ReproduzTecla(1, 3, 1200); // Mi
Piano.ReproduzTecla(1, 2, 1200); // Ré
Piano.ReproduzTecla(1, 2, 1200); // Ré
Piano.ReproduzTecla(1, 1, 1200); // Dó
Piano.ReproduzTecla(1, 1, 800); // Dó
Piano.ReproduzTecla(1, 2, 400); // Ré
Piano.ReproduzTecla(1, 3, 400); // Mi
Piano.ReproduzTecla(1, 3, 400); // Mi
Piano.ReproduzTecla(1, 2, 400); // Ré
Piano.ReproduzTecla(1, 1, 400); // Dó
Piano.ReproduzTecla(1, 1, 1200); // Dó
Piano.ReproduzTecla(1, 2, 1200); // Ré
Piano.ReproduzTecla(1, 3, 1200); // Mi
Piano.ReproduzTecla(1, 2, 1200); // Ré
Piano.ReproduzTecla(1, 1, 1200); // Dó
    }
}


