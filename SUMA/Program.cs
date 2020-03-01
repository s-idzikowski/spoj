using System;


namespace SUMA
{
    class Program
    {
        static void Main()
        {
            int wynik = 0;

            poczatek:
            try
            {
                int wejscie = int.Parse(Console.ReadLine());
                wynik += wejscie;
                Console.WriteLine(wynik);
                goto poczatek;
            }
            catch (Exception)
            {
                return;
            }
  
        }
    }
}
