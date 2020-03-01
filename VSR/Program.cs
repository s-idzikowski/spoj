using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSR
{
    class Program
    {
        static void Main()
        {
            var iloscTestow = Int32.Parse(Console.ReadLine());
            if (iloscTestow < 1 && iloscTestow > 1000)
                return;
            for (int i = 0; i < iloscTestow; i++)
            {
                var linia = Console.ReadLine();
                string[] tab = linia.Split(' ');

                int l1 = Int32.Parse(tab[0]);
                int l2 = Int32.Parse(tab[1]);

                int wynik = l1 * l2 * 2 / (l1 + l2);
                Console.WriteLine(wynik);

            }

        }
    }
}
