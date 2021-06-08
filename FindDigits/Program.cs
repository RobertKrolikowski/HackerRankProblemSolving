using System;
using System.Linq;

namespace FindDigits
{
    class Program
    {
        //https://www.hackerrank.com/challenges/find-digits/problem
        static void Main(string[] args)
        {
            Console.WriteLine(FindDigits(124));
        }

        public static int FindDigits(int n)
        {
            return n.ToString().Where(x => x != '0' && n % (x - '0') == 0).Count();
        }
    }
}
