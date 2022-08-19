using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace LychrelNumber_prob55
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i < 10001; i++)
            {
                if (IsLychrel(i))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static bool IsLychrel(int i)
        {
            int iteration = 0;
            BigInteger retVal = ReverseAndAdd(i);
            while (iteration < 51)
            {
                if (Palindrome(retVal) == BigInteger.One)
                {
                    return false;
                }
                retVal = ReverseAndAdd(retVal);
                iteration++;
            }
            return true;
        }
        private static BigInteger ReverseAndAdd(BigInteger i)
        {
            return BigInteger.Add(BigInteger.Parse(i.ToString()),fnReverse(BigInteger.Parse(i.ToString())));            
        }
        private static BigInteger Palindrome(BigInteger n)
        {
            char[] b = n.ToString().ToCharArray();
            Array.Reverse(b);
            BigInteger a = BigInteger.Parse(new string(b));
            if (n == a)
            {
                return BigInteger.One;
            }
            return a;
        }
        private static BigInteger fnReverse(BigInteger n)
        {
            char[] b = n.ToString().ToCharArray();
            Array.Reverse(b);
            BigInteger a = BigInteger.Parse(new string(b));
            return a;
        }
    }
}
