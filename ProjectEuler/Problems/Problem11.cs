using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public static class Problem11
    {
        public static int Checksum()
        {
            int[] checksumArr = new int[302];
            checksumArr[0] = 1;

            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 0; j < 302; j++)
                {
                    if (checksumArr[j] != 0)
                        checksumArr[j] *= 2;

                    if (checksumArr[j] >= 10)
                    {
                        checksumArr[j] -= 10;
                        checksumArr[j + 1] += 1;
                    }
                }
            }

            int checksum = 0;
            foreach (int p in checksumArr)
                checksum += p;
            
            return checksum;
        }

    }
}
