using System;

namespace Projeto1 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quandos numeros inteiros vai digitar: ");
            int N = int.Parse(Console.ReadLine());


            int soma = 0;
            for (int i = 1; i <= N; i++) { // i = 1 enquanto I for menor que N, I + i = I
                Console.Write("Valor {0} : ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);

        }
    }
}
