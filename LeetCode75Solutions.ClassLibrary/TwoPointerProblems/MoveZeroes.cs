using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.TwoPointerProblems
{
    public class MoveZeroes
    {
        public static void MvZeroes(int[] nums)
        {
            int FPtr = 0;
            int SPtr = 0;
            while (FPtr < nums.Length)
            {
                SPtr = FPtr + 1;
                while (SPtr < nums.Length && nums[FPtr] == 0)
                {
                    if (nums[SPtr] != 0)
                    {
                        nums[FPtr] = nums[SPtr];
                        nums[SPtr] = 0;
                        break;
                    }
                    SPtr++;
                }
                FPtr++;
            }
        }
    }
}
