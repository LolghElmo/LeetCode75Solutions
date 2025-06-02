using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.PrefixSum
{
    internal class FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            var preSumArr = new int[nums.Length];
            int preSum = 0;
            foreach (int i in nums)
            {
                preSum += preSumArr[i];
                preSumArr[i] = preSum;
            }

            int suf = nums.Length - 1;
            int sufSum = 0;
            while (suf >= 0)
            {
                sufSum += nums[suf];

            }
            return -1;
        }
    }
}
