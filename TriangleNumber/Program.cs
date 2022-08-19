using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace TriangleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger iNum = BigInteger.Parse("1");
            //int Log = Convert.ToInt32(Math.Ceiling(BigInteger.Log(iNum,2)));
            BigInteger iTill;
            //double iStart = 44721359552, count = 0, iNext = 2,number;
            int count = 0;
            while (true)
            {
                iNum = (iNum * (iNum + 1)) / 2;
                iTill = iNum / 2;
                //iTill = iStart / 2;
                for (BigInteger i = 1; i <= iTill; i++)
                {
                    if (BigInteger.Remainder(iNum, i) == 0)
                    {
                        count++;
                    }
                }

                if (count >= 499)
                {
                    break;
                }
                else
                {
                    iNum += 1;
                    count = 0;
                }
                //istart = 12500012500003.0;
                //inext = 5000003.0;
                //{
                    //iStart += iNext;
                    //iNext++;
                    //if (iStart > Math.Pow(10,21))
                    //{
                    //    break;
                    //}
                //    count = 0;
                //}
            }
            
            //Console.WriteLine(GetDivisors(1000000000).Count());
            Console.WriteLine("Number is {0:0}",iNum);
        }
        static IEnumerable<int> GetDivisors(int n)
        {
            return from a in Enumerable.Range(2, n / 2)
                   where n % a == 0
                   select a;
        }
    }
}
