using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            bool iFound = true;
            double iStart = 2,iCounter1 = 0,iCounter2 = 0;
            while (iFound)
            {
                double iDivider = Math.Sqrt(iStart);
                for (int i = 2; i <= iDivider; i++)
                {
                    if (iStart % i == 0)
                    {
                        iCounter1++;
                        break;
                    }
                }
                if (iCounter1 == 0)
                {
                    iCounter2++;
                }
                else
                {
                    iCounter1 = 0;
                    iStart++;
                }
                if (iCounter2 == 1000000)
                {
                    iFound = false;
                }
            }
            Console.WriteLine(iStart);
            Console.WriteLine(DateTime.Now - dt);
        }
    }
}
