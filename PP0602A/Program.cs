using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0602A
{
    class Program
    {
        static void Main()
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < liczbaTestow; i++)
            {
                string linia = Console.ReadLine();
                string[] tab = linia.Split(' ');

                for (int j = 1; j < tab.Length; j++)
                {
                    if (j % 2 == 0)
                        Console.Write(tab[j] + ' ');
                }
                for (int j = 1; j < tab.Length; j++)
                {
                    if (j % 2 != 0)
                        Console.Write(tab[j] + ' ');
                }
                Console.Write("\n");
            }
        }
    }
}
