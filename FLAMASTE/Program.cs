using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAMASTE
{
    class Program
    {
        static void Main()
        {
            int iloscZestawow = int.Parse(Console.ReadLine());

            for (int i = 0; i < iloscZestawow; i++)
            {
                string linia = Console.ReadLine();
                
                int licznik = 1;
                Console.Write(linia[0]);
                for (int j = 1; j < linia.Length; j++)
                {
                    if (linia[j] == linia[j - 1])
                    {
                        licznik++;
                    }
                    else
                    {
                        if (licznik == 2)
                        {
                            Console.Write(linia[j - 1]);
                            
                        }
                        if (licznik > 2)
                            Console.Write(licznik);
                        Console.Write(linia[j]);
                        licznik = 1;
                    }
                }
                if (licznik == 2)
                {
                    Console.Write(linia[linia.Length-1]);
                }
                if (licznik > 2)
                    Console.Write(licznik);
                Console.Write("\n");
            }

        }
    }
}
