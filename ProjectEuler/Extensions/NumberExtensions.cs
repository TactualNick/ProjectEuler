using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Extensions
{
    public static class NumberExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number < 3)
            {
                return number != 1;
            }

            if (number % 2 == 0)
                return false;

            var root = Math.Sqrt(number) + 1;
            for (var i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static List<int> GetFactors(this int number)
        {
            var factors = new List<int>();

            var root = (int)Math.Sqrt(number);
            for (var j = 1; j <= root; j++)
            {
                if (number % j != 0) continue;

                factors.Add(j);
                if (j != number / j)
                {
                    factors.Add(number / j);
                }
            }

            return factors;
        }

        public static List<int> GetAllPrimeFactors(this int number)
        {
            var factors = new List<int>();

            var root = (int)Math.Sqrt(number);
            for (var j = 1; j <= root; j++)
            {
                if (number % j != 0) continue;

                if (j.IsPrime())
                    factors.Add(j);
                else if(j != number)
                    factors.AddRange(j.GetAllPrimeFactors());

                if ((number/j).IsPrime())
                    factors.Add(number/j);
                else if ((number / j) != number)
                    factors.AddRange((number/j).GetAllPrimeFactors());

                if (factors.Aggregate(1, (current, factor) => current*factor) == number)
                    break;
            }

            return factors;
        }

        public static List<int> GetDistinctPrimeFactors(this int number)
        {
            var factors = new List<int>();

            var root = (int)Math.Sqrt(number);
            for (var j = 1; j <= root; j++)
            {
                if (number % j != 0) continue;

                if (j.IsPrime())
                    factors.Add(j);
                else if (j != number)
                    factors.AddRange(j.GetAllPrimeFactors());

                if ((number / j).IsPrime())
                    factors.Add(number / j);
                else if ((number / j) != number)
                    factors.AddRange((number / j).GetAllPrimeFactors());

                if (factors.Aggregate(1, (current, factor) => current * factor) == number)
                    break;
            }

            return factors.Distinct().ToList();
        }

        public static int Phi(this int number)
        {
            var product = number.GetDistinctPrimeFactors().Aggregate<int, double>(1, (current, factor) => current*Convert.ToDouble(1.0 - 1.0/factor));
            return Convert.ToInt32(Convert.ToDouble(number)*product);
        }

        public static bool IsPalindrome(this int number)
        {
            var numberStr = Convert.ToString(number);
            var strArr = new string[numberStr.Length];

            for (var i = 0; i < numberStr.Length; i++)
                strArr[i] = numberStr.Substring(i, 1);

            var reversedString = numberStr.Select((t, i) => numberStr.Length - 1 - i).Aggregate("", (current, index) => current + strArr[index]);

            return reversedString.Equals(numberStr);
        }

        public static bool IsPrime(this long number)
        {
            if (number < 3)
            {
                return number != 1;
            }

            if (number%2 == 0)
                return false;

            var root = Math.Sqrt(number) + 1;
            for (var i = 3; i <= root; i += 2)
            {
                if (number%i == 0) return false;
            }

            return true;
        }

        public static List<long> GetFactors(this long number)
        {
            var factors = new List<long>();

            var root = (int)Math.Sqrt(number);
            for (var j = 1; j <= root; j++)
            {
                if (number % j != 0) continue;

                factors.Add(j);
                if (j != number / j)
                {
                    factors.Add(number / j);
                }
            }

            return factors;
        }

        public static List<long> GetAllPrimeFactors(this long number)
        {
            var factors = new List<long>();

            var root = (long)Math.Sqrt(number);
            for (long j = 1; j <= root; j++)
            {
                if (number % j != 0) continue;

                if (j.IsPrime())
                    factors.Add(j);
                else if (j != number)
                    factors.AddRange(j.GetAllPrimeFactors());

                if ((number / j).IsPrime())
                    factors.Add(number / j);
                else if ((number / j) != number)
                    factors.AddRange((number / j).GetAllPrimeFactors());

                if (factors.Aggregate<long, long>(1, (current, factor) => current*factor) == number)
                    break;
            }

            return factors;
        }

        public static List<long> GetDistinctPrimeFactors(this long number)
        {
            var factors = new List<long>();

            var root = (int)Math.Sqrt(number);
            for (long j = 1; j <= root; j++)
            {
                if (number % j != 0) continue;

                if (j.IsPrime())
                    factors.Add(j);
                else if (j != number)
                    factors.AddRange(j.GetAllPrimeFactors());

                if ((number / j).IsPrime())
                    factors.Add(number / j);
                else if ((number / j) != number)
                    factors.AddRange((number / j).GetAllPrimeFactors());

                if (factors.Aggregate<long,long>(1, (current, factor) => current * factor) == number)
                    break;
            }

            return factors.Distinct().ToList();
        }

        public static long Phi(this long number)
        {
            var product = number.GetDistinctPrimeFactors().Aggregate<long, double>(1, (current, factor) => current * Convert.ToDouble(1.0 - 1.0 / factor));
            return Convert.ToInt64(Convert.ToDouble(number) * product);
        }

        public static bool IsPrime(this BigInteger number)
        {
            if (number < 3)
            {
                return number != 1;
            }

            if (number % 2 == 0)
                return false;

            var root = Math.Sqrt(Convert.ToDouble(number.ToString())) + 1;
            for (var i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static List<long> GetAllPrimeFactors(this BigInteger number)
        {
            var factors = new List<long>();

            var root = (long)Math.Sqrt(Convert.ToDouble(number.ToString()));
            for (long j = 1; j <= root; j++)
            {
                if (number % j != 0) continue;

                if (j.IsPrime())
                    factors.Add(j);
                else if (j != number)
                    factors.AddRange(j.GetAllPrimeFactors());

                if ((number / j).IsPrime())
                    factors.Add(Convert.ToInt64((number / j).ToString()));
                else if ((number / j) != number)
                    factors.AddRange((number / j).GetAllPrimeFactors());

                if (factors.Aggregate<long, long>(1, (current, factor) => current * factor) == number)
                    break;
            }

            return factors;
        }

        public static List<long> GetDistinctPrimeFactors(this BigInteger number)
        {
            var factors = new List<long>();

            var root = (int)Math.Sqrt(Convert.ToDouble(number.ToString()));
            for (long j = 1; j <= root; j++)
            {
                if (number % j != 0) continue;

                if (j.IsPrime())
                    factors.Add(j);
                else if (j != number)
                    factors.AddRange(j.GetAllPrimeFactors());

                if ((number / j).IsPrime())
                    factors.Add(Convert.ToInt64((number / j).ToString()));
                else if ((number / j) != number)
                    factors.AddRange((number / j).GetAllPrimeFactors());

                if (factors.Aggregate<long, long>(1, (current, factor) => current * factor) == number)
                    break;
            }

            return factors.Distinct().ToList();
        }

        public static BigInteger Phi(this BigInteger number)
        {
            var product = number.GetDistinctPrimeFactors().Aggregate<long, double>(1, (current, factor) => current * Convert.ToDouble(1.0 - 1.0 / factor));
            return new BigInteger(Convert.ToDouble(number.ToString()) * product);
        }
    }
}
