using System.Xml.Serialization;

namespace Treinos.program;

 class Program
{
    public static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        int soma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }
       
    }
}   