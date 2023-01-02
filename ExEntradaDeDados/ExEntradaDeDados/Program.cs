using System;
using System.Globalization;

namespace ExEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto? ");
            double preco = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');

            nome = vet[0];
            qto = int.Parse(vet[1]);
            preco = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(qto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
