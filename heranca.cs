using System;

namespace ProjetoFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Salário base:");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Tipo: [1] Funcionário [2] Gerente");
            int tipo = int.Parse(Console.ReadLine());

            Funcionario pessoa;

            if (tipo == 1)
            {
                pessoa = new Funcionario(nome, salario);
            }
            else
            {
                Console.WriteLine("Digite o bônus do gerente:");
                double bonus = double.Parse(Console.ReadLine());
                pessoa = new Gerente(nome, salario, bonus);
            }

            pessoa.MostrarDados();
        }
    }

    // Classe base
    public class Funcionario
    {
        public string Nome { get; set; }
        protected double SalarioBase;

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            SalarioBase = salario;
        }

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"\nFuncionário: {Nome}");
            Console.WriteLine($"Salário: {CalcularSalario()} R$");
        }
    }

    // Classe derivada
    public class Gerente : Funcionario
    {
        public double Bonus { get; }

        public Gerente(string nome, double salario, double bonus)
            : base(nome, salario)
        {
            Bonus = bonus;
        }

        public override double CalcularSalario()
        {
            return SalarioBase + Bonus;
        }
    }
}
