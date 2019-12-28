using System;

namespace ProjectEuler.Common
{
    internal static class MathHelper
    {
        /// <summary>
        /// Calculate the Fibonacci term for n using the formular of Moivre/Binet.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        internal static int FibonacciMoivreBinet(int n)
        {
            double sqrtFive = Math.Sqrt(5);
            double t1 = Math.Pow((1 + sqrtFive) / 2, (double)n);
            double t2 = Math.Pow((1 - sqrtFive) / 2, (double)n);
            return (int)((t1 - t2) / sqrtFive);
        }

        /// <summary>
        /// Calculate the sum of all natural numbers that can de divided by n up to the upperLimit.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="upperLimit"></param>
        /// <returns></returns>
        internal static int SumDivisibleBy(int n, int upperLimit)
        {
            int p = upperLimit / n;
            return n * (p * (p + 1)) / 2;
        }

        internal static int SumOfSquares(int upperLimit)
        {
            int i = (upperLimit * (upperLimit + 1) * (2 * upperLimit + 1)) / 6;
            return i;
        }
    }
}
