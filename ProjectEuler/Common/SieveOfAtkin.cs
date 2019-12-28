using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ProjectEuler.Common
{
    public class SieveOfAtkin : IEnumerable<ulong>
    {
        private readonly List<ulong> _Primes;

        private readonly ulong _UpperLimit;

        public List<ulong> Primes
        {
            get { return _Primes; }
        }

        public ulong UpperLimit
        {
            get { return _UpperLimit; }
        }

        public SieveOfAtkin(ulong upperLimit)
        {
            _UpperLimit = upperLimit;
            _Primes = new List<ulong>()
                {
                    2,
                    3                
                };

            FindPrimes();
        }

        public IEnumerator<ulong> GetEnumerator()
        {
            if (!_Primes.Any())
                FindPrimes();

            foreach (var p in _Primes)
                yield return p;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }

        private void FindPrimes()
        {
            List<bool> isPrime = new List<bool>();//[UpperLimit];
            var sqrtLimit = (ulong)Math.Sqrt(UpperLimit);
            for (ulong x = 0; x <= sqrtLimit; x++)
            {
                for (ulong y = 0; y <= sqrtLimit; y++)
                {
                    var xSqrt = x * x;
                    var ySqrt = y * y;
                    var n = 4 * xSqrt + ySqrt;
                    if (n <= UpperLimit && (n % 12 == 1 || n % 12 == 5))
                        //isPrime[n] ^= true
                        isPrime.Add(true);
                    else
                        isPrime.Add(false);

                    n = 3 * xSqrt + ySqrt;
                    if (n <= UpperLimit && n % 12 == 7)
                        //isPrime[n] ^= true;
                        isPrime.Add(true);
                    else
                        isPrime.Add(false);

                    n = 3 * xSqrt - ySqrt;
                    if (x > y && n <= UpperLimit && n % 12 == 11)
                        //isPrime[n] ^= true;
                        isPrime.Add(true);
                    else
                        isPrime.Add(false);
                }
            }
            
            Int64 s = 600851475143;
            isPrime.ElementAt((int)s);
            /*
            for (Int64 i = 5; (ulong)i <= sqrtLimit; i++)
            {
                if (isPrime.ElementAt(i))
                {
                    var s = i * i;
                    for (ulong k = s; k <= sqrtLimit; k += s)
                        isPrime[k] = false;
                }
            }

            for (ulong j = 5; j <= sqrtLimit; j += 2)
            {
                if (isPrime[j])
                    Primes.Add(j);
            }
             */
        }
    }
}
