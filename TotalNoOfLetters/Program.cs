using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalNoOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0, count7 = 0, count8 = 0, count9 = 0;
            for (int i = 1; i < 1001; i++)
            {
                //switch (i % 10)
                //{
                //    case 1: count1++;
                //        break;
                //    case 2: count2++;
                //        break;
                //    case 3: count3++;
                //        break;
                //    case 4: count4++;
                //        break;
                //    case 5: count5++;
                //        break;
                //    case 6: count6++;
                //        break;
                //    case 7: count7++;
                //        break;
                //    case 8: count8++;
                //        break;
                //    case 9: count9++;
                //        break;
                //}
                switch (i % 10)
                {
                    case 1: count1++;
                        break;
                    case 2: count2++;
                        break;
                    case 3: count3++;
                        break;
                    case 4: count4++;
                        break;
                    case 5: count5++;
                        break;
                    case 6: count6++;
                        break;
                    case 7: count7++;
                        break;
                    case 8: count8++;
                        break;
                    case 9: count9++;
                        break;
                }
            }
            Console.WriteLine(count1 + " " + count2 + " " + count3 + " " + count4 + " " + count5 + " " + count6 + " " + count7 + " " + count8 + " " + count9);
        }
    }
}
