// Programa imprime sequência númerica dentro de laço For encadeado

using System;

namespace SequenciaIJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int letraI = 1; letraI <= 9; letraI+= 2)
            {
                for (int letraJ = 7; letraJ >= 5; letraJ--)
                {
                    Console.WriteLine("I=" + letraI + " J=" + letraJ);
                }
            }

            
            
           
            
        }
    }
}
