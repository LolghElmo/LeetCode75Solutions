using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.Queue
{
    internal class RecentCalls933
    {
        public class RecentCounter
        {
            Queue<int> counter;
            public RecentCounter()
            {
                counter = new Queue<int>();
            }

            public int Ping(int t)
            {
                counter.Enqueue(t);
                int number = 0;
                int count = 0;
                foreach (var time in counter)
                {
                    if (time >= t - 3000)
                        count++;
                    else break;
                }
                return count;
            }
        }
    }
}