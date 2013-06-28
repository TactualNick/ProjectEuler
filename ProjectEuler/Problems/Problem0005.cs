using System;
using System.Collections.Generic;
using ProjectEuler.Extensions;

namespace ProjectEuler.Problems
{
    public class Problem0005
    {
        public void Run()
        {
            var factorList = new List<long>();
            long product = 1;

            for (long i = 20; i > 0; i--)
            {
                var tempList = new List<long>();
                tempList.AddRange(factorList);
                var factors = i.GetAllPrimeFactors();

                foreach (var factor in factors)
                {
                    if (tempList.Contains(factor))
                        tempList.Remove(factor);
                    else
                    {
                        factorList.Add(factor);
                        product *= factor;
                    }
                }
            }

            factorList.Sort();
            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
