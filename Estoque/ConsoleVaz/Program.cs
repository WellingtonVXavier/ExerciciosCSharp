using System;

namespace ConsoleVaz
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco, total;

            Console.WriteLine("Escreva o codigo do produto:");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a quantidade:");
            quantidade = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    preco = 5.50;
                    break;
                case 2:
                    preco = 7.50;
                    break;
                case 3:
                    preco = 2.35;
                    break;
                case 4:
                    preco = 1.28;
                    break;
                default:
                    preco = 0;
                    total = 0;
                    break;
            }

            total = quantidade * preco;
            Console.WriteLine($"   Total a pagar: {total}");

            Console.ReadLine();
        }
    }
}
