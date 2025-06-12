using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.Queue
{
    internal class Dota2Senate649
    {
        public string PredictPartyVictory(string senate)
        {
            Queue<int> direQueue = new Queue<int>();
            Queue<int> radQueue = new Queue<int>();

            for (int i = 0; i < senate.Length; i++)
            {
                if (senate[i] == 'R')
                    radQueue.Enqueue(i);
                else
                    direQueue.Enqueue(i);
            }
            while (direQueue.Count > 0 && radQueue.Count > 0)
            {
                int dIndex = direQueue.Dequeue();
                int rIndex = radQueue.Dequeue();
                if (rIndex < dIndex)
                    radQueue.Enqueue(rIndex + senate.Length);
                else
                    direQueue.Enqueue(rIndex + senate.Length);
            }
            return radQueue.Count > 0 ? "Radiant" : "Dire";
        }
    }
}
