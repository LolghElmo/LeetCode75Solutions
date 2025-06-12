using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.BinarySearch
{
    internal class BinarySearch704
    {
        public int Search(int[] nums, int target)
        {
            return BinSearch(nums, target, 0, nums.Length - 1);
        }
        public int BinSearch(int[] nums, int target, int left, int right)
        {
            if (left > right)
                return -1;

            int middle = left + (right - left) / 2;

            if (nums[middle] == target)
                return middle;
            else if (nums[middle] < target)
                return BinSearch(nums, target, middle + 1, right);
            else
                return BinSearch(nums, target, left, middle - 1);
        }
    }
}
