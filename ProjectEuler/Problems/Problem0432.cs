using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using ProjectEuler.Extensions;

namespace ProjectEuler.Problems
{
    public class Problem0432
    {
        private const long NumberConstant = 45480596821125120;

        public void Run()
        {
            var begin = DateTime.Now.Ticks;
            var numberPhi = new BigInteger(510510).Phi();

            var sum = new BigInteger(0);
            var max = new BigInteger(Math.Pow(10, 6));
            for (BigInteger i = 1; i <= max; i++)
            {
                sum += (510510*i).Phi();

                if(BigInteger.Remainder(i,new BigInteger(100000)) != BigInteger.Zero) continue;

                var sa = "hello";
            }

            var s = numberPhi*sum;
            Console.WriteLine(sum);
            var end = DateTime.Now.Ticks;
            Console.WriteLine("Seconds taken: " + Convert.ToString(new TimeSpan(end - begin).TotalSeconds));
            Console.ReadLine();
        }
    }
}