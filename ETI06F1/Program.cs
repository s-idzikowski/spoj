using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETI06F1
{
    class Program
    {
        static void Main()
        {
            string linia = Console.ReadLine();
            string[] tablinia = linia.Split(' ');

            double r = double.Parse(tablinia[0]);
            double d = double.Parse(tablinia[0]);

            
            
            double r2;
            r2 = (r * r) - ((d * d) * 0.25);
            double S = 3.141592654 * r2;
            Console.WriteLine(Math.Round(S, 2).ToString().Replace(',','.'));
        }
    }
}
