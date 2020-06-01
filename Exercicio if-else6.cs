using System;
using System.Globalization;

namespace PrimeiroProjetoC
{
    class Program
    {
        static void Main(string[] args)
        {
            string grupo, tipo, dieta;
            grupo = Console.ReadLine();
            tipo = Console.ReadLine();
            dieta = Console.ReadLine();

            if (grupo == "vertebrado")
            {
                if (tipo == "ave")
                {
                    if (dieta == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (tipo == "mamifero")
                {
                    if (dieta == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (tipo == "inseto")
                {
                    if (dieta == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (tipo == "anelideo")
                {
                    if (dieta == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}