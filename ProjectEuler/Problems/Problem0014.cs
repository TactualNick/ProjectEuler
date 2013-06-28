using System;

namespace ProjectEuler.Problems
{
    public class Problem0014
    {
        private long _numberIterations;
        private const long OneMillion = 1000000;

        public void Run()
        {
            long maxIterations = 0;
            long numberWithMaxIterations = 0;
            for (var i = 1; i < OneMillion; i++)
            {
                _numberIterations = 0;
                ComputeSequence(i);

                if (_numberIterations <= maxIterations) continue;
                maxIterations = _numberIterations;
                numberWithMaxIterations = i;
            }

            Console.WriteLine("Number: " + numberWithMaxIterations);
            Console.WriteLine("Number of Iterations: " + maxIterations);
            Console.ReadLine();
        }

        private void ComputeSequence(long n)
        {
            if (n%2 == 0)
            {
                _numberIterations++;
                var newN = SequenceIfEven(n);
                ComputeSequence(newN);
            }
            else if (n != 1)
            {
                _numberIterations++;
                var newN = SequenceIfOdd(n);
                ComputeSequence(newN);
            }
        }

        private static long SequenceIfOdd(long n)
        {
            return 3*n + 1;
        }

        private static long SequenceIfEven(long n)
        {
            return n/2;
        }
    }
}