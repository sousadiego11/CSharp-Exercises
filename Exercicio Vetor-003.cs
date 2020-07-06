using System;
using System.Globalization;

namespace Vetores001
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] valores1 = new int[n];
            int[] valores2 = new int[n];
            int[] valores3 = new int[n];
            string[] vet = Console.ReadLine().Split(" ");
            
            for (int i = 0; i<n; i++)
            {
                valores1[i] = int.Parse(vet[i]);
            }
            
            vet = Console.ReadLine().Split(" ");
            for (int i = 0; i < n; i++)
            {
                valores2[i] = int.Parse(vet[i]);
            }
            
            for (int i = 0; i < n; i++)
            {
                valores3[i] = valores1[i] + valores2[i];
                Console.Write(valores3[i] + " ");
            }
        }
    }
}
