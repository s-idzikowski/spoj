using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUCGAME
{
    class Program
    {
        static void Main()
        {
            int iloscPartii = int.Parse(Console.ReadLine());

            for (int i = 0; i < iloscPartii; i++)
            {
                string linia = Console.ReadLine();
                string[] tablinia = linia.Split(' ');

                int r1 = int.Parse(tablinia[0]);
                int r2 = int.Parse(tablinia[1]);

                poczatek:
                if (r1 < r2)
                {
                    r2 = r2 - r1;   
                }
                if (r2 < r1)
                {
                    r1 = r1 - r2;
                }
                if (r1 == r2)
                {
                    Console.WriteLine(r1 + r2);
                    continue;
                }
                goto poczatek;
            }
        }
    }
}
