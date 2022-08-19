using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int dProd = 0;
            List<int> lProd = new List<int>();
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    dProd = i * j;
                    if (chkPalindrome(dProd))
                    {
                        lProd.Add(dProd);
                    }                    
                }
            }
            lProd.Sort();
            Console.WriteLine(lProd[lProd.Count - 1]);
        }
        static bool chkPalindrome(int a)
        {
            int len = a.ToString().ToCharArray().Length, i = 0,b = a;
            StringBuilder strNew = new StringBuilder();
            int[] ArrNew = new int[len];
            do
            {
                ArrNew[i] = b % 10;
                b /= 10;
                i++;
            } while (b != 0);
            for (int j = 0; j < ArrNew.Length; j++)
            {
                strNew.Append(ArrNew[j]);
            }
            b = Convert.ToInt32(strNew.ToString());
            if (b == a)
            {
                return true;
            }
            return false;
        }
    }
}
