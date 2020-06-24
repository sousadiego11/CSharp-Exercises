using System;
using System.Globalization;

namespace Vetores001
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int quantidade = 0;
            double divisao = 0.0;
            string[] valores = Console.ReadLine().Split(" ");
            int[] numeros = new int[n];
            for (int i = 0; i<n; i++)
            {
                numeros[i] = int.Parse(valores[i]);
                divisao = numeros[i] % 2;
                if (divisao==0)                
                {
                    Console.Write(numeros[i] + " ");   
                    quantidade++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(quantidade);
        }
    }
}
