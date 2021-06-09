using System;

namespace ElectronicsShop
{
    class Program
    {
        //https://www.hackerrank.com/challenges/electronics-shop/problem
        static void Main(string[] args)
        {
            Console.WriteLine(GetMoneySpent(new[] { 92,8 },new[]{ 7, 2, 8 },10));
        }

        static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int max = -1;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int sum = keyboards[i] + drives[j];
                    if (max < sum && sum <= b)
                        max = sum;

                }
            }

            return max;
        }
    }
}
