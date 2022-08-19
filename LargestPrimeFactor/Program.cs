using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lDouble = new List<double>();
            double sqrt = Math.Sqrt(600851475143);
            for (double i = 2; i < sqrt; i++)
            {
                if (600851475143 % i == 0)
                {
                    lDouble.Add(i);
                }
            }
            for (int i = 0; i < lDouble.Count; i++)
            {
                int icount = 0;
                for (int j = 2; j < lDouble.ElementAt(i); j++)
                {
                    if (lDouble.ElementAt(i) % j == 0)
                    {
                        icount++;
                    }
                }
                if (icount > 0)
                {
                    lDouble.Remove(lDouble.ElementAt(i));
                    i--;
                }
            }
            foreach (double item in lDouble)
            {
                Console.WriteLine(item);
            }

        }
    }
}
