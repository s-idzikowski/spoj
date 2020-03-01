using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCTRL3
{
    class Program
    {
        static void Main()
        {
            var iloscTestow = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < iloscTestow; i++)
            {
                var liczba = Int32.Parse(Console.ReadLine());
                
                if (liczba > 9)
                {
                    Console.WriteLine("0 0");
                }
                else if (liczba == 0)
                {
                    Console.WriteLine("0 1");
                } 
                else
                {
                    //int jednosci, dziesiatki;
                    int wynik = 1;
                    for (int j = 1; j <= liczba; j++)
                    {
                        wynik *= j;
                    }

                    wynik %= 100;
                    if (wynik < 10)
                        Console.WriteLine("0 " + wynik);
                    else
                    {
                        
                        Console.WriteLine(wynik.ToString()[0]+" "+ wynik.ToString()[1]);
                    }
                    
                }
            }
        }
    }
}
