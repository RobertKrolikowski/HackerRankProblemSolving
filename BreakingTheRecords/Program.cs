using System;

namespace BreakingTheRecords
{
    class Program
    {
        //https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
        static void Main(string[] args)
        {
            BreakingRecords(new int[] { 4, 4, 21, 36, 10, 28, 35, 3, 24, 42 });
            
        }

        static int[] BreakingRecords(int[] scores)
        {
            int[] maxMin = { scores[0], scores[0] };
            int[] maxMinCount = { 0, 0 };
            foreach (int score in scores)
            {
                if (score > maxMin[0])
                {
                    maxMin[0] = score;
                    maxMinCount[0]++;
                }
                else if (score < maxMin[1])
                {
                    maxMin[1] = score;
                    maxMinCount[1]++;
                }
            }

            //Console.WriteLine($"{maxMinCount[0]} {maxMinCount[1]}");
            return maxMinCount;
        }
    }
}
