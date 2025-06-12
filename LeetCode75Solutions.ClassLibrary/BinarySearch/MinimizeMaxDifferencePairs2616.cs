using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.BinarySearch
{
    internal class MinimizeMaxDifferencePairs2616
    {
        public int MinimizeMax(int[] nums, int p)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int lo = 0, hi = nums[n - 1] - nums[0];
            return BinarySearch(lo, hi, nums, p);
        }

        private int BinarySearch(int lo, int hi, int[] nums, int p)
        {
            if (lo >= hi)
                return lo;

            int mid = lo + (hi - lo) / 2;
            if (CanFormPairs(nums, p, mid))
                return BinarySearch(lo, mid, nums, p);
            else
                return BinarySearch(mid + 1, hi, nums, p);
        }

        private bool CanFormPairs(int[] nums, int p, int limit)
        {
            int count = 0;
            for (int i = 1; i < nums.Length && count < p;)
            {
                if (nums[i] - nums[i - 1] <= limit)
                {
                    count++;
                    i += 2;
                }
                else
                {
                    i += 1;
                }
            }
            return count >= p;
        }
    }
}
