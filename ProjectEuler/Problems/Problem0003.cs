using System;
using System.Linq;
using ProjectEuler.Extensions;

namespace ProjectEuler.Problems
{
    public class Problem0003
    {
        private const long Number = 600851475143;

        public void Run()
        {
            long[] prime = {0};
            var factors = Number.GetFactors();
            factors.Sort();
            factors.Reverse();

            foreach (var factor in factors.Where(factor => factor.IsPrime() && factor > prime[0]))
            {
                prime[0] = factor;
                break;
            }

            Console.WriteLine(prime[0]);
            Console.ReadLine();
        }
    }
}