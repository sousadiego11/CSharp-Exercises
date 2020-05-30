using System;
using System.Globalization;

namespace PrimeiroProjetoC
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, n3, a, b, c;
            string[] lados = Console.ReadLine().Split(" ");
            n1 = double.Parse(lados[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(lados[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(lados[2], CultureInfo.InvariantCulture);
            // primeira etapa, ordenar os valores de forma decrescente sendo A, B e C os lados do triangulo
            if (n1>n2 && n1 > n3) 
            {
                a = n1;
                if (n2 > n3)
                {
                    b = n2;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n2;
                }
            }
            else if(n2> n1 && n2 > n3)
            {
                a = n2;
                if (n1 > n3)
                {
                    b = n1;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n1;
                }
            }
            else
            {
                a = n3;
                if (n2 > n1)
                {
                    b = n2;
                    c = n1;
                }
                else
                {
                    b = n1;
                    c = n2;
                }
            }
            
            //Segunda etapa testar as possibílidades de triangulos, ou se não há possibilidades.
            if (a >= (b+c))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(a,2) == (Math.Pow(b,2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (a == b && a == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }

        }
    }
}