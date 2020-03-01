using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRZEDSZK
{
    class Program
    {
        static void Main()
        {
            int zestawy = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < zestawy; i++)
            {
                string linia = Console.ReadLine();
                string[] tab = linia.Split(' ');
                int pierwsza = Int32.Parse(tab[0]);
                int druga = Int32.Parse(tab[1]);

                int x = pierwsza * druga;
                int wynik;

                
                while (druga != 0)
                {
                    wynik = pierwsza % druga;
                    pierwsza = druga;
                    druga = wynik;
                }
                Console.WriteLine(x / pierwsza);

            }
        }
    }
}
