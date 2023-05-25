using System;
using System.Collections.Generic;
using System.Linq;

namespace ToSortedArray
{
    internal class Program
    {
        public static List<String> toSortedArray(List<String> list)
        {
            list=list.OrderBy(x => x.Length).ToList();
            return list;
        }
        static void Main(string[] args)
        {
            List<String> strings = new List<String>() { "Emina", "Nedim", "Hana", "Tajra", "Senadin" };
            strings=toSortedArray(strings);
            foreach (String s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
