using System;
using System.Collections.Generic;
using System.Linq;

namespace ParniNeparni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 10 brojeva, razdvojeni zarezom: ");
            string ulaz = Console.ReadLine();
            string[] pojedinacni = ulaz.Split(",");
            List<int> brojevi = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                brojevi.Add(Int32.Parse(pojedinacni[i]));
            }
            if (brojevi.Any(broj => brojevi.Where(broj2 => broj2 % 2 != 0).ToList().Count > 5))
            {
                brojevi.RemoveAll(broj => broj % 2 == 0);
            }
            if (brojevi.Any(broj => brojevi.Where(broj2 => broj2 % 2 == 0).ToList().Count > 5))
            {
                brojevi.RemoveAll(broj => broj % 2 != 0);
            }
            int suma = brojevi.Sum();
            if (suma < 0) Console.WriteLine("Greska!");
            else
            {
                Console.WriteLine("Suma je: " + suma);
                Console.WriteLine("Preostali clanovi liste su: ");
                foreach (int i in brojevi)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
