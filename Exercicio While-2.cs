using System;
using System.Globalization;

namespace EstruturasRepetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, alcool, gasolina, diesel;
            codigo = int.Parse(Console.ReadLine());
            alcool = 0;
            gasolina = 0;
            diesel = 0;

            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    alcool++;
                }
                else if (codigo == 2)
                {
                    gasolina++;
                }
                else if (codigo == 3)
                {
                    diesel++;
                }
                codigo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
