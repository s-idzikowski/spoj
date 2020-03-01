using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLUTTON
{
    class Program
    {
        static void Main()
        {
            int iloscZestawow = Int32.Parse(Console.ReadLine());
            const int doba = 86400;

            for (int i = 0; i < iloscZestawow; i++)
            {
                string linia = Console.ReadLine();
                string[] tablinia = linia.Split(' ');
                int uczestnikow = Int32.Parse(tablinia[0]);
                int iloscCiastek = Int32.Parse(tablinia[1]);

                int wynik = 0;
                for (int j = 0; j < uczestnikow; j++)
                {
                    int czas = int.Parse(Console.ReadLine());
                    wynik += doba / czas;
                    
                }

                int iloscPudelek = wynik / iloscCiastek;
                if (wynik % iloscCiastek > 0)
                    iloscPudelek++;

                Console.WriteLine(iloscPudelek);
            }
        }
    }
}
