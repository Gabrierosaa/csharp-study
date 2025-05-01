using System;

namespace Codigo1 {
    internal class Projeto {
        public static void Main(string[] args) {
            Console.WriteLine("Entre com as notas");
            try {
                double n1 = double.Parse(Console.ReadLine());
                double n2 = double.Parse(Console.ReadLine());
                double n3 = double.Parse(Console.ReadLine());
                double n4 = double.Parse(Console.ReadLine());
                double resultado = Processo(n1, n2, n3, n4);
                if (resultado >= 7) {
                    Console.WriteLine("A media do aluno foi de {0} pontos, esta aprovado", resultado);
                }else if (resultado < 7) {
                    Console.WriteLine("A media do aluno foi de {0} pontos, esta reprovado", resultado);
                }
                
                
            }
            catch (FormatException) {
                Console.WriteLine("Tecla invalida");
            }
        }
        static double Processo(double n1, double n2, double n3, double n4) {
            return (n1 + n2 + n3 + n4) / 4;
        }
    }
}
    
