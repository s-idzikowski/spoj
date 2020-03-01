using System;

namespace POTSAM
{
    class Program
    {
        static void Main()
        {
            string linia = Console.ReadLine();
            string[] tab = linia.Split(' ');

            Console.WriteLine(Int32.Parse(tab[0]) * Int32.Parse(tab[1]) + Int32.Parse(tab[2]) * Int32.Parse(tab[3]));
        }
    }
}
