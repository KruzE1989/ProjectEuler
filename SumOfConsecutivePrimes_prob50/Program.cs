using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfConsecutivePrimes_prob50
{
    class Program
    {
        static void Main(string[] args)
        {
            double iStart = 2, PrimeSum = 0, bigSumPrime = 0;
            List<double> primes = new List<double>();
            while (iStart < 1000)
            {
                if (isPrime(iStart))
                {
                    primes.Add(iStart);
                }
                iStart++;
            }
            foreach (double item1 in primes)
            {
                PrimeSum = item1;
                foreach (double item2 in primes)
                {
                    if (item2 <= item1)
                    {
                        continue;
                    }
                    else if (PrimeSum > iStart)
                    {
                        break;
                    }
                    PrimeSum += item2;
                    foreach (double item3 in primes)
                    {
                        if (PrimeSum < item3)
                        {
                            break;
                        }
                        else if (PrimeSum == item3)
                        {
                            bigSumPrime = item3;
                        }
                    }
                }
                PrimeSum = 0;
            }
            Console.WriteLine(bigSumPrime);
        }
        public static bool isPrime(double num)
        {
            if (num == 1) return false;
            else if (num < 4) return true;
            else if (num % 2 == 0) return false;
            else if (num < 9) return true;
            else if (num % 3 == 0) return false;
            else
            {
                double r = Math.Floor(Math.Sqrt(num));
                double f = 5;
                while (f <= r)
                {
                    if (num % f == 0) return false;
                    else if (num % (f + 2) == 0) return false;
                    f = f + 6;
                }
            }
            return true;
        }
    }
}
