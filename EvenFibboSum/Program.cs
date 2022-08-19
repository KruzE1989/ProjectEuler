using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenFibboSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int iInt1 = 1, iInt2 = 2, iInt3 = 0, iSum = 0;
            while(iInt3 < 4000000)
            {
                iInt3 = iInt1 + iInt2;
                if (iInt2 % 2 == 0)
                {
                    iSum += iInt2;
                }
                iInt1 = iInt2;
                iInt2 = iInt3;
                    
            }
            Console.WriteLine(iSum);
        }
    }
}
