using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ETF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>() {"Emina", "tf", "abc","zzzz" ,"eetf","etf","etf","Emina","tf","abc"};
            int brojIspred = list.Count(str => str.CompareTo("etf")<0);
            Console.WriteLine("Broj stringova koji su abecedno ispred etf: "+brojIspred);
            int brojIstih = list.Count(str => str.CompareTo("etf") == 0);
            Console.WriteLine("Broj stringova koji su jednaki etf: " + brojIstih);
            int brojJednakiUnutarListe =  list.Count()-list.Distinct().Count();
            Console.WriteLine("Broj stringova koji su jednaki unutar liste: " + brojJednakiUnutarListe);
        }
    }
}
