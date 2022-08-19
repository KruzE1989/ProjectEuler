using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountSundays_Prob19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime objDate = DateTime.Parse("1-1-1901");
            int iCount = 0;
            DateTime endDate = Convert.ToDateTime("12-31-2000");
            while (objDate.Date < endDate)
            {
                if (objDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    iCount++;
                }
                objDate = objDate.AddMonths(1);
            }
            Console.WriteLine(iCount);
        }
    }
}
