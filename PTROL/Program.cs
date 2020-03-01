using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTROL
{
    class Program
    {
        static void Main()
        {
            int zestawy = int.Parse(Console.ReadLine());

            for (int i = 0; i < zestawy; i++)
            {
                string linia = Console.ReadLine();
                string[] tab = linia.Split(' ');
                List<string> lista = new List<string>(tab);

                for (int j = 2; j < lista.Count; j++)
                {
                    Console.Write(lista[j] + " ");
                }
                Console.Write(lista[1] + "\n");
            }
        }
    }
}
