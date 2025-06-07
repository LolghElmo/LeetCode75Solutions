using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.Stack
{
    internal class RemoveStarsFromString
    {
        public string RemoveStars(string s)
        {
            Stack<char> chars = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (s[i] == '*')
                {
                    if (chars.Count > 0)
                        chars.Pop();
                }
                else
                    chars.Push(ch);
            }
            StringBuilder res = new StringBuilder();
            foreach (char ch in chars)
            {
                res.Insert(0, ch);
            }
            return res.ToString() ;
        }
    }
}
