using System;

namespace ExercicioQuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int negativo = 0, positivo = 0, media = 0, j = 1;
            int[] valores = new int[5];
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Informe o " + j + "° valor:");
                valores[i] = int.Parse(Console.ReadLine());
                j++;

                if (valores[i] > 0)
                {
                    positivo++;
                }
                if (valores[i] < 0)
                {
                    negativo++;
                }
                media += valores[i];

            }
            Console.WriteLine("A média aritimetica é: " + media / 5);
            Console.WriteLine("A quantidade de valores negativos é: " + negativo);
            Console.WriteLine("A quantidade de valores positivo é: " + positivo);
            Console.ReadKey();
        }
    }
}
