using System;

namespace PrvaKonzolnaAplikacija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unos brojeva
            Console.WriteLine("Unesite šest prirodnih brojeva (razdvojenih zarezom):");
            string ulaz = Console.ReadLine();

            // razdvajanje unosa na pojedinačne brojeve
            string[] pojedinacniUlazi = ulaz.Split(",");

            // pretvaranje string brojeva u cijele brojeve (int)
            int[] brojevi = new int[6];
            for (int i = 0; i < 6; i++)
                brojevi[i] = Int32.Parse(pojedinacniUlazi[i]);

            // obrada podataka
            bool pozitivni = true;
            int[] neparni = new int[6];
            int brojNeparnih = 0;

            // prolazak kroz sve elemente niza
            foreach (var element in brojevi)
            {
                if (element <= 0)
                    pozitivni = false;

                if (element % 2 != 0)
                {
                    neparni[brojNeparnih] = element;
                    brojNeparnih++;
                }
            }

            // prikaz rezultata
            string prikaz = pozitivni == true ? "nema" : "ima";
            Console.WriteLine("  Među unesenim brojevima " + prikaz + " negativnih brojeva.");
            Console.WriteLine("  Neparni brojevi: " + string.Join(" ", neparni[0..brojNeparnih]));
        }
    }
}