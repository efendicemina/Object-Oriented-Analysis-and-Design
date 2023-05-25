using System;

namespace SumaElemenata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj n: ");
            string ulaz=Console.ReadLine();
            int n = Int32.Parse(ulaz);
            int[,] matrica = new int[n, n];
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    matrica[i,j]= int.Parse(Console.ReadLine());
                }
            }
            int sumamax = 0, sumamin = int.MaxValue;
            int suma = 0;
            int maxk = 0;
            int mink = 0;
            int dijagonala = 0;
            for (int i = 0; i < n; i++)
            {
                suma = 0;
                for (int j = 0; j < n; j++)
                {
                    suma = suma + matrica[i, j];
                    if(i==j) dijagonala = dijagonala + matrica[i, j];
                }
                if (suma > sumamax)
                {
                    maxk = i;
                    sumamax = suma;
                }
                if (suma < sumamin)
                {
                    mink = i;
                    sumamin = suma;
                }
            }
            Console.WriteLine("Redni broj kolone s najvecom sumom: " + maxk);
            Console.WriteLine("Redni broj kolone s najmanjom sumom: " + mink);
            Console.WriteLine("Suma dijagonale: " + dijagonala);
        }
    }
}
