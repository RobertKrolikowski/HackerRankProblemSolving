using System;
using System.Collections.Generic;

namespace TheTimeinWords
{
    class Program
    {//https://www.hackerrank.com/challenges/the-time-in-words/problem
        static void Main(string[] args)
        {
            Console.WriteLine(TimeInWords(7, 29));
        }

        public static string TimeInWords(int h, int m)
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>  {
                {1,"one" },
                {2,"two" },
                {3,"three" },
                {4,"four" },
                {5,"five" },
                {6,"six" },
                {7,"seven" },
                {8,"eight" },
                {9,"nine" },
                {10,"ten" },
                {11,"eleven" },
                {12,"twelve" },
                {13,"thirteen" },
                {14,"fourteen" },
                {15,"quarter" },
                {16,"sixteen" },
                {17,"seventeen" },
                {18,"eighteen" },
                {19,"nineteen" },
                {20,"twenty" },
                {21,"twenty one" },
                {22,"twenty two" },
                {23,"twenty three" },
                {24,"twenty four" },
                {25,"twenty five" },
                {26,"twenty six" },
                {27,"twenty seven" },
                {28,"twenty eight" },
                {29,"twenty nine" },
                {30,"half" },
            };

            string result;
            if (m == 0)
                result = $"{numbers[h]} o' clock";
            else if (m == 15 || m == 30)
                result = $"{numbers[m]} past {numbers[h]}";
            else if (m <= 30)
                result = $"{numbers[m]} minute{(m == 1 ? "":"s")} past {numbers[h]}";
            else if (m == 45)
                result = $"{numbers[60 - m]} to {numbers[h + 1]}";
            else
                result = $"{numbers[60 - m]} minute{(m == 1 ? "":"s")} to {numbers[h+1]}";

            return result;
        }
    }
}
