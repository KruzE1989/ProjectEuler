using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace IntComb_prob29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> distValues = new List<BigInteger>();
            for (int i = 2; i < 101; i++)
            {
                for (int j = 2; j < 101; j++)
                {
                    if (distValues.IndexOf(BigInteger.Pow(i, j)) == -1)
                    {
                        distValues.Add(BigInteger.Pow(i, j));
                    }
                }
            }

            Console.WriteLine(distValues.Count);
            //BigInteger a = 228433;
            //BigInteger b = BigInteger.Pow(2, 7830457);
            //BigInteger c = BigInteger.Multiply(a, b);
            //c += 1;
            //Console.WriteLine(c.ToString().Length);
        }
    }
}
