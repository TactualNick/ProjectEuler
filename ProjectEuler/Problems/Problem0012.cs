using System;

using ProjectEuler.Extensions;

namespace ProjectEuler.Problems
{
    public class Problem0012
    {
        public void Run()
        {
            var begin = DateTime.Now.Ticks;

            for (var i = 1; i > 0; i++)
            {
                var number = (i*(i + 1))/2;

                var factors = number.GetFactors();

                if (factors.Count < 500) continue;
                
                Console.WriteLine(number + ": " + factors.Count);
                break;
            }

            var end = DateTime.Now.Ticks;
            Console.WriteLine(end - begin);
            Console.ReadLine();
        }
    }
}