using System;

namespace classePessoa {
    class Program {
        static void Main(string[] args) {

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();            

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            //if (pessoa1.idade > pessoa2.idade) Console.WriteLine("Pessoa mais velha: " + pessoa1.nome);
            //if (pessoa1.idade < pessoa2.idade) Console.WriteLine("Pessoa mais velha: " + pessoa2.nome);

            
            var result = pessoa1.idade > pessoa2.idade ? pessoa1.nome : pessoa2.nome;
            Console.WriteLine("Pessoa mais velha: " + result);
            Console.ReadLine();
        }
    }
}

