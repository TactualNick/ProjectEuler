using System;

namespace ProjectEuler.Problems
{
    public class Problem0001
    {
        public void Run()
        {
            var sum = 0;

            for (var i = 1; i < 1000; i++)
            {
                if (i%3 != 0 && i%5 != 0) continue;

                sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}