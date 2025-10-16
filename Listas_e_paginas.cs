namespace teste
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<string> carros = new List<string>();
            bool continuar = true;
            bool continuarLista = true;

            while (continuar)
            {
                System.Console.WriteLine("Entre com o nome do carro: ");
                String? carro = Console.ReadLine();
                carros.Add(carro);
                System.Console.WriteLine("deseja continuar? : (S/N)");
                string? escolha = Console.ReadLine();
                escolha = escolha?.ToLower();

                continuar = (escolha == "n") ? false : true;
            }
            int paginaAtual = 0;
            int itensPorPagina = 6;

            while (continuarLista)
            {
                int inicio = paginaAtual * itensPorPagina; //multiplica para definir a página.
                int fim = Math.Min(inicio + itensPorPagina, carros.Count);
                Console.WriteLine($"Página {paginaAtual + 1}");

                for (int i = inicio; i < fim; i++)
                {
                    Console.WriteLine($"{i + 1}. {carros[i]}");
                }

                Console.WriteLine("\nPróxima página? (S/N)");
                string? escolhaLista = Console.ReadLine()?.ToLower();

                if (escolhaLista == "n")
                    continuarLista = false;
                else
                    paginaAtual++;
            }
        }
    }
}
