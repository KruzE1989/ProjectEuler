using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TriangleWords_prob42
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader objSR = new StreamReader(@"D:\Temp\ProjectEuler\TriangleWords_prob42\MyFile\words.txt");
            string[] a = objSR.ReadLine().Split(',');
            int count = 0;
            foreach (string item in a)
            {
                 if (isTriangleWord(item))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        private static int NameWorth(string a)
        {
            int Worth = 0;
            char[] b = a.ToUpper().ToCharArray();
            foreach (char c in b)
            {
                Worth += enumWorth(c);
            }
            return Worth;
        }
        private static int enumWorth(char a)
        {
            switch (a)
            {
                case 'A': return 1;
                case 'B': return 2;
                case 'C': return 3;
                case 'D': return 4;
                case 'E': return 5;
                case 'F': return 6;
                case 'G': return 7;
                case 'H': return 8;
                case 'I': return 9;
                case 'J': return 10;
                case 'K': return 11;
                case 'L': return 12;
                case 'M': return 13;
                case 'N': return 14;
                case 'O': return 15;
                case 'P': return 16;
                case 'Q': return 17;
                case 'R': return 18;
                case 'S': return 19;
                case 'T': return 20;
                case 'U': return 21;
                case 'V': return 22;
                case 'W': return 23;
                case 'X': return 24;
                case 'Y': return 25;
                case 'Z': return 26;
                default: return 0;
            }
        }

        private static bool isTriangleWord(string a)
        {
            int WordValue = NameWorth(a);
            double value = (Math.Sqrt(8 * WordValue + 1) - 1) / 2;
            if (value == Math.Floor(value))
            {
                return true;
            }
            return false;
        }
    }
}
