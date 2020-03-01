using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0502B
{
    class Program
    {
        static void Main()
        {
            int iloscTestow = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < iloscTestow; i++)
            {
                string linia = Console.ReadLine();
                string[] tablica = linia.Split(' ');
                List<string> tab = new List<string>(tablica);
                tab.RemoveAt(0);
                tab.Reverse();
                foreach (var item in tab)
                {
                    Console.Write(item + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
