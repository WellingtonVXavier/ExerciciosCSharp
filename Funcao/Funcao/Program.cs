﻿using System;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior =  " + resultado);
        }

        static int Maior(int A, int B, int C)
        {
            int M;
            if (A > B && A > C)
            {
                M = A;
            }
            else if (B > C)
            {
                M = B;
            }
            else
            {
                M = C;
            }
            return M;
        }
    }
}
