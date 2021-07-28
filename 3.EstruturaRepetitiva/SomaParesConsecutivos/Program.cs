using System;

namespace SomaParesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, cont, soma;
            cont = 0;
            soma = 0;

            valor = int.Parse(Console.ReadLine());

            while (valor != 0 && cont < 5)
            {
                if (valor % 2 != 0)
                {
                    valor += 1;
                }

                 soma += valor;
                 valor += 2;
                 cont ++;   
            
            }

            if (soma != 0)
            {
                Console.WriteLine(soma);    
            }
            
        }
    }
}
