using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.HashAndSetsProblems
{
    public class DifferenceInTwoArrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var res = new List<IList<int>>();
            HashSet<int> setNums1 = new HashSet<int>(nums1);
            HashSet<int> setNums2 = new HashSet<int>(nums2);

            var diff1 = setNums1.Except(setNums2).ToList();
            var diff2 = setNums2.Except(setNums1).ToList();
            return new List<IList<int>> { diff1, diff2 };
        }
    }
}
