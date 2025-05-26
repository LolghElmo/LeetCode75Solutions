using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    public class ReverseVowelsOfString
    {
        public static string ReverseVowels(string s)
        {
            char[] reversed = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (!isVowel(reversed[left]))
                {
                    left++;
                    continue;
                }

                if (!isVowel(reversed[right]))
                {
                    right--;
                    continue;
                }

                char temp = reversed[left];
                reversed[left] = reversed[right];
                reversed[right] = temp;

                left++;
                right--;
            }

            return new string(reversed);
        }
        public static bool isVowel(char c)
        {
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return vowels.Contains(c);
        }
    }
}
