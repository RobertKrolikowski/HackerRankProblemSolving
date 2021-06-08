using System;
using System.Collections.Generic;
using System.Linq;

namespace CutTheSticks
{
    class Program
    {
        //https://www.hackerrank.com/challenges/cut-the-sticks/problem
        static void Main(string[] args)
        {
            CutTheSticks(new List<int> { 5, 4, 4, 2, 2, 8 });
        }

        public static List<int> CutTheSticks(List<int> arr)
        {
            List<int> result = new List<int>();
            int min;
            do
            {
                min = arr.Min();
                result.Add(arr.Count);
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] != 0)
                        arr[i] -= min;
                }
                arr = arr.Where(x => x > 0).ToList();
            } while (arr.Count != 0);

            return result;
        }
    }
}
