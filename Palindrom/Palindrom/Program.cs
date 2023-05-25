using System;

namespace Palindrom
{
    internal class Program
    {
        public static bool daLiJePalindrom(string str)
        {
            str = str.ToLower();
            string cleanstr="";
            foreach(char c in str)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    cleanstr += c;
                }
            }
            bool palindrom = true;
            int i = 0;
            int j = cleanstr.Length - 1;
            while (i < j)
            {
                if (cleanstr[i] != cleanstr[j]) palindrom = false;
                i++;
                j--;
            }
            return palindrom;
        }
        static void Main(string[] args)
        {
            string[] str = { "Ana voli Milovana!", "Ana!!", "nije palindrom" };
            foreach(string  str2 in str)
            {
                Console.WriteLine(daLiJePalindrom(str2));
            }
        }
    }
}
