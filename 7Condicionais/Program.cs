﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 8 - condicionais2");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mais esta acompanhado.");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos de idade. então pode entrar.");
                }
            }

            Console.ReadLine();
        }
    }
}
