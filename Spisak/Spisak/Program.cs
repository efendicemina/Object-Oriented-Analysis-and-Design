using System;
using System.Linq;

namespace Spisak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj rijeci: ");
            string ulaz=Console.ReadLine();
            int n=Int32.Parse(ulaz);
            string[] strings = new string[n];
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Unesite rijec: ");
                strings[i] = Console.ReadLine();
            }
            Array.Sort(strings);
            Console.WriteLine("Prva rijec sa spiska: " + strings[0]);
            Console.WriteLine("Posljednja rijec sa spiska: "+ strings[strings.Length-1]);
            Console.WriteLine("Spisak sa izbacenim duplikatima: ");
            strings = strings.Distinct().ToArray();
            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
