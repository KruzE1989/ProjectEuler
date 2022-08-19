using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CirclePrimes_Prob35
{
    class Program
    {
        static void Main(string[] args)
        {
            var numSeries = Enumerable.Range(2, 1000000);
            int tmpVal, iCount = 0;
            foreach (int item in numSeries)
            {
                tmpVal = item;
                for (int i = 0; i < tmpVal.ToString().Length; i++)
                {
                    if (!(Program.isPrime(tmpVal)))
                    {
                        iCount--;
                        break;
                    }
                    tmpVal = tmpVal.ToString().Length > 1 ? Program.circleDigit(tmpVal) : tmpVal;
                }
                iCount++;
            }
            Console.WriteLine(iCount);
        }
        public static int circleDigit(int num)
        {
            int retValue = num, tmp;
            char[] tmpArr = retValue.ToString().ToArray();
            tmp = Convert.ToInt32(tmpArr[tmpArr.Length - 1]);
            for (int i = tmpArr.Length - 1; i > 0 ; i--)
            {
                tmpArr[i] = tmpArr[i - 1];
            }
            tmpArr[0] = Convert.ToChar(tmp);
            return Convert.ToInt32(new string(tmpArr));
        }
        public static bool isPrime(int num)
        {
            double iDivider = Math.Sqrt(num);
            for (int i = 2; i <= iDivider; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
