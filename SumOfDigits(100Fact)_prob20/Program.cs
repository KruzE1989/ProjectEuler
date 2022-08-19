using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace SumOfDigits_100Fact__prob20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a=10, b=1, c = 1;
            long sum = 0;
            for (BigInteger i = 0; i < 100; i++)
            {
                b *= c;
                c++;

            }
            char[] x = b.ToString().ToCharArray();
            for (int i = 0; i < x.Length; i++)
            {
                sum += Convert.ToInt32(x[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
