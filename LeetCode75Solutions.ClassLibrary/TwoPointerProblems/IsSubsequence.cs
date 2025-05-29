using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.TwoPointerProblems
{
    public class IsSubsequence
    {
        public static bool IsSub(string s, string t)
        {
            int FPtr = 0;
            int SPtr = 0;
            while (FPtr < s.Length && SPtr < t.Length)
            {
                if (t[SPtr] == s[FPtr])
                {
                    FPtr++;
                }
                SPtr++;
            }
            return FPtr == s.Length;
        }
    }
}
