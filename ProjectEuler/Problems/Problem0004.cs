using System;
using System.Collections.Generic;
using ProjectEuler.Extensions;

namespace ProjectEuler.Problems
{
    public class Problem0004
    {
        public void Run()
        {
            var palindromeList = new List<int>();

            for (var i = 999; i > 0; i--)
            {
                for (var j = 999; j > 0; j--)
                {
                    var product = i*j;
                    if (!product.IsPalindrome()) continue;

                    palindromeList.Add(product);
                    break;
                }
            }

            palindromeList.Sort();
            palindromeList.Reverse();

            Console.WriteLine(palindromeList[0]);
            Console.ReadLine();
        }
    }
}
