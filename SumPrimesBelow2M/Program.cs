using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumPrimesBelow2M
{
    class Program
    {
        static void Main(string[] args)
        {
            double iSum = 0,iCount = 0;
            for (double i = 2; i < 2000000; i++)
            {
                double iDivider = Math.Sqrt(i);
                for (double j = 2; j <= iDivider; j++)
                {
                    if (i % j == 0)
                    {
                        iCount++;
                        break;
                    }
                }
                if (iCount == 0)
                {
                    iSum += i;
                }
                else
                {
                    iCount = 0;
                }
            }
            Console.WriteLine(iSum);
        }
    }
}
