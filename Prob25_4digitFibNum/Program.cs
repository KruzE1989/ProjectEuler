using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Prob25_4digitFibNum
{
    class Program
    {
        int count = 0;
        static BigInteger Pow10 = BigInteger.Pow(10, 999);
        static void Main(string[] args)
        {
            Program a = new Program();
            int b = a.fibo(1,1,0);
            Console.WriteLine(b);
        }
        public int fibo(BigInteger n1, BigInteger n2, BigInteger sum)
        {
            if (sum < Pow10)
            {
                count++;
                sum = n1+n2;
                n1 = n2;
                n2 = sum;
                fibo(n1,n2,sum);
            }
            return count;
        }
    }
}
