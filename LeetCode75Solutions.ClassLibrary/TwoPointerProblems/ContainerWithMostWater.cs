using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.TwoPointerProblems
{
    public class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int left = 0;
            int maxArea = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int h = height[left] < height[right] ? height[left] : height[right];
                int w = right - left;
                maxArea = Math.Max(h * w, maxArea);
                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return maxArea;
        }
    }
}
