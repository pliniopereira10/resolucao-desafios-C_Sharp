using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, fatorial;

            fatorial = 1;          

            valor = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= valor; i++)
            {
               fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
