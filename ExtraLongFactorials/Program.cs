using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtraLongFactorials(25);
        }
        public static void ExtraLongFactorials(int n)
        {
            BigInteger result = new BigInteger(1);
            for (int i = 1; i <= n; i++)
                result *= i;
            Console.Write(result);
        }
    }
}
