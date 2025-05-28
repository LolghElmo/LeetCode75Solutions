using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75Solutions.UWP.Pages.ArrayStringProblems.KidsWithCandies
{
    public class KidPlot
    {
        public int Index { get; set; }
        public int Candies { get; set; }
        public string Image => "ms-appx:///Assets/kid.png";
        public string CandyText => $"🍬 x {Candies}";
    }
}
