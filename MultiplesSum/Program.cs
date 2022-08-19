using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplesSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 0, iSum = 0;
            Console.WriteLine("Enter a value: ");
            myInt = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < myInt; i++)
            {
                if (i % 3 == 0)
                {
                    iSum += i;
                }
                else if (i % 5 == 0)
                {
                    iSum += i;
                }
            }
            Console.WriteLine("The Sum Total of all the multiples of 3 and 5 between 1 and {0} is {1}", myInt, iSum);
        }
    }
}
