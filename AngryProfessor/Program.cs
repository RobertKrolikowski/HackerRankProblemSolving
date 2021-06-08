using System;
using System.Collections.Generic;
using System.Linq;

namespace AngryProfessor
{
    class Program
    {
        //https://www.hackerrank.com/challenges/angry-professor/problem
        static void Main(string[] args)
        {
            Console.WriteLine(AngryProfessor(4, new List<int>() { 0, -1, 2, 1 }));
        }

        public static string AngryProfessor(int k, List<int> a)
        {
            return a.Where(x => x <= 0).Count() < k ? "YES" : "NO";
        }
    }
}
