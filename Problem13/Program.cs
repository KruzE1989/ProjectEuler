using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Numerics;
using System.IO;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rdr = new StreamReader(@"C:\Documents and Settings\neerav_patel\Desktop\100digits.txt");
            string line;
            BigInteger a = new BigInteger();
            while ((line = rdr.ReadLine()) != null)
            {
                a += BigInteger.Parse(line);
            }

            Console.WriteLine("{0}",a.ToString().Substring(0,10));
        }
    }
}
