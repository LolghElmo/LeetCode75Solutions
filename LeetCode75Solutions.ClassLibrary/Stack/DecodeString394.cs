using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.Stack
{
    internal class DecodeString394
    {
        public string DecodeString(string s)
        {
            Stack<int> count = new Stack<int>();
            Stack<string> chars = new Stack<string>();
            StringBuilder sb = new StringBuilder();
            int k = 0;
            foreach (char ch in s)
            {
                if (char.IsDigit(ch))
                {
                    k = k * 10 + (ch - '0');
                }
                else if (ch == '[')
                {
                    count.Push(k);
                    chars.Push(sb.ToString());
                    sb = new StringBuilder();
                    k = 0;
                }
                else if (ch == ']')
                {
                    int repeat = count.Pop();
                    StringBuilder tempSb = new StringBuilder(chars.Pop());
                    for (int i = 0; i < repeat; i++)
                    {
                        tempSb.Append(sb);
                    }
                    sb = tempSb;
                }
                else
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }
    }
}
