using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            string X = Console.ReadLine();
            string Y = Console.ReadLine();
            string Z = Console.ReadLine();


            string[] vet = Console.ReadLine().Split(' ');
            string A = vet[0];
            string B = vet[1];
            string C = vet[2];

            Console.Write("Voce digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(Z);
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);

            Console.ReadLine();
        }
    }
}
