using System;

namespace Treinos.program;

 class Program
{
    public static void Main(string[] args)
    {
        List<string> Tarefas = new List<string>();

        while (true)
        {
            Console.WriteLine("Lista de Tarefas");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Excluir Tarefa");
            Console.WriteLine("3. Listar Tarefas");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a tarefa: ");
                    string tarefa = Console.ReadLine();
                    Tarefas.Add(tarefa);
                    Console.WriteLine("Tarefa adicionada com sucesso!");
                    break;
                case "2":
                    Console.Write("Digite o número da tarefa a ser excluída: ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= Tarefas.Count)
                    {
                        Tarefas.RemoveAt(index - 1);
                        Console.WriteLine("Tarefa excluída com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Tarefas:");
                    for (int i = 0; i < Tarefas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {Tarefas[i]}");
                    }
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    return;
            }

        }
    }          
}   