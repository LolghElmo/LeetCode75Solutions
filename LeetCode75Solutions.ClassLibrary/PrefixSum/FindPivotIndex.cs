using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.PrefixSum
{
    internal class FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            var totalSum = 0;
            foreach (var item in nums)
                totalSum += item;
            int preSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sufSum = totalSum - nums[i] - preSum;
                if (sufSum == preSum)
                {
                    return i;
                }
                preSum += nums[i];

            }
            return -1;
        }
    }
}
