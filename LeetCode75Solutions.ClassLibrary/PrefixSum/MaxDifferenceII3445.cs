using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.PrefixSum
{
    internal class MaxDifferenceII3445
    {
        public int MaxDifference(string s, int k)
        {
            int n = s.Length;
            int ans = int.MinValue;
            for (char a = '0'; a <= '4'; a++)
            {
                for (char b = '0'; b <= '4'; b++)
                {
                    if (a == b) continue;
                    var best = new int[] { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue };
                    int cntA = 0, cntB = 0;
                    int prevA = 0, prevB = 0;
                    int left = -1;

                    for (int right = 0; right < n; right++)
                    {
                        cntA += s[right] == a ? 1 : 0;
                        cntB += s[right] == b ? 1 : 0;

                        while (right - left >= k && cntB - prevB >= 2)
                        {
                            int statusL = ((prevA & 1) << 1) | (prevB & 1);
                            best[statusL] = Math.Min(best[statusL], prevA - prevB);
                            left++;
                            prevA += s[left] == a ? 1 : 0;
                            prevB += s[left] == b ? 1 : 0;
                        }

                        int statusR = ((cntA & 1) << 1) | (cntB & 1);
                        int need = (((statusR >> 1) ^ 1) << 1) | (statusR & 1);

                        if (best[need] != int.MaxValue)
                            ans = Math.Max(ans, (cntA - cntB) - best[need]);
                    }
                }
            }
            return ans == int.MinValue ? -1 : ans;
        }

    }
}
