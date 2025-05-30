using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.SlidingWindowProblems
{
    public class MaxNumberOfVowelsInSubstring
    {
        public int MaxVowels(string s, int k)
        {
            int maxVowels = 0;
            int currVowels = 0;
            for (int i = 0; i < k; i++)
            {
                currVowels += isVowel(s[i]) ? 1 : 0;
            }
            maxVowels = currVowels;

            for (int i = k; i < s.Length; i++)
            {
                currVowels += (isVowel(s[i]) ? 1 : 0) - (isVowel(s[i - k]) ? 1 : 0);
                maxVowels = Math.Max(currVowels, maxVowels);
            }
            return maxVowels;
        }

        public static bool isVowel(char c)
        {
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return vowels.Contains(c);
        }
    }
}
