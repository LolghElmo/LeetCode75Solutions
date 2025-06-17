using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    internal class ParitionMaximumDifference2294
    {
        public int PartitionArray(int[] nums, int k)
        {
            Array.Sort(nums);
    
            int count = 1;
            int currMin = nums[0], currMax = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int x = nums[i];
                currMin = Math.Min(currMin, x);
                currMax = Math.Max(currMax, x);

                if (currMax - currMin > k)
                {
                    count++;
                    currMin = currMax = x;
                }
            }

            return count;
        }
    }
}
