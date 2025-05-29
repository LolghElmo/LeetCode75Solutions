using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    public class StringCompression
    {
        public static int Compress(char[] chars)
        {
            int write = 0;
            int read = 0;

            while (read < chars.Length)
            {
                char currentChar = chars[read];
                int count = 0;

                while (read < chars.Length && chars[read] == currentChar)
                {
                    read++;
                    count++;
                }

                chars[write++] = currentChar;

                if (count > 1)
                {
                    foreach (char c in count.ToString())
                    {
                        chars[write++] = c;
                    }
                }
            }

            return write;
        }

    }
}
