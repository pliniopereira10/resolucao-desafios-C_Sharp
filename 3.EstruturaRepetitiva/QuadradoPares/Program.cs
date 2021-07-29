using System;

namespace QuadradoPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, cont, quadrado;
            cont = 1;

                valor = int.Parse(Console.ReadLine());

            do {
                if (cont % 2 == 0) {
                    quadrado = cont * cont;
                    Console.WriteLine(cont + "^2" + " = " + quadrado);
                    
                }
                cont ++;
                
            } while (cont <= valor);
        }
    }
}
