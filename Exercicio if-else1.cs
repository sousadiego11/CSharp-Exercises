using System;
using System.Globalization;

namespace PrimeiroProjetoC{
    class Program{
        static void Main(string[] args)
        {
           /*
            o objetivo do código é identificar se a afirmação no campo if é verdadeira 
            e responder de acordo com a afirmação.
           */
            int a, b, c, d;
            
            string[] valores = Console.ReadLine().Split(" ");
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);
            d = int.Parse(valores[3]);
            
            if (b > c && d > a && a + b < c + d && c > 0 & d > 0 && a % 2 == 0) 
            /*
            se B for maior do que C e se D for maior do que A, 
            e a soma de C com D for maior que a soma de A e B e se C e D, ambos, 
            forem positivos e se a variável A for par.
            */
            { Console.WriteLine("VALORES ACEITOS");}
            
            else
            {Console.WriteLine("VALORES NAO ACEITOS");}
        }
    }
}
