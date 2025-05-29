using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    public class IncreasingTripletSubsequence
    {
        public static bool IncreasingTriplet(int[] nums)
        {
            int first = int.MaxValue;
            int second = int.MaxValue;
            foreach (var num in nums)
            {
                if (num <= first)
                {
                    first = num;
                }
                else if (num <= second)
                {
                    second = num;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
