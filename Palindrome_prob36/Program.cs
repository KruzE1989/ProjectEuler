using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Palindrome_prob36
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 1, sum = 0;
            BigInteger b;
            while (a<1000001)
            {
                b = BigInteger.Parse(Convert.ToString(a, 2));
                if (isPalindrome(a) && isPalindrome(b))
                {
                    sum += (a);
                    Console.WriteLine(a);
                }
                //if (isPalindrome(a))
                //{
                //    Console.WriteLine("{0} - {1}", a, b);
                //}
                a++;
            }
            Console.WriteLine(sum);
        }
        public static bool isPalindrome(BigInteger n)
        {
            char[] b = n.ToString().ToCharArray();
            Array.Reverse(b);
            BigInteger a = BigInteger.Parse(new string(b));
            if (n == a)
            {
                return true;
            }
            return false;
        }
    }
}
