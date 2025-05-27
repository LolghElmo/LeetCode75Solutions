using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    public static class GCDOfStrings
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            if (!(str1 + str2).Equals(str2 + str1))
                return string.Empty;

            int gcdLen = Gcd(str1.Length, str2.Length);
            return str1.Substring(0, gcdLen);
        }

        private static int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }


        public static int DivideStrings(string dividend, string divisor)
        {
            if (string.IsNullOrWhiteSpace(dividend) || string.IsNullOrWhiteSpace(divisor))
                throw new ArgumentException("Inputs must be non‐empty decimal strings.");

            BigInteger num1 = BigInteger.Parse(dividend);
            BigInteger num2 = BigInteger.Parse(divisor);
            if (num2.IsZero)
                throw new DivideByZeroException("Divisor cannot be zero.");

            BigInteger quotient = num1 / num2;

            if (quotient > int.MaxValue || quotient < int.MinValue)
                throw new OverflowException("Result does not fit in an Int32.");

            return (int)quotient;
        }
    }
}
