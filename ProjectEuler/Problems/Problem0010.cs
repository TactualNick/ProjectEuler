using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Extensions;

namespace ProjectEuler.Problems
{
    public class Problem0010
    {
        private const long TwoMillion = 2000000;

        public void Run()
        {
            long sum = 0;
            for (long i = 2; i < TwoMillion; i++)
            {
                if (!i.IsPrime()) continue;

                sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
