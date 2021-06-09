using System;
using System.Linq;

namespace ViralAdvertising
{
    class Program
    {
        //https://www.hackerrank.com/challenges/strange-advertising/problem
        static void Main(string[] args)
        {
            Console.WriteLine(ViralAdvertising(5));
        }
        public static int ViralAdvertising(int n)
        {
            int result = 2;
            int shared = 5;
            for (int i = 1; i < n; i++)
            {
                shared = shared / 2 * 3;
                result += shared /2;
            }
            return result;
        }
    }
}
