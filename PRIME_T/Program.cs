using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIME_T
{
    public class Program
    {
        static void Main(string[] args)
        {
            var iloscTestow = Int32.Parse(Console.ReadLine());
            if (iloscTestow < 0 && iloscTestow > 100000)
                return;
            for (int i = 0; i < iloscTestow; i++)
            {
                var liczba = Int32.Parse(Console.ReadLine());
                if (czyPierwsza(liczba))
                { 
                    Console.WriteLine("TAK");
                }
                else
                {
                    Console.WriteLine("NIE");
                }
                
            }
        }

        static bool czyPierwsza(int liczba)
        {
            if (liczba < 2)
                return false;

            for (int i = 2; i * i <= liczba; i++)
                if (liczba % i == 0)
                    return false;
            return true;
        }
    }
}
