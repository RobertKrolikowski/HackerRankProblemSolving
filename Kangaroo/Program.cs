using System;

namespace Kangaroo
{
    class Program
    {
        //https://www.hackerrank.com/challenges/kangaroo/problem
        static void Main(string[] args)
        {
            Console.WriteLine(Kangaroo(0, 2, 5, 3));
        }
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            do
            {
                x1 += v1;
                x2 += v2;
                if (x1 == x2)
                    return "YES";

            } while ((x1 < x2 && v1 > v2)||(x1 > x2 && v1 < v2));
            return "NO";
        }
    }
}
