using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.TwoPointerProblems
{
    public class MaxNumberOfK_SumPairs
    {
        public static int MaxOperations(int[] nums, int k)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            int count = 0;

            foreach (int num in nums)
            {
                int complement = k - num;

                if (freq.ContainsKey(complement) && freq[complement] > 0)
                {
                    count++;
                    freq[complement]--;
                }
                else
                {
                    if (!freq.ContainsKey(num))
                        freq[num] = 0;
                    freq[num]++;
                }
            }

            return count;
        }

    }
}
