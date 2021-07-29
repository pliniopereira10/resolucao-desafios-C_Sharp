using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

                valor = int.Parse(Console.ReadLine());

            for (int cont = 1; cont <= valor; cont ++ ) {
                if (cont % 2 != 0) {
                    Console.WriteLine(cont);
                    
                }
            }
        }
    }
}
