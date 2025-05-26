using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    public class PlaceFlowers
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (n == 0)
                    return true;
                if (flowerbed[i] == 0)
                {
                    bool leftIsEmpty = i == 0 || flowerbed[i - 1] == 0;
                    bool rightIsEmpty = i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;

                    if (leftIsEmpty && rightIsEmpty)
                    {
                        n--;

                        flowerbed[i] = 1;
                    }
                }
            }
            return n == 0;
        }
    }
}
