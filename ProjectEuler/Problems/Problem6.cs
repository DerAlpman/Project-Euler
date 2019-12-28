using System;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 12 + 22 + ... + 102 = 385
    ///
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)2 = 552 = 3025
    ///
    /// Hence the difference between the sum of the squares of the 
    /// first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    ///
    /// Find the difference between the sum of the squares of the 
    /// first one hundred natural numbers and the square of the sum.
    /// </summary>
    public class Problem6
    {
        private int _N;

        public int N
        {
            get { return _N; }
            set { _N = value; }
        }

        public Problem6(int n)
        {
            N = n;
        }

        private double SumSquares()
        {
            double s = 0;

            for (int i = 1; i <= N; i++)
            {
                s += Math.Pow(i, 2);
            }

            return MathHelper.SumOfSquares(N);
        }

        private double SquareSum()
        {
            return Math.Pow(MathHelper.SumDivisibleBy(1, N), 2);
        }

        public double Difference()
        {
            return SquareSum() - SumSquares();
        }
    }
}
