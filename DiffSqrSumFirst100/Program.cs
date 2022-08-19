using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffSqrSumFirst100
{
    class Program
    {
        static void Main(string[] args)
        {
            double dSqr = 0, dSum = 0,dDiff = 0;
            for (int i = 1; i < 101; i++)
            {
                dSqr += i * i;
                dSum += i;
            }
            dSum = dSum * dSum;
            dDiff = dSum - dSqr;
            Console.WriteLine(dDiff);
        }
    }
}
