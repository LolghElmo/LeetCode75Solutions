using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.SlidingWindowProblems
{
    internal class LongestSubarrayAfterDeletingElement
    {
        public int LongestSubarray(int[] nums)
        {
            int maxSize = 0;
            int left = 0;
            int alreadyDeleted = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] != 1)
                {
                    alreadyDeleted++;
                }

                while (alreadyDeleted > 1)
                {
                    if (nums[left] != 1)
                    {
                        alreadyDeleted--;
                    }
                    left++;
                }

                maxSize = Math.Max(maxSize, right - left);
            }


            return maxSize;
        }
    }
}
