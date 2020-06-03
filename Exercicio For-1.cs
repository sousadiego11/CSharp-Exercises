using System;

namespace ExFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tabuada!
            int N, resultado;
            N = int.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }
        }
    }
}
