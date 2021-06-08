using System;

namespace UtopianTree
{
    class Program
    {
        //https://www.hackerrank.com/challenges/utopian-tree/problem
        static void Main(string[] args)
        {
            Console.WriteLine(UtopianTree(5));
        }

        public static int UtopianTree(int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    result = result * 2;
                else
                    result++;
            }
            return result;
        }
    }
}
