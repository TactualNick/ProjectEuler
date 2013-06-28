using System;

namespace ProjectEuler.Problems
{
    public class Problem0009
    {
        public void Run()
        {
            var product = 0;
            var shouldBreak = false;
            for (var i = 1; i < 500; i++)
            {
                for (var j = 1; j < 500; j++)
                {
                    var cSquared = Math.Pow(i, 2) + Math.Pow(j, 2);
                    var c = Convert.ToInt32(Math.Sqrt(cSquared));

// ReSharper disable CompareOfFloatsByEqualityOperator
                    if (Math.Sqrt(cSquared) % 1 != 0) continue;
// ReSharper restore CompareOfFloatsByEqualityOperator

                    if (i + j + c > 1000)
                        break;

                    if (i + j + c != 1000) continue;

                    product = i*j*c;
                    shouldBreak = true;
                    break;
                }

                if (shouldBreak)
                    break;
            }

            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
