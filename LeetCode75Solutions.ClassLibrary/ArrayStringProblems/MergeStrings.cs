using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    public static class MergeStrings
    {
        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder result = new StringBuilder();
            int i = 0;

            while (i < word1.Length || i < word2.Length)
            {
                if (i < word1.Length)
                    result.Append(word1[i]);
                if (i < word2.Length)
                    result.Append(word2[i]);
                i++;
            }

            return result.ToString();
        }
    }
}
