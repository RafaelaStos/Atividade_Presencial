using System;

namespace ExercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora;

            Console.WriteLine("Informe a Hora desejada:");
            hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else if (hora >= 18 && hora < 24)
            {
                Console.WriteLine("Boa Noite");
            }

            Console.ReadKey();
        }
    }
}
