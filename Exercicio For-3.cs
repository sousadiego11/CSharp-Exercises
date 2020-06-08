using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace Exercicio_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, soma, min, max;
            n = int.Parse(Console.ReadLine());
            soma = 0;
            
            for (int i = 1; i <= n; i++)
            {
                string[] numeros = Console.ReadLine().Split(" ");
                x = int.Parse(numeros[0]);
                y = int.Parse(numeros[1]);

                if (x < y)
                {
                    min = x;
                    max = y;
                }
                else
                {
                    min = y;
                    max = x;
                }
                for (int indice2 = min + 1; indice2 <= max; indice2++)
                {
                    if (indice2 == max )
                    {
                        soma += 0;
                    }
                    else if (indice2 % 2 != 0)
                    {
                        soma += indice2;
                    }
                    else
                    {
                        soma += 0;
                    }
                }
                Console.WriteLine(soma);
                soma = 0;
            }

        }
    }
}
