using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace teste
{
    static class Program
    {
        static void Main(string[] args)
        {

          List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count:" + list.Count);

            string s1 = list.First(x => x[0] == 'A');
            Console.WriteLine("First 'A':" + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A':" + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Fisrt position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> List2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            foreach(string obj in List2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");

        }              
    }
}

   
