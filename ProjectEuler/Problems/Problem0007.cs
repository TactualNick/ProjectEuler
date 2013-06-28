using System;
using System.Collections.Generic;
using ProjectEuler.Extensions;

namespace ProjectEuler.Problems
{
    public class Problem0007
    {
        public void Run()
        {
            var primes = new List<int>();

            for (var i = 1; i > 0; i += 2)
            {
                if(i.IsPrime())
                    primes.Add(i);

                if (primes.Count < 10000) continue;

                Console.WriteLine(i);
                break;
            }

            Console.ReadLine();
        }
    }
}
