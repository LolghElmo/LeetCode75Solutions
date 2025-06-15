using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    internal class MaxIncreasingElementsDifference2016
    {
        public int MaximumDifference(int[] nums)
        {
            int min = nums[0];
            int maxDiff = -1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > min)
                {
                    maxDiff = Math.Max(maxDiff, nums[i] - min);
                }
                else
                {
                    min = nums[i];
                }
            }

            return maxDiff;
        }
    }
}
