using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace TiposDeListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. List<T>
            List<string> lista = new List<string> { "Gabriel", "Lucas", "Maria" };
            Console.WriteLine("List<T>:");
            foreach (var nome in lista)
                Console.WriteLine($"- {nome}");

            Console.WriteLine("\n-----------------------------\n");

            // 2. Array (T[])
            string[] array = new string[] { "Item1", "Item2", "Item3" };
            Console.WriteLine("Array:");
            foreach (var item in array)
                Console.WriteLine($"- {item}");

            Console.WriteLine("\n-----------------------------\n");

            // 3. LinkedList<T>
            LinkedList<string> listaEncadeada = new LinkedList<string>();
            listaEncadeada.AddLast("Primeiro");
            listaEncadeada.AddLast("Segundo");
            Console.WriteLine("LinkedList<T>:");
            foreach (var item in listaEncadeada)
                Console.WriteLine($"- {item}");

            Console.WriteLine("\n-----------------------------\n");

            // 4. ObservableCollection<T>
            ObservableCollection<string> listaObservable = new ObservableCollection<string>();
            listaObservable.CollectionChanged += (s, e) =>
            {
                Console.WriteLine($"ObservableCollection - Ação: {e.Action}");
            };
            listaObservable.Add("Item A");
            listaObservable.Add("Item B");

            Console.WriteLine("\n-----------------------------\n");

            // 5. Collection<T>
            Collection<string> listaCollection = new Collection<string>();
            listaCollection.Add("Elemento 1");
            listaCollection.Add("Elemento 2");
            Console.WriteLine("Collection<T>:");
            foreach (var item in listaCollection)
                Console.WriteLine($"- {item}");

            Console.WriteLine("\n-----------------------------\n");

            // 6. BindingList<T>
            BindingList<string> bindingList = new BindingList<string>();
            bindingList.ListChanged += (s, e) =>
            {
                Console.WriteLine($"BindingList - Tipo de mudança: {e.ListChangedType}");
            };
            bindingList.Add("Binding A");
            bindingList.Add("Binding B");

            Console.WriteLine("\n-----------------------------\n");

            // 7. ReadOnlyCollection<T>
            var listaOriginal = new List<string> { "Original 1", "Original 2" };
            ReadOnlyCollection<string> listaSomenteLeitura = new ReadOnlyCollection<string>(listaOriginal);
            Console.WriteLine("ReadOnlyCollection<T>:");
            foreach (var item in listaSomenteLeitura)
                Console.WriteLine($"- {item}");

            // Tentativa de modificar (irá falhar se descomentar)
            // listaSomenteLeitura.Add("Novo"); // Não compila!
        }
    }
}
