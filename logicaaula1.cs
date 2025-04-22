using System;
using System.Globalization;

namespace Projeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); // Usando o using System.Globalization; e Usando o CultureInfo.InvariantCulture! posso imprimir com . e nao ,
            Console.WriteLine(nome);

        }
    }
}
