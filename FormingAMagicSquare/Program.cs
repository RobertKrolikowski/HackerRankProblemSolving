using System;
using System.Collections.Generic;

namespace FormingAMagicSquare
{
    class Program
    {
        //https://www.hackerrank.com/challenges/magic-square-forming/problem
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            arr.Add(new List<int> { 5, 3, 4 });
            arr.Add(new List<int> { 1, 5, 8 });
            arr.Add(new List<int> { 6, 4, 2 });
            FormingMagicSquare(arr);
        }
        public static int FormingMagicSquare(List<List<int>> s)
        {
            int result = 0;
            for (int i = 0; i < s.Count; i++)
            {
                for (int j = 0; j < s.Count; j++)
                {
                    if (s[i][0] + s[i][1] + s[i][2] != 15)
                    {
                        result += Math.Abs( 15 - (s[i][0] + s[i][1] + s[i][2]));
                        s[i][j] += 15 - (s[i][0] + s[i][1] + s[i][2]);
                    }
                    else if (s[0][j] + s[1][j] + s[2][j] != 15)
                    {
                        result += Math.Abs(15 - (s[0][j] + s[1][j] + s[2][j]));
                        s[i][j] += 15 - (s[0][j] + s[1][j] + s[2][j]);
                    }
                }
            }

            return result;
        }
    }
}
