using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.PrefixSum
{
    public class FindHighestAltitude
    {
        public int LargestAltitude(int[] gain)
        {
            var prefixArr = new int[gain.Length];
            prefixArr[0] = 0;
            int sum = 0;
            int maxSum = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                sum += gain[i];
                maxSum = Math.Max(maxSum, sum);
            }
            return maxSum;
        }
    }
}
