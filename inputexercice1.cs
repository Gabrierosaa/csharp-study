using System;

namespace Projeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com o número de quartos da sua casa: ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine(quarto);

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o último nome, idade e altura:");
            string aba = Console.ReadLine();
            string[] res = aba.Split(' ');
            string ultimoNome = res[0];
            int idade = int.Parse(res[1]);
            double altura = double.Parse(res[2]);
        }
    }
}
