using System;

namespace ProjectEuler.Problems
{
    public class Problem0002
    {
        private const long FourMillion = 4000000;

        public void Run()
        {
            var low = 1;
            var high = 1;
            var sum = 0;

            while (high <= FourMillion)
            {
                if (high%2 == 0)
                    sum += high;

                var oldHigh = high;
                high = low + high;
                low = oldHigh;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}