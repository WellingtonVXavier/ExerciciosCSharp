using System;
using System.Globalization;

namespace empresa {
    class Program {
        static void Main(string[] args) {
            Funcionario func = new Funcionario();

            Console.WriteLine("ENTRE COM OS DADOS DO FUNCIONÁRIO:");
            Console.WriteLine("__________________________________");

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("_____________________________");
            Console.WriteLine("Dados do funcionário: " + func);

            Console.WriteLine("____________________________________________");
            Console.Write("Deseja aumentar o salário em qual porcentagem?: ");
            double porncent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porncent);

            Console.WriteLine("_________________________________________");
            Console.WriteLine("Dados atualizados do funcionário: " + func);

            Console.ReadLine();
        }
    }
}
