using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace SumOfDigits_2Pow1000_
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger pow = new BigInteger();
            int sum = 0;
            pow = BigInteger.Pow(2, 1000);
            char[] a = pow.ToString().ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                sum += Convert.ToInt32(a[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
