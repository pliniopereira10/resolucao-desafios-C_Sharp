using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string comOuSemOsso, grupo, tipoAlimentacao;

            comOuSemOsso = Console.ReadLine();
            grupo = Console.ReadLine();
            tipoAlimentacao = Console.ReadLine();

            if (comOuSemOsso == "vertebrado") {
                if (grupo == "ave") {
                    if (tipoAlimentacao == "carnivoro") {
                        Console.WriteLine("aguia");
                    } else {
                        Console.WriteLine("pomba");
                    }

                } else {
                    if (tipoAlimentacao == "onivoro") {
                        Console.WriteLine("homem");

                    }else {
                        Console.WriteLine("vaca");
                    }

                }

            } else {
                if (grupo == "inseto") {
                    if (tipoAlimentacao  == "hematofago"){
                        Console.WriteLine("pulga");

                    } else {
                        Console.WriteLine("lagarta");
                    }
                    
                } else {
                    if (tipoAlimentacao  == "hematofago"){
                        Console.WriteLine("sanguessuga");

                    } else {
                        Console.WriteLine("minhoca");
                    }

                }

            }
        }
    }
}
