using System;

namespace ProjectEuler.Problems
{
    public class Problem0006
    {
        public void Run()
        {
            var sum = 0;
            var sumOfSquares = 0.0;

            for (var i = 1; i <= 100; i++)
            {
                sum += i;
                sumOfSquares += Math.Pow(i, 2);
            }

            Console.WriteLine(Math.Pow(sum, 2) - sumOfSquares);
            Console.ReadLine();
        }
    }
}
