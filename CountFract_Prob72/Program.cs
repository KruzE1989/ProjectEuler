using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountFract_Prob72
{
    class Program
    {
        static void Main(string[] args)
        {
            var intCollection = Enumerable.Range(1, 1000000).ToArray();
            var intCollection2 = Enumerable.Range(1, 1000000).ToArray();
            var out2 = intCollection.Select(; 
            var output = from i in intCollection where i < 100 select i;
            int iCount = 0;
            for (int i = 1; i <= 10000; i++)
            {
                for (int j = 1; j <= 10000; j++)
                {
                    if (i >= j) continue;
                    if (i < j && Program.getHCF(i, j) == 1) iCount++;
                }

            }
            Console.WriteLine(iCount);
        }

        public static int getHCF(int x, int y)
        {
            int a, b, t;

            a = x;
            b = y;

            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }

            return a;
        }
    }
}
