using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABLICA
{
    class Program
    {
        static void Main()
        {
            string wiersz = Console.ReadLine();
            string[] tabwiersz = wiersz.Split();

            List<string> lista = new List<string>(tabwiersz);
            lista.Reverse();

            foreach (var item in lista)
            {
                Console.Write(item + ' ');
            }
        }
    }
}
