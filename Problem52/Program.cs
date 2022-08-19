using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem52
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double a = 10, Prd,A,c;
            char[] b, arranedA;
            while (count != 2)
            {
                arranedA = a.ToString().ToCharArray();
                Array.Sort(arranedA);
                A = Convert.ToInt32(new string(arranedA));
                for (int i = 3; i < 4; i++)
                {
                    Prd = a * i;
                    b = Prd.ToString().ToArray();
                    Array.Sort(b);
                    c = Convert.ToInt32(new string(b));
                    if (c / a < 1)
                    {
                        continue;
                    }
                    if (c == A)
                    {
                        count++;
                    }
                }
                a++;
            }
            Console.WriteLine(a-1);
        }
    }
}
