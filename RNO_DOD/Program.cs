using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNO_DOD
{
    class Program
    {
        static void Main()
        {
            var iloscTestow = Int32.Parse(Console.ReadLine());
            if (iloscTestow < 0 && iloscTestow > 100)
                return;
            for (int i = 0; i < iloscTestow; i++)
            {
                var liczbaLiczb = Int32.Parse(Console.ReadLine());
     
                var linia = Console.ReadLine();
                string[] tab = linia.Split(' ');

                int suma = 0;
                foreach (var item in tab)
                {
                    suma += Int32.Parse(item);
                }
                Console.WriteLine(suma);
                
            }
            
        }
    }
}
