using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.MathProblems
{
    internal class MaxRemappingDigit2566
    {
        public int MinMaxDifference(int num)
        {
            var maxNum = num.ToString().ToCharArray();
            char decidedChar = ' ';
            for (int i = 0; i < maxNum.Length; i++)
            {
                if (decidedChar == ' ' && maxNum[i] != '9')
                {
                    decidedChar = maxNum[i];
                }

                if (maxNum[i] == decidedChar)
                {
                    maxNum[i] = '9';
                }
            }
            var minNum = num.ToString().ToCharArray();
            decidedChar = minNum[0];
            for (int i = 0; i < minNum.Length; i++)
            {
                if (minNum[i] == decidedChar)
                {
                    minNum[i] = '0';
                }
            }
            return int.Parse(new string(maxNum)) - int.Parse(new string(minNum));
        }
    }
}
