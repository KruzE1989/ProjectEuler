using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Champernowne_Constant_prob40
{
    class Program
    {
        static void Main(string[] args)
        {    
            List<int> checkDigits = new List<int>();
            checkDigits.Add(1);
            checkDigits.Add(10);
            checkDigits.Add(100);
            checkDigits.Add(1000);
            checkDigits.Add(10000);
            checkDigits.Add(100000);
            checkDigits.Add(1000000);
            Console.WriteLine(DateTime.Now.TimeOfDay);
            int result = 1;
            StringBuilder digits = new StringBuilder();

            for (int i = 1; i <= checkDigits.Max(); i++)
            {
                digits.Append(i);

                if (checkDigits.Contains(i))
                    result *= int.Parse(digits[i - 1].ToString());
            }
            Console.WriteLine(result);
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }
    }
}
