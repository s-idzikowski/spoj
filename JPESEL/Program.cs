using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPESEL
{
    class Program
    {
        static void Main()
        {
            int iloscTestow = int.Parse(Console.ReadLine());

            for (int i = 0; i < iloscTestow; i++)
            {
                string t = Console.ReadLine();

                int wynik = (int)(t[0]) + (int)(t[1]) * 3 + (int)(t[2]) * 7 + (int)(t[3]) * 9 + (int)(t[4]) + (int)(t[5]) * 3 + (int)(t[6]) * 7 + (int)(t[7]) * 9 + (int)(t[8]) + (int)(t[9]) * 3 + (int)(t[10]);
                if (wynik > 0 && wynik % 10 == 0)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("N");
                }
            }
        }
    }
}
