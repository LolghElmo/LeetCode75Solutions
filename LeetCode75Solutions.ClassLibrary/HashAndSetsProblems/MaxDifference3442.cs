using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.HashAndSetsProblems
{
    internal class MaxDifference3442
    {
        public int MaxDifference(string s)
        {
            int maxOdd = 0;
            int minEven = int.MaxValue;
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }
            foreach (char c in freq.Keys)
            {
                if (freq[c] % 2 == 0)
                {
                    minEven = Math.Min(minEven, freq[c]);
                }
                else
                {
                    maxOdd = Math.Max(maxOdd, freq[c]);
                }
            }
            return maxOdd - minEven;
        }
    }
}
