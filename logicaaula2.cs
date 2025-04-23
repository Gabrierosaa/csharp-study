using System;
using System.Globalization;

namespace Projeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //Console.Write("{0} tem {1} anos e o saldo de {2}", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));
            //Console.Write($"{nome} tem {idade} anos e tem saldo igual a`{saldo:F2} reais"); 
            //Console.Write(nome, " tem " +  idade + " anos e tem o saldo de " + saldo + "R$");

        }
    }
}
