using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj_csharp
{
    class Program
    {
        static void Main()
        {
            var pierwsza = Int32.Parse(Console.ReadLine());
            var druga = Int32.Parse(Console.ReadLine());

            if (pierwsza < 200 && druga < 200)
            {
                Console.WriteLine(pierwsza + druga);
            }

        }
    }
}
