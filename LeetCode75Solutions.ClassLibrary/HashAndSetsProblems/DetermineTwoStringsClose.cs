using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.HashAndSetsProblems
{
    public class DetermineTwoStringsClose
    {
        public bool CloseStrings(string word1, string word2)
        {
            //inefficeint solution
            //if (word1.Length != word2.Length) return false;

            //Dictionary<char, int> word1Occ = new Dictionary<char, int>();
            //foreach (char letter in word1)
            //{
            //    if (word1Occ.ContainsKey(letter))
            //    {
            //        word1Occ[letter]++;
            //    }
            //    else
            //        word1Occ[letter] = 1;
            //}
            //word2 = new string(word2.OrderBy(c => c).ToArray());
            //Dictionary<char, int> wordPlan = new Dictionary<char, int>();
            //foreach (char letter in word2)
            //{
            //    if (wordPlan.ContainsKey(letter))
            //    {
            //        wordPlan[letter]++;
            //    }
            //    else
            //        wordPlan[letter] = 1;
            //}

            //foreach (char letter in wordPlan.Keys)
            //{
            //    if (!word1Occ.ContainsKey(letter)) return false;
            //}
            //foreach (int count in wordPlan.Values)
            //{
            //    if (!word1Occ.ContainsValue(count)) return false;
            //    else
            //    {
            //        foreach (char letter in word1Occ.Keys.ToList())
            //        {
            //            if (word1Occ[letter] == count)
            //            {
            //                word1Occ.Remove(letter);
            //                break;
            //            }
            //        }
            //    }

            //}
            //return true;

            if (word1.Length != word2.Length) return false;

            Dictionary<char, int> word1Occurance = new Dictionary<char, int>();
            foreach (char ch in word1)
                if (word1Occurance.ContainsKey(ch)) word1Occurance[ch]++;
                else word1Occurance[ch] = 1;
            Dictionary<char, int> word2Occurance = new Dictionary<char, int>();
            foreach (char ch in word2)
                if (word2Occurance.ContainsKey(ch)) word2Occurance[ch]++;
                else word2Occurance[ch] = 1;

            HashSet<char> word1Letter = new HashSet<char>(word1Occurance.Keys);
            HashSet<char> word2Letter = new HashSet<char>(word2Occurance.Keys);
            foreach (char ch in word1Letter)
                if (!word2Letter.Contains(ch)) return false;

            List<int> sortedWord1Values = word1Occurance.Values.OrderBy(val => val).ToList();
            List<int> sortedWord2Values = word2Occurance.Values.OrderBy(val => val).ToList();

            return sortedWord1Values.SequenceEqual(sortedWord2Values);
        }
    }
}
