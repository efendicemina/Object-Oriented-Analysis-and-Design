using System;

namespace JednakostranicniTrougao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj n:");
            string ulaz=Console.ReadLine();
            int n=Int32.Parse(ulaz);
            int k = 1;
            int l = 1;
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n-k; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<l; j++)
                {
                    Console.Write("*");                }
                for(int j=0; n<n-k; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
                k++;
                l=l+2;
            }
        }
    }
}
