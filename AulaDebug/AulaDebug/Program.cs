using System;

namespace AulaDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Escrever();
            Calcular();
        }

        static void Escrever()
        {
            Console.WriteLine("Consegui escrever um método");
        }

        static void Calcular()
        {
            var total = 0;
            while (total < 10)
            {
                Console.WriteLine($"O Total agora é: {total}");
                total++;
            }
        }
    }
}
