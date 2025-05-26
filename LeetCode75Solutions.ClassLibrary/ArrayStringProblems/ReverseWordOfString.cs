using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    public class ReverseWordOfString
    {
        public string ReverseWords(string s)
        {
            List<string> words = new List<string>();
            int index = 0;

            while (index < s.Length)
            {
                string word = GetWordFromLeft(s, ref index);
                if (!string.IsNullOrEmpty(word))
                    words.Add(word);
            }

            words.Reverse();
            return string.Join(" ", words);
        }
        string GetWordFromLeft(string s, ref int index)
        {
            string word = string.Empty;

            while (index < s.Length && Char.IsWhiteSpace(s[index]))
            {
                index++;
            }

            while (index < s.Length && !Char.IsWhiteSpace(s[index]))
            {
                word += s[index];
                index++;
            }

            return word;
        }
        string GetWordFromRight(string s, ref int index)
        {
            string word = string.Empty;

            while (index >= 0 && Char.IsWhiteSpace(s[index]))
            {
                index--;
            }

            while (index >= 0 && !Char.IsWhiteSpace(s[index]))
            {
                word = s[index] + word;
                index--;
            }

            return word;
        }


    }
}
