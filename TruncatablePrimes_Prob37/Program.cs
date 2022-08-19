using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TruncatablePrimes_Prob37
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmpVal = 2, iCount = 0,iSum = 0;
            bool bExitNow = false;
            while(!(bExitNow))
            {
                for (int i = 0; i < tmpVal.ToString().Length; i++)
                {
                    Thread a = new Thread();
                    if (!(Program.isPrime(tmpVal)))
                    {
                        iCount--;
                        break;
                    }
                    tmpVal = tmpVal.ToString().Length > 1 ? Program.numChanger(tmpVal) : tmpVal;
                }
                iCount++;
                if (iCount == 7)
                    bExitNow = true;
                else
                    tmpVal++;
            }
            Console.WriteLine(iCount);
        }
        public static int numChanger(int num)
        {
            
            int retValue = num, tmp;
            char[] tmpArr = retValue.ToString().ToArray();
            tmp = Convert.ToInt32(tmpArr[tmpArr.Length - 1]);
            for (int i = tmpArr.Length - 1; i > 0; i--)
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
