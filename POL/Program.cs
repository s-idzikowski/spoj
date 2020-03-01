using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POL
{
    class Program
    {
        static void Main()
        {
            int iloscLinii = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < iloscLinii; i++)
            {
                string linia = Console.ReadLine();
                int iloscznakow = linia.Length;
                for (int j = 0; j < iloscznakow/2; j++)
                {
                    Console.Write(linia[j]);
                }
                Console.Write("\n");
            }
        }
    }
}
