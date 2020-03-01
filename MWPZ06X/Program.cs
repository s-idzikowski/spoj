using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWPZ06X
{
    class Program
    {
        static void Main()
        {
            int iloscZestawow = int.Parse(Console.ReadLine());

            for (int i = 0; i < iloscZestawow; i++)
            {
                int liczba = int.Parse(Console.ReadLine());
                Console.WriteLine(liczba * liczba);
            }
        }
    }
}
