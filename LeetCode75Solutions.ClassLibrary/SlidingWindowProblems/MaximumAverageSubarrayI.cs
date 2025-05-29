using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.SlidingWindowProblems
{
    public class MaximumAverageSubarrayI
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            int maxNum = 0;
            int CurrNum = 0;
            for (int i = 0; i < k; i++)
            {
                CurrNum += nums[i];
            }
            maxNum = CurrNum;
            for (int i = k; i < nums.Length; i++)
            {
                CurrNum += nums[i] - nums[i - k];
                maxNum = Math.Max(maxNum, CurrNum);
            }
            return (double)maxNum / k;
        }
    }
}
