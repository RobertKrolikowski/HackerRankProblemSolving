using System;
using System.Collections.Generic;

namespace DivisibleSumPairs
{
    class Program
    {
        //https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
        static void Main(string[] args)
        {
            Console.WriteLine(divisibleSumPairs(6,3,new List<int> { 1 ,3, 2, 6, 1, 2 }));
        }
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int result = 0;
            for(int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                    if (i != j && (ar[j] + ar[i]) % k == 0)
                        result++;
            return result;
        }
    }
}
