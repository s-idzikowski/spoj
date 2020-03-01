using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0601B
{
    class Program
    {
        static void Main()
        {
            int iloscTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < iloscTestow; i++)
            {
                string linia = Console.ReadLine();
                string[] tablinia = linia.Split(' ');

                int n = int.Parse(tablinia[0]);
                int x = int.Parse(tablinia[1]);
                int y = int.Parse(tablinia[2]);

                for (int j = 2; j < n; j++)
                {
                    if (j % x == 0 && j % y != 0)
                        Console.Write(j + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
