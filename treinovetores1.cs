namespace Treinos.program;

 class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre com o numero de numeros no array: ");
        int n = int.Parse(Console.ReadLine());
        int[] Numeros = new int[n];
        int soma = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Entre com o Numero: ");
            Numeros[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Criado");
        }
        for (int i = 0; i < n; i++)
        {
            soma += Numeros[i];
        }
        Console.WriteLine($"O valor da soma {soma}");

    }
}   