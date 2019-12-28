using System;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Problem1
    {
        private Int32 _UpperLimit;

        public Int32 UpperLimit
        {
            get { return _UpperLimit; }
            set { _UpperLimit = value; }
        }

        public Problem1(Int32 upperLimit)
        {
            UpperLimit = upperLimit;
        }

        private Int32 SumDivisibleBy(int n)
        {
            return MathHelper.SumDivisibleBy(n, UpperLimit);
        }

        public Int32 Sum(params int[] numbers)
        {
            Int32 sum = 0;

            DateTime dt = DateTime.Now;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sum += SumDivisibleBy(numbers[i]);

                for (int j = i - 1; j >= 0; j--)
                {
                    sum -= SumDivisibleBy(numbers[i] * numbers[j]);
                }
            }

            Console.WriteLine(DateTime.Now - dt);

            dt = DateTime.Now;
            sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += SumDivisibleBy(numbers[i]);

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sum -= SumDivisibleBy(numbers[i] * numbers[j]);
                }
            }
            Console.WriteLine(DateTime.Now - dt);
            return sum;
        }
    }
}
