using System;

namespace BeautifulDaysattheMovies
{
    class Program
    {//https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem
        static void Main(string[] args)
        {
            Console.WriteLine(BeautifulDays(1, 2000000, 23047885));
        }

        public static int BeautifulDays(int i, int j, int k)
        {
            int result = 0; 
            float reverse = 0;
            for (int a = i; a <= j; a++)
            {
                //char[] charArray = a.ToString().ToCharArray();
                //Array.Reverse(charArray);
                //reverse = float.Parse(charArray);
                int buff = a;
                string buff1 = "";
                do
                {
                    buff1 += (buff % 10).ToString();
                    buff = buff / 10;
                } while (buff > 0);
                reverse =float.Parse( buff1);
                if (Math.Abs(reverse - a) / k % 1 == 0)
                    result++;
            }

            return result;
        }
    }
}
