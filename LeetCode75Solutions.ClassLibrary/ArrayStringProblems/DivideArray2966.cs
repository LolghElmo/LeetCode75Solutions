using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    internal class DivideArray2966
    {
        public int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);
            int resArrayNums = nums.Length / 3;
            int[][] res = new int[resArrayNums][];
            for (int i = 0; i < resArrayNums; i++)
            {
                int jndex = i * 3;
                if (nums[jndex + 2] - nums[jndex] > k)
                {
                    return new int[0][];
                }
                res[i] = new int[3] { nums[jndex], nums[jndex + 1], nums[jndex + 2] };

            }
            return res;
        }
    }
}
