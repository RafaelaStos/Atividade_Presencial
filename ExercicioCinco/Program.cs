using System;

namespace ExercicioCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numeros = new Random();
            string jogador1, jogador2;
            int contPontos1 = 0, contPontos2 = 0;

            Console.WriteLine("Informe o nome do 1º Jogador");
            jogador1 = Console.ReadLine();

            Console.WriteLine("Informe o nome do 2º Jogador");
            jogador2 = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                int numerosJogador1 = numeros.Next(0, 7);
                int numerosJogador2 = numeros.Next(0, 7);
                Console.WriteLine("\n" + i + "º Rodada\n");
                Console.WriteLine(jogador1 + ": " + numerosJogador1 + "\n" + jogador2 + ": " + numerosJogador2 + "\n");
                if (numerosJogador1 > numerosJogador2)
                {
                    contPontos1++;
                    Console.WriteLine("O jodador(a) " + jogador1 + " jogo " + numerosJogador1 + " e venceu a " + i + "º rodada");
                }
                else if (numerosJogador1 < numerosJogador2)
                {
                    contPontos2++;
                    Console.WriteLine("O jodador(a) " + jogador2 + " jogo " + numerosJogador2 + " e venceu a " + i + "º rodada");
                }
                else if (numerosJogador1 == numerosJogador2)
                {
                    Console.WriteLine("Em pate nenhum jogador pontua");
                }
                Console.ReadKey();

            }

            if (contPontos1 > contPontos2)
                Console.WriteLine("\nParabéns " + jogador1 + ", você ganhou o jogo!");
            else if (contPontos1 < contPontos2)
                Console.WriteLine("\nParabéns " + jogador2 + ", você ganhou o jogo!");
            else if (contPontos1 == contPontos2)
                Console.WriteLine("\nHouve um empate definitivo, tente novamente!");
        }
    }
}
