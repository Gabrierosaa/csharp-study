using System;
using System.Globalization;

namespace Projeto1 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um numero: ");  // Fixed: Changed single quotes to double quotes
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));  // Fixed: Added missing closing parenthesis
                Console.WriteLine("Digite outro numero");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  // Fixed: Removed 'double' declaration (variable already declared)
            }
        }
    }
}
