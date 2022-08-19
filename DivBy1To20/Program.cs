using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivBy1To20
{
    class Program
    {
        static void Main(string[] args)
        {
            int iFound = 0, iStart = 1;
            while (iFound == 0)
            {
                int iCount = 0;
                for (int i = 2; i < 21; i++)
                {
                    if (iStart % i != 0)
                    {
                        iStart++;
                        break;
                    }
                    else
                    {
                        iCount++; 
                        continue;
                    }
                }
                if (iCount == 19)
                {
                    iFound = 1;
                }
            }
            Console.WriteLine(iStart);
        }
    }
}
