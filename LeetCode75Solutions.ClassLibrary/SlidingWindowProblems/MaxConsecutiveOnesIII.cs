using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.SlidingWindowProblems
{
    public class MaxConsecutiveOnesIII
    {
        public int LongestOnes(int[] nums, int k)
        {
            int left = 0;
            int maxSize = 0;
            int tries = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                    tries++;
                while (tries > k)
                {
                    if (nums[left] == 0)
                        tries--;
                    left++;
                }

                maxSize = Math.Max(maxSize, right - left + 1);

            }
            return maxSize;
        }
    }
}
