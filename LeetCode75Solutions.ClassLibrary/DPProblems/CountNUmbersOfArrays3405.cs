using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.DPProblems
{
    internal class CountNUmbersOfArrays3405
    {
        public int CountGoodArrays(int n, int m, int k)
        {
            long ModPow(long x, long e)
            {
                long r = 1;
                x %= 1000000007;
                while (e > 0)
                {
                    if ((e & 1) == 1) r = (r * x) % 1000000007;
                    x = (x * x) % 1000000007;
                    e >>= 1;
                }
                return r;
            }
            long ModInv(long x) => ModPow(x, 1000000007 - 2);
            if (k < 0 || k >= n) return 0;
            int nn = n - 1;
            long c = 1;
            for (int i = 1; i <= k; i++)
            {
                c = c * (nn - k + i) % 1000000007;
                c = c * ModInv(i) % 1000000007;
            }
            long ways = c * (m % 1000000007) % 1000000007;
            ways = ways * ModPow(m - 1, nn - k) % 1000000007;

            return (int)ways;
        }
    }
}
