using System;
using Ex07.Entities;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            Funcionario gerente = new Gerente ("Anna", 40, 25000);
            Funcionario supervisor = new Supervisor ("Maria", 35, 10000);
            Funcionario vendedor = new Vendedor ("Laura", 28, 5000);

            gerente.Bonificacao(0);
            supervisor.Bonificacao(0);
            vendedor.Bonificacao(0);

            Console.WriteLine("Nome: " + gerente.Nome + " / Idade: " + gerente.Idade + " /  Salário: " + gerente.Salario);
            Console.WriteLine("Nome: " + supervisor.Nome + "  / Idade: " + supervisor.Idade + "  / Salário: " + supervisor.Salario);
            Console.WriteLine("Nome: " + vendedor.Nome + "  / Idade: " + vendedor.Idade + "  / Salário: " + vendedor.Salario);
        }
    }
}
