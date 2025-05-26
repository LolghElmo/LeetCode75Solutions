using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    public static class GreatestKidsWithCandies
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            //// inefficient solution:
            //    var boolResult = new List<bool>();

            //    for (int i = 0; i < candies.Length; i++)
            //    {
            //        int currentCandies = candies[i] + extraCandies;
            //        bool isGreatest = true;

            //        for (int j = 0; j < candies.Length; j++)
            //        {
            //            if (currentCandies < candies[j])
            //            {
            //                isGreatest = false;
            //                break;
            //            }
            //        }

            //        boolResult.Add(isGreatest);
            //    }

            //    return boolResult;
            //}

            IList<bool> result = new List<bool>();
            int maxCandies = candies.Max();

            foreach (var candy in candies)
            {
                result.Add(candy + extraCandies >= maxCandies);
            }

            return result;
        }
    }
}