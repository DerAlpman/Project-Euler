using System.Collections.Generic;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    ///
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class Problem3
    {
        private readonly SieveOfAtkin _Sieve;
        public Problem3(ulong upperLimit)
        {
            _Sieve = new SieveOfAtkin(upperLimit);
        }

        public IEnumerable<ulong> PrimeFactors()
        {
            foreach (ulong p in _Sieve.Primes)
                yield return p;
        }
    }
}

