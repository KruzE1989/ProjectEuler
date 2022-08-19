using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combination_prob53
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (Combination(i, j) >= 1000000)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
        public static double Combination(int n, int r)
        {
            double Comb = 1;
            if (r > (n - r))
            {
                r = n - r;
            }
            if (r == 0 || r == n)
            {
                return 1.0;
            }
            Comb = Factorial(n) / (Factorial(r) * Factorial(n - r));
            return Comb;
        }
        public static double Factorial(int n)
        {
            double Fact = 1;
            if (n == 0 || n == 1)
            {
                return Fact;
            }
            for (int i = n; i > 1; i--)
            {
                Fact *= i;
            }
            return Fact;
        }
    }
}
