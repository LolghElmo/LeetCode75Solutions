using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.MathProblems
{
    internal class MaxDifferenceChangingInteger1432
    {
        public int MaxDiff(int num)
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
            decidedChar = ' ';

            if (minNum[0] != '1')
            {
                decidedChar = minNum[0];
                for (int i = 0; i < minNum.Length; i++)
                {
                    if (minNum[i] == decidedChar)
                    {
                        minNum[i] = '1';
                    }
                }
            }
            else
            {
                for (int i = 1; i < minNum.Length; i++)
                {
                    if (minNum[i] != '0' && minNum[i] != '1')
                    {
                        decidedChar = minNum[i];
                        for (int j = 1; j < minNum.Length; j++)
                        {
                            if (minNum[j] == decidedChar)
                            {
                                minNum[j] = '0';
                            }
                        }
                        break;
                    }
                }
            }
            return int.Parse(new string(maxNum)) - int.Parse(new string(minNum));
        }
    }

}
