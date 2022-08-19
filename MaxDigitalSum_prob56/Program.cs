using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace MaxDigitalSum_prob56
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num;
            char[] a;
            int sum = 0, highestSum = 0;
            for (int i = 1; i < 101; i++)
            {
                for (int j = 1; j < 101; j++)
                {
                    num = BigInteger.Pow(i, j);
                    a = num.ToString().ToArray();
                    for (int k = 0; k < a.Length; k++)
                    {
                        sum += Convert.ToInt32(a[k].ToString());
                    }
                    highestSum = highestSum < sum ? sum : highestSum;
                    sum = 0;
                }
            }
            Console.WriteLine(highestSum);
        }
    }
}
