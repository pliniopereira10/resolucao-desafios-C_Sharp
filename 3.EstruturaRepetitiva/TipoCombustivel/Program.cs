using System;

namespace TipoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, alcool, gasolina, diesel;

            alcool = 0;
            gasolina = 0;
            diesel = 0;
            
            Console.WriteLine("Informe o tipo de combustivel para contagem");
            Console.WriteLine("1-Alcool");
            Console.WriteLine("2-Gasolina");
            Console.WriteLine("3-Diesel");
            Console.WriteLine("4-Finalizar");
            codigo = int.Parse(Console.ReadLine());

            
            while (codigo != 4)
            {
                if (codigo == 1) {
                    alcool++;

                }
                if (codigo == 2) {
                    gasolina++;

                } 
                if (codigo == 3) {
                    diesel++;

                }                
                Console.WriteLine("vai continuar ???");
                Console.WriteLine("digite 1, 2, 3 ou 4 para finalizar ...");
                codigo = int.Parse(Console.ReadLine());

                
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
