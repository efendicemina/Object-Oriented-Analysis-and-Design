using System;

namespace BrzinaBroda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite brzinu broda u cvorovima: ");
            string ulaz=Console.ReadLine();
            int brzina=Int32.Parse(ulaz);
            double brzina_kmh = brzina * 1.852;
            Console.WriteLine("Brzina broda u km/h: " + brzina_kmh);
        }
    }
}
