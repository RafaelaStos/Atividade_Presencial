using System;

namespace Presencial.Consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int largura = 50, altura = 10;

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {

                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();


        }
    }
}
