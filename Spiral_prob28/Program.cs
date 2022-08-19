using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spiral_prob28
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 2, counter = 0, i = 1, sum = 0;
            while (i < 1002002)
            {
                counter++;
                sum += i;
                i += index;
                if (counter == 4)
                {
                    index += 2;
                    counter = 0;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
