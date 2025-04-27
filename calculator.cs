using System;

namespace Projeto1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual tipo de operação? [1]Adição [2]Subtração [3]Multiplicação [4]Divisão");
            int slc = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o primeiro número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = 0;  

            switch (slc) {
                case 1:
                resultado = Somar(n1, n2);
                break;
                case 2:
                resultado = Subtrair(n1, n2);
                break;
                case 3:
                resultado = Multiplicar(n1, n2);
                break;
                case 4:
                if (n2 != 0) {
                    resultado = Dividir(n1, n2);
                }
                else {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    return; 
                }
                break;
                default:
                Console.WriteLine("Opção inválida.");
                return; 
            }  
            Console.WriteLine("Resultado: " + resultado);
        }
        static int Somar(int n1, int n2) {
            return n1 + n2;
        }
        static int Subtrair(int n1, int n2) {
            return n1 - n2;
        }
        static int Multiplicar(int n1, int n2) {
            return n1 * n2;
        }
        static int Dividir(int n1, int n2) {
            return n1 / n2;  
        }
    }
}
