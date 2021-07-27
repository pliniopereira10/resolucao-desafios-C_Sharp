using System;

namespace SenhaFixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            valor = 2002;

            Console.WriteLine("Por favor, informe a senha: ");
            valor = int.Parse(Console.ReadLine());

            while (valor != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Por favor, informe a senha: ");
                valor = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
