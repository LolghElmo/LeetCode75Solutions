using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.ArrayStringProblems
{
    public class LexicographicallySmallestString
    {
        private class UnionFind
        {
            private int[] parent;

            public UnionFind(int size)
            {
                parent = new int[size];
                for (int i = 0; i < size; i++)
                    parent[i] = i;
            }

            public int Find(int x)
            {
                if (parent[x] != x)
                    parent[x] = Find(parent[x]);
                return parent[x];
            }

            public void Union(int x, int y)
            {
                int rx = Find(x);
                int ry = Find(y);
                if (rx == ry) return;

                if (rx < ry)
                    parent[ry] = rx;
                else
                    parent[rx] = ry;
            }
        }
        public string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            UnionFind uf = new UnionFind(26);
            int n = s1.Length;
            for (int i = 0; i < n; i++)
            {
                int a = s1[i] - 'a';
                int b = s2[i] - 'a';
                uf.Union(a, b);
            }
            StringBuilder sb = new StringBuilder(baseStr.Length);
            foreach (char c in baseStr)
            {
                int root = uf.Find(c - 'a');
                char smallestEquivalent = (char)(root + 'a');
                sb.Append(smallestEquivalent);
            }

            return sb.ToString();
        }
    }
}
