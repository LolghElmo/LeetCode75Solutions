using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.HashAndSetsProblems
{
    public class UniqueNumberOfOccurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (keyValuePairs.ContainsKey(i))
                {
                    keyValuePairs[i]++;
                }
                else keyValuePairs[i] = 1;
            }
            HashSet<int> hashSet = new HashSet<int>();
            foreach (int i in keyValuePairs.Values)
            {
                if (hashSet.Contains(i))
                    return false;
                else
                    hashSet.Add(i);
            }


            return true;
        }
    }
}
