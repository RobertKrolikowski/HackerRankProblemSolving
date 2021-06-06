using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            arr.Add(new List<int> { 1, 2, 3 });
            arr.Add(new List<int> { 4, 5, 6 });
            arr.Add(new List<int> { 7, 8, 9 });

            Console.WriteLine(DiagonalDifference(arr));
        }
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int a = arr[0][0];
            int digit1 = 0, digit2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                digit1 += arr[i][i];
                digit2 += arr[i][arr.Count - i - 1];
            }
            return Math.Abs(digit1 - digit2);
        }
    }
}
