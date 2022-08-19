using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrtstProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Millisecond);
            string strTest = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            int itemp = 1;
            int[] iarrNew = new int[1000];

            for (int i = 0; i < strTest.Length; i++)
            {
                iarrNew[i] = Convert.ToInt32(strTest.ElementAt(i).ToString());
            }
            for (int i = 0; i < iarrNew.Length - 4; i++)
            {
                var i_temp = (from val in iarrNew
                              select val).Skip(i).Take(5);
                foreach (var item in i_temp)
                {
                    itemp *= item;
                }
                iarrNew[i] = itemp;
                itemp = 1;
            }
            
            //for (int j = 0; j < iarrNew.Length; j++)
            //{
            //    int a1 = iarrNew[j], a2 = iarrNew[j + 1];
            //    int a3 = iarrNew[j + 2];
            //    int a4 = iarrNew[j + 3], a5 = iarrNew[j + 4];
            //    int a = a1 * a2 * a3 * a4 * a5;
            //    iarrNew[j] = a;
            //    if (j + 4 == 999)
            //    {
            //        break;
            //    }
            //}
            var i_new = (from val in iarrNew
                         orderby val descending
                         select val).Take(1);
            foreach (var item in i_new)
            {
                Console.WriteLine(item);    
            }
            Console.WriteLine(DateTime.Now.Millisecond);
        }
    }
}
