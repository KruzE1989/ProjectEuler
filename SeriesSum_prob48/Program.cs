using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace SeriesSum_prob48
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = new BigInteger();
            for (int i = 1; i < 1001; i++)
            {
                a += BigInteger.Pow(i, i);
            }
            Console.WriteLine("Last 10 digits {0}", a.ToString().Substring(a.ToString().Length - 10));
        }
    }
}
