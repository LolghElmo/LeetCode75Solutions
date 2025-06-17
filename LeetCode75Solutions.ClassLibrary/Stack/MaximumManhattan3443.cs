using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.Stack
{
    internal class MaximumManhattan3443
    {
        public int MaxDistance(string s, int k)
        {
            int n = s.Length;
            int[] sx = { +1, +1, -1, -1 };
            int[] sy = { +1, -1, +1, -1 };

            long ans = 0;
            long[] f0 = new long[4];
            var counts = new Dictionary<int, int>[4];
            var stacks = new Stack<int>[4];
            for (int q = 0; q < 4; q++)
            {
                counts[q] = new Dictionary<int, int> { [0] = 0, [1] = 0, [2] = 0 };
                stacks[q] = new Stack<int>();
            }

            for (int i = 0; i < n; i++)
            {
                char c = s[i];
                int dx = 0, dy = 0;
                if (c == 'N') dy = +1;
                else if (c == 'S') dy = -1;
                else if (c == 'E') dx = +1;
                else if (c == 'W') dx = -1;

                for (int u = 0; u < 4; u++)
                {
                    int g0 = sx[u] * dx + sy[u] * dy;
                    int gain = 1 - g0;
                    f0[u] += g0;

                    counts[u][gain] += 1;
                    stacks[u].Push(gain);
                    int rem = k;
                    long sumGain = 0;
                    for (int q = 2; q >= 1 && rem > 0; q--)
                    {
                        int have = counts[u][q];
                        int use = Math.Min(have, rem);
                        sumGain += (long)use * q;
                        rem -= use;
                    }
                    long bestProj = f0[u] + sumGain;
                    if (bestProj > ans) ans = bestProj;
                }
            }

            return (int)ans;
        }
    }
}

