using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem34
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3, sum = 0,factSum = 0;
            char[] x;
            while (i < 10000000)
            {
                x = i.ToString().ToCharArray();
                foreach (char item in x)
                {
                    factSum += Factorial(Convert.ToInt32(Convert.ToString(item)));
                }
                if (i == factSum)
                {
                    sum += i;
                }
                Array.Clear(x, 0, x.Length);
                factSum = 0;
                i++;
            }
            Console.WriteLine(sum);
        }
        private static int Factorial(int n)
        {
            int Fact = 1;

            for (int i = n; i > 0; i--)
            {
                Fact *= i;
            }
            return Fact;
        }
    }
}
