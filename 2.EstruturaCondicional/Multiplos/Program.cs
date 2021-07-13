using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm, valorDois;
            String [] valores;

            Console.WriteLine("Verificação de múltiplos.");
            Console.WriteLine("Digite dois valores: ");
            valores = Console.ReadLine().Split(' ');
            
            valorUm = int.Parse(valores [0]);
            valorDois = int.Parse(valores [1]);

            if (valorUm % valorDois == 0 || valorDois % valorUm == 0) 
            {
                Console.WriteLine("Sao Multiplos");
            }else {
                Console.WriteLine("Nao sao Multiplos");
            }
            
        }
    }
}
