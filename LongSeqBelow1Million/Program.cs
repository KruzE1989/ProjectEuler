using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongSeqBelow1Million
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 2, startNum = num, counter1= 1,counter2 = 1;
            while (true)
            {
                while (num > 1)
                {
                    if (num % 2 == 0)
                    {
                        num /= 2;
                        counter1++;
                    }
                    else
                    {
                        num = (3 * num) + 1;
                        counter1++;
                    }
                }
                if (counter1 > counter2)
                {
                    counter2 = counter1;
                }
                counter1 = 1;
                if (num < Math.Pow(10, 6))
                {
                    num = startNum + 1;
                    startNum = num;
                }
                else
                {
                    break;
                }
                
            }
        }
    }
}
