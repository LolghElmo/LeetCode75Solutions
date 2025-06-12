using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    internal class MaxAdjacentDistance3423
    {
        public int MaxAdjacentDistance(int[] nums)
        {
            int maxDiff = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int after = (i + 1) % nums.Length;
                int currDiff = Math.Abs(nums[i] - nums[after]);
                maxDiff = Math.Max(maxDiff, currDiff);
            }
            return maxDiff;
        }
    }
}
